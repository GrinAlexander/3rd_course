   M S B A M L   `   `   `  ���� [  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  H DCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CourseProjectCourseProject    CourseProject.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:CourseProject       � Icon$  icon.ico�� � Title$ Curve��$	��900��$	��900��$	��900��$	��750�� � WindowStartupLocation$ CenterScreen=�.��� .+���  �� Orientation$ 
Horizontal=�.+�o� $
��Left=�$	��Top=�
����� �
�������.@�m� $��Файл��$��12(�$��Center=�$��Center=�.@�m� -   $��Открыть��m� -   $��Сохранить��m� -   $��Очистить��m� -   $��Закрыть��m� $��О программе��$��12(�$��Center=�$��Center=�.@�m� -   $��Разработчик��m� -   $��Справка��� $��36,22,36,649q�.+��� -    ��Name$ tb_x1��$
��Left=�$��30��$��	65,60,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��35��
���   �$��Center=�$��Center=� �� 	MaxLength$ 4���� -   $ tb_y1��$
��Left=�$��30��$��
125,60,0,0q�$
 Wrap=�$	��Top=�$��35��
���   �$��Center=�$��Center=�$ 4���� -	    ��Name$ label_ox��$��Ox��$
��Left=�$��	65,29,0,0q�$	��Top=�$��Center=�$��Center=�$��35���� -
   $ label_oy��$��Oy��$
��Left=�$��
125,30,0,0q�$	��Top=�$��35��$��Center=�$��Center=��� -   $ label_point1��$��Точка 1��$
��Left=�$��0,60,0,0q�$	��Top=�$��Center=�$��Center=�$��55���� -   $ tb_x2��$
��Left=�$��30��$��	65,91,0,0q�$
 Wrap=�$	��Top=�$��35��
���   �$��Center=�$��Center=�$ 4���� -   $ tb_y2��$
��Left=�$��30��$��
125,91,0,0q�$
 Wrap=�$	��Top=�$��35��
���   �$��Center=�$��Center=�$ 4���� -   $ label_point2��$��Точка 2��$
��Left=�$��0,92,0,0q�$	��Top=�$��Center=�$��Center=�$��55���� -   $ tb_x3��$
��Left=�$��30��$��
65,122,0,0q�$
 Wrap=�$	��Top=�$��35��
���   �$��Center=�$��Center=�$ 4���� -   $ tb_y3��$
��Left=�$��30��$��125,122,0,0q�$
 Wrap=�$	��Top=�$��35��
���   �$��Center=�$��Center=�$ 4���� -   $ label_point3��$��Точка 3��$
��Left=�$��	0,122,0,0q�$	��Top=�$��Center=�$��Center=�$��55���� -   $��Построить��$
��Left=�$��
232,60,0,0q�$	��Top=�$	��120��$��30�� J� RenderTransformOrigin$ 	0.483,0.5&�� $��Right=�$��0,60,0,0q�$	��Top=�$	��270��.+��� -   	 ��Name$	 comboBox_curve��$��Right=�$	��150��$��30��$
��Left=�$��Center=�.@��� $��Кривая Безье���� $%��Кривая Гильберта���� $)��#Кривая Серпинского���� $%��Выберите функцию��$
��Left=��� -   $��Очистить��$
��Left=�$��232,120,0,0q�$	��Top=�$	��120��$��30���� -   
 ��Name$
 
chkRefresh��$%��Обновлять кривую��$��100, 170, 10, 0q�$	��150��$��30��$y�Hidden=�$
��Left=�$	��Top=��� -   $��picCanvas_border��$��36,220,36,10q�
���   �$��2q�
�������._�� -   $��floatingTip�� � AllowsTransparency . $��Relative=� � PlacementTarget ��  �� ElementName$ picCanvas_border��.���� -    ��Name$ tb_popup��