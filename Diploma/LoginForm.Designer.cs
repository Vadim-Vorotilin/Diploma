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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
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
            resources.ApplyResources(this.tableLayoutPanel_Main, "tableLayoutPanel_Main");
            this.tableLayoutPanel_Main.Controls.Add(this.flowLayoutPanel_Buttons, 0, 5);
            this.tableLayoutPanel_Main.Controls.Add(this.label_Login, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.textBox_Login, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.label_Password, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.maskedTextBox_Password, 0, 3);
            this.tableLayoutPanel_Main.Controls.Add(this.checkBox_NewUser, 0, 4);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            // 
            // flowLayoutPanel_Buttons
            // 
            resources.ApplyResources(this.flowLayoutPanel_Buttons, "flowLayoutPanel_Buttons");
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel_Buttons.Controls.Add(this.button_Ok);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Ok
            // 
            resources.ApplyResources(this.button_Ok, "button_Ok");
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label_Login
            // 
            resources.ApplyResources(this.label_Login, "label_Login");
            this.label_Login.Name = "label_Login";
            // 
            // textBox_Login
            // 
            resources.ApplyResources(this.textBox_Login, "textBox_Login");
            this.textBox_Login.Name = "textBox_Login";
            // 
            // label_Password
            // 
            resources.ApplyResources(this.label_Password, "label_Password");
            this.label_Password.Name = "label_Password";
            // 
            // maskedTextBox_Password
            // 
            resources.ApplyResources(this.maskedTextBox_Password, "maskedTextBox_Password");
            this.maskedTextBox_Password.Name = "maskedTextBox_Password";
            this.maskedTextBox_Password.PasswordChar = '*';
            // 
            // checkBox_NewUser
            // 
            resources.ApplyResources(this.checkBox_NewUser, "checkBox_NewUser");
            this.checkBox_NewUser.Name = "checkBox_NewUser";
            this.checkBox_NewUser.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "LoginForm";
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