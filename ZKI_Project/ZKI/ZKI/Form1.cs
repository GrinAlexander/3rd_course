﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ZKI.Ciphers;
using System.Numerics;

namespace ZKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ElGamal elGamal = new ElGamal();
        static long b = Convert.ToInt64(ElGamalHelper.GetInt());
        static long p = Convert.ToInt64(ElGamalHelper.GetInt());
        static long g = ElGamalHelper.Calculate_g(p);
        static long x = ElGamalHelper.Calculate_x(p);
        static BigInteger buf = BigInteger.Pow(g, (int)(x));
        static BigInteger y = buf % p;
        static BigInteger buf_A = 0;
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
                                        try
                                        {
                                            Vigenere obj = new Vigenere(textBox_input.Text.ToLower(), textBox_key.Text.ToLower());
                                            textBox_output.Text = obj.Encrypt();
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Введите корректный ключ!");
                                        }
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
                                        try
                                        {
                                            Vernam obj = new Vernam(textBox_input.Text, textBox_key.Text);
                                            textBox_output.Text = obj.Encrypt();
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Введите ключ для шифрования!");
                                        }

                                    }
                                    break;
                                }
                            case 5: //Шифрующие таблицы
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите первое простое число для шифрования!");
                                    }
                                    else
                                    {
                                        string input = textBox_key.Text.ToLower();
                                        for (int i = 0; i < input.Length; i++)
                                        {
                                            if (input[i] < 'а' || input[i] > 'я')
                                            {
                                                MessageBox.Show("Ключ должен состоять только из букв русского алфавита!");
                                                return;
                                            }
                                        }
                                        EncryptionTable obj = new EncryptionTable(textBox_input.Text.ToLower(), textBox_key.Text);
                                        textBox_output.Text = obj.Encrypt();
                                    }
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
                                            if (key_1 < 7 || key_2 < 7)
                                            {
                                                MessageBox.Show("Простые числа должны быть больше 7!");
                                                return;
                                            }
                                            if (RSA.IsTheNumberSimple(key_1) && RSA.IsTheNumberSimple(key_2))
                                            {
                                                RSA obj = new RSA(textBox_input.Text, key_1, key_2);
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
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else
                                    {
                                        ElGamal obj = new ElGamal(textBox_input.Text);
                                        textBox_output.Text = obj.Encrypt(p, g, y);
                                        buf_A = obj.GetBufA();

                                    }
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
                                        try
                                        {
                                            Vigenere obj = new Vigenere(textBox_input.Text.ToLower(), textBox_key.Text.ToLower());
                                            textBox_output.Text = obj.Decrypt();
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Введите корректный ключ!");
                                        }

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
                                        try
                                        {
                                            Vernam obj = new Vernam(textBox_input.Text, textBox_key.Text);
                                            textBox_output.Text = obj.Decrypt();
                                        }
                                        catch (Exception)
                                        {

                                            MessageBox.Show("Введите ключ для шифрования!");
                                        }
                                    }
                                    break;
                                }
                            case 5: //Шифрующие таблицы
                                {
                                    if (textBox_input.Text == "")
                                    {
                                        MessageBox.Show("Введите текст для шифрования!");
                                    }
                                    else if (textBox_key.Text == "")
                                    {
                                        MessageBox.Show("Введите первое простое число для шифрования!");
                                    }
                                    else
                                    {
                                        string input = textBox_key.Text.ToLower();
                                        for (int i = 0; i < input.Length; i++)
                                        {
                                            if (input[i] < 'а' || input[i] > 'я')
                                            {
                                                MessageBox.Show("Ключ должен состоять только из букв русского алфавита!");
                                                return;
                                            }
                                        }
                                        EncryptionTable obj = new EncryptionTable(textBox_input.Text.ToLower(), textBox_key.Text);
                                        textBox_output.Text = obj.Decrypt();
                                    }
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

                                            long key_1 = Convert.ToInt64(textBox_key.Text);
                                            long key_2 = Convert.ToInt64(textBox_key2.Text);
                                            if (key_1 < 7 || key_2 < 7)
                                            {
                                                MessageBox.Show("Простые числа должны быть больше 7!");
                                                return;
                                            }
                                            for (int i = 0; i < textBox_input.Text.Length; i++)
                                            {
                                                if (!char.IsDigit(textBox_input.Text[i]) && textBox_input.Text[i] != ' ')
                                                {
                                                    MessageBox.Show("Текст для дешифрования должен состоять только из цифр!");
                                                    return;
                                                }
                                            }
                                            if (RSA.IsTheNumberSimple(key_1) && RSA.IsTheNumberSimple(key_2))
                                            {
                                                List<string> list = new List<string>();
                                                string item = null;
                                                for (int i = 0; i < textBox_input.Text.Length; i++)
                                                {
                                                    if (char.IsDigit(textBox_input.Text[i]))
                                                    {
                                                        item += textBox_input.Text[i];
                                                    }
                                                    else
                                                    {
                                                        list.Add(item);
                                                        item = null;
                                                    }
                                                }
                                                if (int.TryParse(item, out int _x))
                                                {
                                                    list.Add(item);
                                                }
                                                RSA obj = new RSA(textBox_input.Text, key_1, key_2);
                                                textBox_output.Text = obj.Decrypt(list);
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
                                    List<string> list = new List<string>();
                                    string item = null;
                                    for (int i = 0; i < textBox_input.Text.Length; i++)
                                    {
                                        if (char.IsDigit(textBox_input.Text[i]))
                                        {
                                            item += textBox_input.Text[i];
                                        }
                                        else
                                        {
                                            list.Add(item);
                                            item = null;
                                        }
                                    }
                                    if (int.TryParse(item, out int _x))
                                    {
                                        list.Add(item);
                                    }
                                    textBox_output.Text = elGamal.Decrypt(list, x, p, buf_A);
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
                        label_key2.Hide();
                        textBox_key2.Hide();
                        label_key.Show();
                        textBox_key.Show();
                        label_key.Text = "Ключ";
                        label_header.Text = "   ШИФРУЮЩИЕ\n ТАБЛИЦЫ";
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
                        
                        label_key2.Hide();
                        textBox_key2.Hide();
                        label_key.Hide();
                        textBox_key.Hide();
                        label_header.Text = "ШИФР ЭЛЬ-ГАМАЛЯ";
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

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = null;
            text = $"Выбранный шифр: {comboBox_cipher.Text} \nВид преобразования: {comboBox_changeType.Text} \nВводимый текст: {textBox_input.Text} \nРезультат: {textBox_output.Text}";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = "D:/",
                FilterIndex = 0,
                Filter = "TXT File |*.txt"
            };
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile());
                sw.WriteLine(text);
                sw.Close();
            }
            else
            {
                return;
            }
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void РазработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана в качестве курсового проекта.\nГолубев Иван, группа Т-716, 3-й курс.");
        }
    }
}