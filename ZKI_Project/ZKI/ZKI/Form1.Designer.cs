namespace ZKI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.button_Encr = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.comboBox_cipher = new System.Windows.Forms.ComboBox();
            this.textBox_key2 = new System.Windows.Forms.TextBox();
            this.label_key2 = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.comboBox_changeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_input.Location = new System.Drawing.Point(12, 157);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(200, 200);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_output
            // 
            this.textBox_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_output.Location = new System.Drawing.Point(346, 157);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(200, 200);
            this.textBox_output.TabIndex = 1;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(12, 102);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(42, 13);
            this.label_key.TabIndex = 2;
            this.label_key.Text = "Ключ 1";
            // 
            // button_Encr
            // 
            this.button_Encr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Encr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Encr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Encr.FlatAppearance.BorderSize = 0;
            this.button_Encr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Encr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Encr.Location = new System.Drawing.Point(224, 242);
            this.button_Encr.Name = "button_Encr";
            this.button_Encr.Size = new System.Drawing.Size(110, 30);
            this.button_Encr.TabIndex = 4;
            this.button_Encr.Text = "ЗАШИФРОВАТЬ";
            this.button_Encr.UseVisualStyleBackColor = false;
            this.button_Encr.Click += new System.EventHandler(this.button_Encr_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(185, 61);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(0, 26);
            this.label_header.TabIndex = 8;
            this.label_header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox_cipher
            // 
            this.comboBox_cipher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_cipher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_cipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cipher.FormattingEnabled = true;
            this.comboBox_cipher.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Шифр Виженера",
            "Шифр Плейфера",
            "Шифр Уитстона",
            "Шифр Вернама",
            "Шифрующие таблицы",
            "Шифр RSA",
            "Шифр Эль-Гамаля"});
            this.comboBox_cipher.Location = new System.Drawing.Point(12, 66);
            this.comboBox_cipher.Name = "comboBox_cipher";
            this.comboBox_cipher.Size = new System.Drawing.Size(130, 21);
            this.comboBox_cipher.TabIndex = 9;
            this.comboBox_cipher.SelectedIndexChanged += new System.EventHandler(this.comboBox_cipher_SelectedIndexChanged);
            // 
            // textBox_key2
            // 
            this.textBox_key2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_key2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_key2.Location = new System.Drawing.Point(413, 118);
            this.textBox_key2.Name = "textBox_key2";
            this.textBox_key2.Size = new System.Drawing.Size(133, 20);
            this.textBox_key2.TabIndex = 10;
            // 
            // label_key2
            // 
            this.label_key2.AutoSize = true;
            this.label_key2.Location = new System.Drawing.Point(410, 102);
            this.label_key2.Name = "label_key2";
            this.label_key2.Size = new System.Drawing.Size(42, 13);
            this.label_key2.TabIndex = 11;
            this.label_key2.Text = "Ключ 2";
            // 
            // textBox_key
            // 
            this.textBox_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_key.Location = new System.Drawing.Point(12, 118);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(130, 20);
            this.textBox_key.TabIndex = 12;
            // 
            // comboBox_changeType
            // 
            this.comboBox_changeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_changeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_changeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_changeType.FormattingEnabled = true;
            this.comboBox_changeType.Items.AddRange(new object[] {
            "Шифровать",
            "Дешифровать"});
            this.comboBox_changeType.Location = new System.Drawing.Point(413, 66);
            this.comboBox_changeType.Name = "comboBox_changeType";
            this.comboBox_changeType.Size = new System.Drawing.Size(130, 21);
            this.comboBox_changeType.TabIndex = 13;
            this.comboBox_changeType.SelectedIndexChanged += new System.EventHandler(this.comboBox_changeType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Метод шифрования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Вид преобразования";
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(556, 24);
            this.menuStrip_main.TabIndex = 16;
            this.menuStrip_main.Text = "menuStrip_Main";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.справкаToolStripMenuItem.Text = "Справка                  F1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_changeType);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label_key2);
            this.Controls.Add(this.textBox_key2);
            this.Controls.Add(this.comboBox_cipher);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.button_Encr);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip_main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   LOCKY";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Button button_Encr;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.ComboBox comboBox_cipher;
        private System.Windows.Forms.TextBox textBox_key2;
        private System.Windows.Forms.Label label_key2;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.ComboBox comboBox_changeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

