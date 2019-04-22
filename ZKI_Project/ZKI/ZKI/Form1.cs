using System;
using System.Windows.Forms;
using ZKI.Ciphers;

namespace ZKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Encr_Click(object sender, EventArgs e)
        {
            switch (comboBox_changeType.SelectedIndex)
            {

                //ШИФРОВАНИЕ
                case 0:
                    {
                        switch (comboBox_cipher.SelectedIndex)
                        {
                            case 0: //Цезарь
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите ключ для шифрования!");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            Ceasar obj = new Ceasar(textBox_input.Text.ToLower(), int.Parse(textBox_key.Text));
                                            textBox_output.Text = obj.Encrypt();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Введите корректный ключ!");
                                        }
                                        
                                    }
                                    break;
                                }
                            case 1: //Виженер
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите ключ для шифрования!");
                                    }
                                    else
                                    {
                                        Vigenere obj = new Vigenere(textBox_input.Text.ToLower(), textBox_key.Text.ToLower());
                                        textBox_output.Text = obj.Encrypt();
                                    }
                                    break;
                                }
                            case 2: //Плейфер
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите ключ для шифрования!");
                                    }
                                    else
                                    {
                                        Playfair obj = new Playfair(textBox_input.Text.ToLower(), textBox_key.Text.ToLower());
                                        textBox_output.Text = obj.Encrypt();
                                    }

                                    break;
                                }
                            case 3: //Уитстон
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите первый ключ для шифрования!");
                                    }
                                    else if (textBox_key2.Text == "")
                                    {
                                        MessageBox.Show("Введите второй ключ для шифрования!");
                                    }
                                    else
                                    {
                                        Wheatstone obj = new Wheatstone(textBox_input.Text.ToLower(), textBox_key.Text.ToLower(), textBox_key2.Text.ToLower());
                                        textBox_output.Text = obj.Encrypt();
                                    }
                                    break;
                                }
                            case 4: //Вернам
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else
                                    {
                                        Vernam obj = new Vernam(textBox_input.Text, textBox_key.Text);
                                        textBox_output.Text = obj.Encrypt();
                                    }
                                    break;
                                }
                            case 5: //Шифрующие таблицы
                                {

                                    break;
                                }
                            case 6: //РСА
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите первое простое число для шифрования!");
                                    }
                                    else if (textBox_key2.Text == "")
                                    {
                                        MessageBox.Show("Введите второе простое число для шифрования!");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            long key_1 = Convert.ToInt64(textBox_key.Text.ToLower());
                                            long key_2 = Convert.ToInt64(textBox_key2.Text.ToLower());
                                            if (RSA.IsTheNumberSimple(key_1) && RSA.IsTheNumberSimple(key_2))
                                            {
                                                RSA obj = new RSA(textBox_input.Text.ToLower(), key_1, key_2);
                                                textBox_output.Text = obj.Encrypt();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ключи должны быть простыми числами!");
                                            }

                                        }
                                        catch
                                        {
                                            MessageBox.Show("Ключи должны быть простыми числами!");
                                        }
                                    }
                                    break;
                                }
                            case 7: //Эль-Гамаль
                                {

                                    break;
                                }
                        }
                        break;
                    }

                //ДЕШИФРОВАНИЕ
                case 1:
                    {
                        switch (comboBox_cipher.SelectedIndex)
                        {
                            case 0: //Цезарь
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите ключ для шифрования!");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            Ceasar obj = new Ceasar(textBox_input.Text.ToLower(), int.Parse(textBox_key.Text));
                                            textBox_output.Text = obj.Decrypt();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Введите корректный ключ!");
                                            throw;
                                        }
                                    }
                                    break;
                                }
                            case 1: //Виженер
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите ключ для шифрования!");
                                    }
                                    else
                                    {
                                        Vigenere obj = new Vigenere(textBox_input.Text.ToLower(), textBox_key.Text.ToLower());
                                        textBox_output.Text = obj.Decrypt();
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Playfair obj = new Playfair(textBox_input.Text.ToLower(), textBox_key.Text.ToLower());
                                    textBox_output.Text = obj.Decrypt();
                                    break;
                                }
                            case 3: //Уитстон
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите первый ключ для шифрования!");
                                    }
                                    else if (textBox_key2.Text == "")
                                    {
                                        MessageBox.Show("Введите второй ключ для шифрования!");
                                    }
                                    else
                                    {
                                        Wheatstone obj = new Wheatstone(textBox_input.Text, textBox_key.Text, textBox_key2.Text);
                                       textBox_output.Text = obj.Decrypt();
                                    }
                                    break;
                                }
                            case 4: //Вернам
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else
                                    {
                                        Vernam obj = new Vernam(textBox_input.Text, textBox_key.Text);
                                        textBox_output.Text = obj.Decrypt();
                                    }
                                    break;
                                }
                            case 5: //Шифрующие таблицы
                                {

                                    break;
                                }
                            case 6: //РСА
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите первое простое число для шифрования!");
                                    }
                                    else if (textBox_key2.Text == "")
                                    {
                                        MessageBox.Show("Введите второе простое число для шифрования!");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            

                                        }
                                        catch
                                        {
                                            MessageBox.Show("Ключи должны быть простыми числами!");
                                        }
                                    }
                                    break;
                                }
                            case 7: //Эль-Гамаль
                                {

                                    break;
                                }
                        }
                        break;
                    }
            }
            
        }

        private void comboBox_cipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_cipher.SelectedIndex)
            {
                case 0:
                    {
                        label_key2.Hide();
                        label_key.Show();
                        textBox_key.Show();
                        textBox_key2.Hide();
                        label_key.Text = "Ключ";
                        label_header.Text = "   ШИФР ЦЕЗАРЯ";

                        break;
                    }
                case 1:
                    {
                        label_key.Show();
                        textBox_key.Show();
                        label_key2.Hide();
                        textBox_key2.Hide();
                        label_key.Text = "Ключ";
                        label_header.Text = "ШИФР ВИЖЕНЕРА";
                        break;
                    }
                case 2:
                    {
                        label_key2.Hide();
                        textBox_key2.Hide();
                        label_key.Show();
                        textBox_key.Show();
                        label_header.Text = "ШИФР ПЛЕЙФЕРА";
                        break;
                    }
                case 3:
                    {
                        label_key.Show();
                        textBox_key.Show();
                        label_key2.Show();
                        textBox_key2.Show();
                        label_key.Text = "Ключ 1";
                        label_key2.Text = "Ключ 2";
                        textBox_key.Width = 130;
                        label_header.Text = "ШИФР УИТСТОНА";
                        break;
                    }
                case 4:
                    {

                        label_key2.Hide();
                        textBox_key2.Hide();
                        label_key.Show();
                        textBox_key.Show();
                        label_header.Text = "ШИФР ВЕРНАМА";
                        break;
                    }
                case 5:
                    {

                        break;
                    }
                case 6:
                    {
                        label_key.Show();
                        label_key2.Show();
                        textBox_key.Show();
                        textBox_key2.Show();
                        label_key.Text = "Ключ 1";
                        label_key2.Text = "Ключ 2";
                        label_header.Text = "      ШИФР RSA";
                        break;
                    }
                case 7:
                    {

                        break;
                    }
            }
        }

        private void comboBox_changeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_changeType.SelectedIndex)
            {
                case 0:
                    {
                        button_Encr.Text = "ЗАШИФРОВАТЬ";
                        break;
                    }
                case 1:
                    {
                        button_Encr.Text = "ДЕШИФРОВАТЬ";
                        break;
                    }
            }
        }
    }
}