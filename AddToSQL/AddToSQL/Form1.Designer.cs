namespace AddToSQL
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
            this.tb_loginSignUp = new System.Windows.Forms.TextBox();
            this.tb_passwordSignUp = new System.Windows.Forms.TextBox();
            this.button_addNote = new System.Windows.Forms.Button();
            this.label_loginSignUp = new System.Windows.Forms.Label();
            this.label_passwordSignUp = new System.Windows.Forms.Label();
            this.button_showTable = new System.Windows.Forms.Button();
            this.dataGrid_table = new System.Windows.Forms.DataGridView();
            this.tb_loginSignIn = new System.Windows.Forms.TextBox();
            this.label_loginSignIn = new System.Windows.Forms.Label();
            this.tb_passwordSignIn = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label_passwordSignIn = new System.Windows.Forms.Label();
            this.label_SignUp_Notification = new System.Windows.Forms.Label();
            this.label_SignIn_Notification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_loginSignUp
            // 
            this.tb_loginSignUp.Location = new System.Drawing.Point(16, 21);
            this.tb_loginSignUp.MaxLength = 10;
            this.tb_loginSignUp.Name = "tb_loginSignUp";
            this.tb_loginSignUp.Size = new System.Drawing.Size(100, 20);
            this.tb_loginSignUp.TabIndex = 0;
            // 
            // tb_passwordSignUp
            // 
            this.tb_passwordSignUp.Location = new System.Drawing.Point(16, 47);
            this.tb_passwordSignUp.MaxLength = 10;
            this.tb_passwordSignUp.Name = "tb_passwordSignUp";
            this.tb_passwordSignUp.Size = new System.Drawing.Size(100, 20);
            this.tb_passwordSignUp.TabIndex = 1;
            this.tb_passwordSignUp.UseSystemPasswordChar = true;
            // 
            // button_addNote
            // 
            this.button_addNote.Location = new System.Drawing.Point(16, 73);
            this.button_addNote.Name = "button_addNote";
            this.button_addNote.Size = new System.Drawing.Size(100, 23);
            this.button_addNote.TabIndex = 4;
            this.button_addNote.Text = "Sign up";
            this.button_addNote.UseVisualStyleBackColor = true;
            this.button_addNote.Click += new System.EventHandler(this.button_addNote_Click);
            // 
            // label_loginSignUp
            // 
            this.label_loginSignUp.AutoSize = true;
            this.label_loginSignUp.Location = new System.Drawing.Point(122, 24);
            this.label_loginSignUp.Name = "label_loginSignUp";
            this.label_loginSignUp.Size = new System.Drawing.Size(33, 13);
            this.label_loginSignUp.TabIndex = 5;
            this.label_loginSignUp.Text = "Login";
            // 
            // label_passwordSignUp
            // 
            this.label_passwordSignUp.AutoSize = true;
            this.label_passwordSignUp.Location = new System.Drawing.Point(122, 50);
            this.label_passwordSignUp.Name = "label_passwordSignUp";
            this.label_passwordSignUp.Size = new System.Drawing.Size(53, 13);
            this.label_passwordSignUp.TabIndex = 6;
            this.label_passwordSignUp.Text = "Password";
            // 
            // button_showTable
            // 
            this.button_showTable.Location = new System.Drawing.Point(16, 155);
            this.button_showTable.Name = "button_showTable";
            this.button_showTable.Size = new System.Drawing.Size(98, 23);
            this.button_showTable.TabIndex = 10;
            this.button_showTable.Text = "Show All Notes";
            this.button_showTable.UseVisualStyleBackColor = true;
            this.button_showTable.Click += new System.EventHandler(this.button_showTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGrid_table.AllowUserToAddRows = false;
            this.dataGrid_table.AllowUserToDeleteRows = false;
            this.dataGrid_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_table.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGrid_table.Location = new System.Drawing.Point(16, 184);
            this.dataGrid_table.Name = "dataGridView1";
            this.dataGrid_table.ReadOnly = true;
            this.dataGrid_table.Size = new System.Drawing.Size(447, 253);
            this.dataGrid_table.TabIndex = 11;
            // 
            // tb_loginSignIn
            // 
            this.tb_loginSignIn.Location = new System.Drawing.Point(220, 21);
            this.tb_loginSignIn.MaxLength = 10;
            this.tb_loginSignIn.Name = "tb_loginSignIn";
            this.tb_loginSignIn.Size = new System.Drawing.Size(100, 20);
            this.tb_loginSignIn.TabIndex = 12;
            // 
            // label_loginSignIn
            // 
            this.label_loginSignIn.AutoSize = true;
            this.label_loginSignIn.Location = new System.Drawing.Point(326, 24);
            this.label_loginSignIn.Name = "label_loginSignIn";
            this.label_loginSignIn.Size = new System.Drawing.Size(33, 13);
            this.label_loginSignIn.TabIndex = 13;
            this.label_loginSignIn.Text = "Login";
            // 
            // tb_passwordSignIn
            // 
            this.tb_passwordSignIn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_passwordSignIn.Location = new System.Drawing.Point(220, 47);
            this.tb_passwordSignIn.MaxLength = 10;
            this.tb_passwordSignIn.Name = "tb_passwordSignIn";
            this.tb_passwordSignIn.Size = new System.Drawing.Size(100, 20);
            this.tb_passwordSignIn.TabIndex = 14;
            this.tb_passwordSignIn.UseSystemPasswordChar = true;
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(220, 73);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(100, 23);
            this.button_check.TabIndex = 15;
            this.button_check.Text = "Sign in";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label_passwordSignIn
            // 
            this.label_passwordSignIn.AutoSize = true;
            this.label_passwordSignIn.Location = new System.Drawing.Point(326, 50);
            this.label_passwordSignIn.Name = "label_passwordSignIn";
            this.label_passwordSignIn.Size = new System.Drawing.Size(53, 13);
            this.label_passwordSignIn.TabIndex = 16;
            this.label_passwordSignIn.Text = "Password";
            // 
            // label_SignUp_Notification
            // 
            this.label_SignUp_Notification.AutoSize = true;
            this.label_SignUp_Notification.Location = new System.Drawing.Point(16, 103);
            this.label_SignUp_Notification.Name = "label_SignUp_Notification";
            this.label_SignUp_Notification.Size = new System.Drawing.Size(0, 13);
            this.label_SignUp_Notification.TabIndex = 17;
            // 
            // label_SignIn_Notification
            // 
            this.label_SignIn_Notification.AutoSize = true;
            this.label_SignIn_Notification.Location = new System.Drawing.Point(220, 103);
            this.label_SignIn_Notification.Name = "label_SignIn_Notification";
            this.label_SignIn_Notification.Size = new System.Drawing.Size(0, 13);
            this.label_SignIn_Notification.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 487);
            this.Controls.Add(this.label_SignIn_Notification);
            this.Controls.Add(this.label_SignUp_Notification);
            this.Controls.Add(this.label_passwordSignIn);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.tb_passwordSignIn);
            this.Controls.Add(this.label_loginSignIn);
            this.Controls.Add(this.tb_loginSignIn);
            this.Controls.Add(this.dataGrid_table);
            this.Controls.Add(this.button_showTable);
            this.Controls.Add(this.label_passwordSignUp);
            this.Controls.Add(this.label_loginSignUp);
            this.Controls.Add(this.button_addNote);
            this.Controls.Add(this.tb_passwordSignUp);
            this.Controls.Add(this.tb_loginSignUp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_loginSignUp;
        private System.Windows.Forms.TextBox tb_passwordSignUp;
        private System.Windows.Forms.Button button_addNote;
        private System.Windows.Forms.Label label_loginSignUp;
        private System.Windows.Forms.Label label_passwordSignUp;
        private System.Windows.Forms.Button button_showTable;
        private System.Windows.Forms.DataGridView dataGrid_table;
        private System.Windows.Forms.TextBox tb_loginSignIn;
        private System.Windows.Forms.Label label_loginSignIn;
        private System.Windows.Forms.TextBox tb_passwordSignIn;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_passwordSignIn;
        private System.Windows.Forms.Label label_SignUp_Notification;
        private System.Windows.Forms.Label label_SignIn_Notification;
    }
}

