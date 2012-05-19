namespace Diploma
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.maskedTextBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_NewUser = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.flowLayoutPanel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.flowLayoutPanel_Buttons, 0, 5);
            this.tableLayoutPanel_Main.Controls.Add(this.label_Login, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.textBox_Login, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.label_Password, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.maskedTextBox_Password, 0, 3);
            this.tableLayoutPanel_Main.Controls.Add(this.checkBox_NewUser, 0, 4);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 6;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(228, 155);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Ok);
            this.flowLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Buttons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(3, 123);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(222, 29);
            this.flowLayoutPanel_Buttons.TabIndex = 0;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(144, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(63, 3);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(3, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label_Login.Size = new System.Drawing.Size(33, 20);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Login";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(3, 27);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(213, 20);
            this.textBox_Login.TabIndex = 2;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(3, 48);
            this.label_Password.Name = "label_Password";
            this.label_Password.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label_Password.Size = new System.Drawing.Size(53, 20);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // maskedTextBox_Password
            // 
            this.maskedTextBox_Password.Location = new System.Drawing.Point(3, 75);
            this.maskedTextBox_Password.Name = "maskedTextBox_Password";
            this.maskedTextBox_Password.PasswordChar = '*';
            this.maskedTextBox_Password.Size = new System.Drawing.Size(213, 20);
            this.maskedTextBox_Password.TabIndex = 4;
            // 
            // checkBox_NewUser
            // 
            this.checkBox_NewUser.AutoSize = true;
            this.checkBox_NewUser.Location = new System.Drawing.Point(3, 99);
            this.checkBox_NewUser.Name = "checkBox_NewUser";
            this.checkBox_NewUser.Size = new System.Drawing.Size(71, 17);
            this.checkBox_NewUser.TabIndex = 5;
            this.checkBox_NewUser.Text = "New user";
            this.checkBox_NewUser.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 155);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.flowLayoutPanel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Buttons;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Password;
        private System.Windows.Forms.CheckBox checkBox_NewUser;
    }
}