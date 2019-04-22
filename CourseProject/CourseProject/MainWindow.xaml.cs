using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System.IO;
using System.Xml.Linq;
using System.Security.Principal;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double x;
        private double y;
        private int depth;
        private bool? m_Refresh;
        private Bitmap m_Bm;
        private Bezier bezier = new Bezier();
        private Canvas pictureCanvas;
        private PictureBox pictureBox = new PictureBox();
        private WindowsFormsHost winHost = new WindowsFormsHost();
        private System.Windows.Controls.ContextMenu context;
        private float LastX, LastY;
        private XDocument xmlFileBezier;
        private XDocument xmlFileMain;
        private XElement xmlRootBezier;
        public MainWindow()
        {
            InitializeComponent();
            xmlFileBezier = new XDocument(new XElement("bezier"));
            xmlRootBezier = xmlFileBezier.Element("bezier");
            context = new System.Windows.Controls.ContextMenu();
            pictureCanvas = new Canvas();
            pictureCanvas.Background = new SolidColorBrush(Colors.White);
            pictureBox.BackColor = System.Drawing.Color.White;
            pictureCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(CanvasShowCoordinates);
            pictureCanvas.MouseLeave += new System.Windows.Input.MouseEventHandler(MouseLeaveCanvas);
            pictureCanvas.MouseRightButtonDown += new MouseButtonEventHandler(ShowContextMenu);
            System.Windows.Controls.MenuItem menuItem1 = new System.Windows.Controls.MenuItem();
            System.Windows.Controls.MenuItem menuItem2 = new System.Windows.Controls.MenuItem();
            System.Windows.Controls.MenuItem menuItem3 = new System.Windows.Controls.MenuItem();
            menuItem1.Header = "Использовать как точку 1";
            menuItem2.Header = "Использовать как точку 2";
            menuItem3.Header = "Использовать как точку 3";
            menuItem1.Click += MenuItem1_Click;
            menuItem2.Click += MenuItem2_Click;
            menuItem3.Click += MenuItem3_Click;
            context.Items.Add(menuItem1);
            context.Items.Add(menuItem2);
            context.Items.Add(menuItem3);
        }

        public void AddBezier(System.Windows.Point point1, System.Windows.Point point2, System.Windows.Point point3)
        {
            bezier = new Bezier(point1, point2, point3);
            System.Windows.Shapes.Path path = bezier.DrawBezier();
            pictureCanvas.Children.Add(path);
            AddLine(point1, point2, point3);
            AddToXML();
        }

        public void AddLine(System.Windows.Point point1, System.Windows.Point point2, System.Windows.Point point3)
        {
            bezier = new Bezier(point1, point2, point3);
            System.Windows.Shapes.Path path = bezier.DrawLines();
            pictureCanvas.Children.Add(path);
        }

        public void AddHilbert()
        {
            try
            {
                this.depth = int.Parse(tb_x1.Text);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка! Введите верные данные.");
            }
            if (depth >= 10)
            {
                System.Windows.MessageBox.Show("Слишком большая глубина рекурсии!");
                return;
            }
            if (depth <= 0)
            {
                System.Windows.MessageBox.Show("Глубина должна быть больше нуля");
                return;
            }
            this.Cursor = System.Windows.Input.Cursors.Wait;
            System.Windows.Forms.Application.DoEvents();
            m_Refresh = chkRefresh.IsChecked;
            m_Bm = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            pictureBox.Image = m_Bm;
            float total_length, start_x, start_y, start_length;
            if (pictureBox.ClientSize.Height < pictureBox.ClientSize.Width)
            {
                total_length = (float)(0.9 * pictureBox.ClientSize.Height);
            }
            else
            {
                total_length = (float)(0.9 * pictureBox.ClientSize.Width);
            }
            start_x = (pictureBox.ClientSize.Width - total_length) / 2;
            start_y = (pictureBox.ClientSize.Height - total_length) / 2;
            start_length = (float)(total_length / (Math.Pow(2, depth) - 1));
            using (Graphics gr = Graphics.FromImage(m_Bm))
            {
                gr.Clear(pictureBox.BackColor);
                LastX = (int)start_x;
                LastY = (int)start_y;
                Hilbert(gr, depth, start_length, 0);
            }
            pictureBox.Refresh();
            this.Cursor = System.Windows.Input.Cursors.Arrow;
        }

        public void AddSierpinski()
        {
            try
            {
                this.depth = int.Parse(tb_x1.Text);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка! Введите верные данные.");
            }

            if (depth >= 10)
            {
                System.Windows.MessageBox.Show("Слишком большая глубина рекурсии!");
                return;
            }
            if (depth <= 0)
            {
                System.Windows.MessageBox.Show("Глубина должна быть больше нуля");
                return;
            }
            this.Cursor = System.Windows.Input.Cursors.Wait;
            System.Windows.Forms.Application.DoEvents();
            m_Refresh = chkRefresh.IsChecked;
            m_Bm = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);

            pictureBox.Image = m_Bm;
            using (Graphics gr = Graphics.FromImage(m_Bm))
            {
                gr.Clear(pictureBox.BackColor);
                float dx = (float)(m_Bm.Width / Math.Pow(2, depth - 1) / 8);
                float dy = (float)(m_Bm.Height / Math.Pow(2, depth - 1) / 8);
                DrawSierpinski(gr, depth, dx, dy);
            }
            pictureBox.Refresh();
            this.Cursor = System.Windows.Input.Cursors.Arrow;
        }

        private void DrawSierpinski(Graphics gr, int depth, float dx, float dy)
        {
            float x = 2 * dx;
            float y = dy;
            SierpA(gr, depth, dx, dy, ref x, ref y);
            DrawRel(gr, ref x, ref y, dx, dy);
            SierpB(gr, depth, dx, dy, ref x, ref y);
            DrawRel(gr, ref x, ref y, -dx, dy);
            SierpC(gr, depth, dx, dy, ref x, ref y);
            DrawRel(gr, ref x, ref y, -dx, -dy);
            SierpD(gr, depth, dx, dy, ref x, ref y);
            DrawRel(gr, ref x, ref y, dx, -dy);
            pictureBox.Refresh();
        }

        private void SierpA(Graphics gr, float depth, float dx, float dy, ref float x, ref float y)
        {
            if (depth > 0)
            {
                depth--;

                SierpA(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, dx, dy);
                SierpB(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, 2 * dx, 0);
                SierpD(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, dx, -dy);
                SierpA(gr, depth, dx, dy, ref x, ref y);
            }
            if (m_Refresh == true) pictureBox.Refresh();
        }

        private void SierpB(Graphics gr, float depth, float dx, float dy, ref float x, ref float y)
        {
            if (depth > 0)
            {
                depth--;
                SierpB(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, -dx, dy);
                SierpC(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, 0, 2 * dy);
                SierpA(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, dx, dy);
                SierpB(gr, depth, dx, dy, ref x, ref y);
            }
            if (m_Refresh == true) pictureBox.Refresh();
        }

        private void SierpC(Graphics gr, float depth, float dx, float dy, ref float x, ref float y)
        {
            if (depth > 0)
            {
                depth--;
                SierpC(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, -dx, -dy);
                SierpD(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, -2 * dx, 0);
                SierpB(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, -dx, dy);
                SierpC(gr, depth, dx, dy, ref x, ref y);
            }
            if (m_Refresh == true) pictureBox.Refresh();
        }

        private void SierpD(Graphics gr, float depth, float dx, float dy, ref float x, ref float y)
        {
            if (depth > 0)
            {
                depth--;
                SierpD(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, dx, -dy);
                SierpA(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, 0, -2 * dy);
                SierpC(gr, depth, dx, dy, ref x, ref y);
                DrawRel(gr, ref x, ref y, -dx, -dy);
                SierpD(gr, depth, dx, dy, ref x, ref y);
            }
            if (m_Refresh == true) pictureBox.Refresh();
        }

        private void Hilbert(Graphics gr, int depth, float dx, float dy)
        {
            if (depth > 1) Hilbert(gr, depth - 1, dy, dx);
            DrawRel(gr, dx, dy);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRel(gr, dy, dx);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRel(gr, -dx, -dy);
            if (depth > 1) Hilbert(gr, depth - 1, -dy, -dx);

            if (m_Refresh == true) pictureBox.Refresh();
        }

        private void DrawRel(Graphics gr, ref float x, ref float y, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, x, y, x + dx, y + dy);
            x += dx;
            y += dy;
        }

        private void DrawRel(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            LastX = LastX + dx;
            LastY = LastY + dy;
        }

        private void Button_Draw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (comboBox_curve.SelectedIndex)
                {
                    case -1:
                        {
                            System.Windows.MessageBox.Show("Выберите кривую!");
                            break;
                        }
                    case 0:
                        {
                            double x1, y1, x2, y2, x3, y3;
                            x1 = double.Parse(tb_x1.Text); y1 = double.Parse(tb_y1.Text);
                            x2 = double.Parse(tb_x2.Text); y2 = double.Parse(tb_y2.Text);
                            x3 = double.Parse(tb_x3.Text); y3 = double.Parse(tb_y3.Text);
                            if (
                                   x1 > pictureCanvas.ActualWidth || y1 > pictureCanvas.ActualHeight
                                || x2 > pictureCanvas.ActualWidth || y2 > pictureCanvas.ActualHeight
                                || x3 > pictureCanvas.ActualWidth || y3 > pictureCanvas.ActualHeight
                                )
                            {
                                System.Windows.MessageBox.Show($"Координаты точек больше размеров холста! Высота холста {pictureCanvas.ActualHeight}, ширина холста {pictureCanvas.ActualWidth}");
                                return;
                            }
                            System.Windows.Point point1 = new System.Windows.Point(x1, y1);
                            System.Windows.Point point2 = new System.Windows.Point(x2, y2);
                            System.Windows.Point point3 = new System.Windows.Point(x3, y3);
                            AddBezier(point1, point2, point3);
                            break;
                        }
                    case 1:
                        {
                            AddHilbert();
                            break;
                        }
                    case 2:
                        {
                            AddSierpinski();
                            break;
                        }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка! Введите верные данные.");
            }
        }

        private void Button_ClearCanvas(object sender, RoutedEventArgs e)
        {
            xmlFileBezier = new XDocument(new XElement("bezier"));
            xmlRootBezier = xmlFileBezier.Element("bezier");
            pictureCanvas.Children.Clear();
            pictureBox.Image = null;
            pictureCanvas.Background = new SolidColorBrush(Colors.White);
            pictureBox.BackColor = System.Drawing.Color.White;
            tb_x1.Text = null;
            tb_y1.Text = null;
            tb_x2.Text = null;
            tb_y2.Text = null;
            tb_x3.Text = null;
            tb_y3.Text = null;
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "D:/",
                Filter = " Curve's data | *.xml"
            };
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    xmlFileMain = XDocument.Load(openFileDialog.FileName);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
                return;
            } 
            CheckOpenedXML();
        }

        private void MenuItem_Save(object sender, RoutedEventArgs e)
        {
            XDocument xmlFile = new XDocument();
            switch (comboBox_curve.SelectedIndex)
            {
                case -1:
                    {
                        System.Windows.MessageBox.Show("Выберите кривую и внесите данные!");
                        return;
                    }
                case 0:
                    {
                        if (tb_x1.Text == "" && tb_y1.Text == "" && tb_x2.Text == "" && tb_y2.Text == "" && tb_x3.Text == "" && tb_y3.Text == "")
                        {
                            System.Windows.MessageBox.Show("Внесите данные!");
                            return;
                        }
                        else
                        {
                            xmlFile = xmlFileBezier;
                        }
                        break;
                    }
                case 1:
                    {
                        if (tb_x1.Text == "")
                        {
                            System.Windows.MessageBox.Show("Внесите данные!");
                            return;
                        }
                        else
                        {
                            XElement xmlRoot = new XElement("hilbert");
                            xmlRoot = xmlFile.Element("hilbert");
                            string refresh = chkRefresh.IsChecked == true ? "true" : "false";
                            xmlFile.Add(new XElement("hilbert",
                                new XElement("depth", tb_x1.Text),
                                new XElement("refresh", refresh)));
                        }
                        break;
                    }
                case 2:
                    {
                        if (tb_x1.Text == "")
                        {
                            System.Windows.MessageBox.Show("Внесите данные!");
                            return;
                        }
                        else
                        {
                            XElement xmlRoot = new XElement("serpinski");
                            xmlRoot = xmlFile.Element("serpinski");
                            string refresh = chkRefresh.IsChecked == true ? "true" : "false";
                            xmlFile.Add(new XElement("serpinski",
                                new XElement("depth", tb_x1.Text),
                                new XElement("refresh", refresh)));
                        }
                        break;
                    }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = "D:/",
                Filter = " Curve's data | *.xml"
            };
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xmlFile.Save(saveFileDialog.FileName);
            }
            else
            {
                return;
            }
        }

        private void AddToXML()
        {
            xmlRootBezier.Add(new XElement("bezier",
                new XElement("point1X", tb_x1.Text),
                new XElement("point1Y", tb_y1.Text),
                new XElement("point2X", tb_x2.Text),
                new XElement("point2Y", tb_y2.Text),
                new XElement("point3X", tb_x3.Text),
                new XElement("point3Y", tb_y3.Text)));
        }
        private void CheckOpenedXML()
        {
            if (xmlFileMain.Root.Name == "bezier")
            {
                comboBox_curve.SelectedIndex = 0;
                LoadBezierXML();
            }
            else if (xmlFileMain.Root.Name == "hilbert")
            {
                comboBox_curve.SelectedIndex = 1;
                LoadHilbertXML();
            }
            else if (xmlFileMain.Root.Name == "serpinski")
            {
                comboBox_curve.SelectedIndex = 2;
                LoadSerpinskiXML();
            }
            else
            {
                System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривых!");
            }
        }

        private void LoadBezierXML()
        {
            System.Windows.Point point1;
            System.Windows.Point point2;
            System.Windows.Point point3;
            foreach (XElement element in xmlFileMain.Element("bezier").Elements("bezier"))
            {
                if (
                    element.Element("point1X") != null &&
                    element.Element("point1Y") != null &&
                    element.Element("point2X") != null &&
                    element.Element("point2Y") != null &&
                    element.Element("point3X") != null &&
                    element.Element("point3Y") != null
                    )
                {
                    try
                    {
                        point1 = new System.Windows.Point(double.Parse(element.Element("point1X").Value), double.Parse(element.Element("point1Y").Value));
                        point2 = new System.Windows.Point(double.Parse(element.Element("point2X").Value), double.Parse(element.Element("point2Y").Value));
                        point3 = new System.Windows.Point(double.Parse(element.Element("point3X").Value), double.Parse(element.Element("point3Y").Value));
                        AddBezier(point1, point2, point3);
                    }
                    catch
                    {
                        System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
                    }
                }
            }
        }
        private void LoadHilbertXML()
        {
            if (xmlFileMain.Element("hilbert").Element("depth") != null && xmlFileMain.Element("hilbert").Element("refresh") != null)
            {
                try
                {
                    this.depth = int.Parse(xmlFileMain.Element("hilbert").Element("depth").Value);
                    string refresh = xmlFileMain.Element("hilbert").Element("refresh").Value;
                    if (refresh.Equals("true"))
                    {
                        chkRefresh.IsChecked = true;
                    }
                    else if (refresh.Equals("false"))
                    {
                        chkRefresh.IsChecked = false;
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
                        return;
                    }
                    tb_x1.Text = depth.ToString();
                    AddHilbert();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
            }
        }

        private void LoadSerpinskiXML()
        {
            if (xmlFileMain.Element("serpinski").Element("depth") != null && xmlFileMain.Element("serpinski").Element("refresh") != null)
            {
                try
                {
                    this.depth = int.Parse(xmlFileMain.Element("serpinski").Element("depth").Value);
                    string refresh = xmlFileMain.Element("serpinski").Element("refresh").Value;
                    if (refresh.Equals("true"))
                    {
                        chkRefresh.IsChecked = true;
                    }
                    else if (refresh.Equals("false"))
                    {
                        chkRefresh.IsChecked = false;
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
                        return;
                    }
                    tb_x1.Text = depth.ToString();
                    AddSierpinski();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Загрузите корректный файл с данными о кривой!");
            }

        }
        private void CanvasShowCoordinates(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (!floatingTip.IsOpen && comboBox_curve.SelectedIndex == 0) { floatingTip.IsOpen = true; }

            System.Windows.Point point = Mouse.GetPosition(pictureCanvas);
            floatingTip.HorizontalOffset = point.X + 20;
            floatingTip.VerticalOffset = point.Y;
            tb_popup.Text = $"X:{point.X}, Y:{point.Y}";
        }

        private void MouseLeaveCanvas(object sender, System.Windows.Input.MouseEventArgs e)
        {
            floatingTip.IsOpen = false;
        }

        private void combobox_curve_Changed(object sender, SelectionChangedEventArgs e)
        {
            pictureCanvas.Children.Clear();
            pictureBox.Image = null;
            pictureCanvas.Background = new SolidColorBrush(Colors.White);
            pictureBox.BackColor = System.Drawing.Color.White;
            switch (comboBox_curve.SelectedIndex)
            {
                case 0:
                    {

                        chkRefresh.Visibility = Visibility.Hidden;
                        chkRefresh.Margin = new Thickness(100, 170, 10, 0);
                        label_ox.Visibility = Visibility.Visible;
                        label_oy.Visibility = Visibility.Visible;
                        label_point2.Visibility = Visibility.Visible;
                        label_point3.Visibility = Visibility.Visible;
                        tb_y1.Visibility = Visibility.Visible;
                        tb_x2.Visibility = Visibility.Visible;
                        tb_y2.Visibility = Visibility.Visible;
                        tb_x3.Visibility = Visibility.Visible;
                        tb_y3.Visibility = Visibility.Visible;
                        label_point1.Content = "Точка 1";
                        tb_x1.Width = 35;
                        picCanvas_border.Child = null;
                        picCanvas_border.Child = pictureCanvas;
                        break;
                    }
                case 1:
                    {
                        chkRefresh.Visibility = Visibility.Visible;
                        chkRefresh.Margin = new Thickness(100, 130, 10, 0);
                        label_ox.Visibility = Visibility.Hidden;
                        label_oy.Visibility = Visibility.Hidden;
                        label_point2.Visibility = Visibility.Hidden;
                        label_point3.Visibility = Visibility.Hidden;
                        tb_y1.Visibility = Visibility.Hidden;
                        tb_x2.Visibility = Visibility.Hidden;
                        tb_y2.Visibility = Visibility.Hidden;
                        tb_x3.Visibility = Visibility.Hidden;
                        tb_y3.Visibility = Visibility.Hidden;
                        label_point1.Content = "Глубина";
                        tb_x1.Width = 120;
                        picCanvas_border.Child = null;
                        picCanvas_border.Child = winHost;
                        winHost.Child = pictureBox;
                        break;
                    }
                case 2:
                    {
                        chkRefresh.Visibility = Visibility.Visible;
                        chkRefresh.Margin = new Thickness(100, 130, 10, 0);
                        label_ox.Visibility = Visibility.Hidden;
                        label_oy.Visibility = Visibility.Hidden;
                        label_point2.Visibility = Visibility.Hidden;
                        label_point3.Visibility = Visibility.Hidden;
                        tb_y1.Visibility = Visibility.Hidden;
                        tb_x2.Visibility = Visibility.Hidden;
                        tb_y2.Visibility = Visibility.Hidden;
                        tb_x3.Visibility = Visibility.Hidden;
                        tb_y3.Visibility = Visibility.Hidden;
                        label_point1.Content = "Глубина";
                        tb_x1.Width = 120;
                        picCanvas_border.Child = null;
                        picCanvas_border.Child = winHost;
                        winHost.Child = pictureBox;
                        break;
                    }
            }
            Button_ClearCanvas(null, null);
        }
        private void ShowContextMenu(object sender, MouseButtonEventArgs e)
        {
            context.IsOpen = true;
            System.Windows.Point point = Mouse.GetPosition(pictureCanvas);
            this.x = point.X;
            this.y = point.Y;
        }
        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            tb_x3.Text = this.x.ToString();
            tb_y3.Text = this.y.ToString();
        }

        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            tb_x2.Text = this.x.ToString();
            tb_y2.Text = this.y.ToString();
        }
        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            tb_x1.Text = this.x.ToString();
            tb_y1.Text = this.y.ToString();
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuItem_About(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Приложение является курсовой работой по теме \"Построение кривых Безье, Гильберта и Серпинского\". \n\nАвтор программы Гринь Александр.", "Curves 1.0");
        }
    }
}