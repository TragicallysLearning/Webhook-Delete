
namespace Webhook_Tool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneResizeForm1 = new Siticone.UI.WinForms.SiticoneResizeForm(this.components);
            this.logInThemeContainer1 = new LoginTheme.LogInThemeContainer();
            this.hook = new LogIn_Theme_Dll_By_xVenoxi.LogInNormalTextBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.hookDel = new LoginTheme.LogInButton();
            this.logInLabel1 = new LoginTheme.LogInLabel();
            this.logInThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInThemeContainer1
            // 
            this.logInThemeContainer1.AllowClose = true;
            this.logInThemeContainer1.AllowMaximize = true;
            this.logInThemeContainer1.AllowMinimize = true;
            this.logInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.logInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.logInThemeContainer1.CloseChoice = LoginTheme.LogInThemeContainer.@__CloseChoice.Form;
            this.logInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.logInThemeContainer1.Controls.Add(this.logInLabel1);
            this.logInThemeContainer1.Controls.Add(this.hook);
            this.logInThemeContainer1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.logInThemeContainer1.Controls.Add(this.hookDel);
            this.logInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInThemeContainer1.FontSize = 12;
            this.logInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logInThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.logInThemeContainer1.Movable = true;
            this.logInThemeContainer1.Name = "logInThemeContainer1";
            this.logInThemeContainer1.ShowIcon = true;
            this.logInThemeContainer1.Sizable = true;
            this.logInThemeContainer1.Size = new System.Drawing.Size(800, 450);
            this.logInThemeContainer1.SmartBounds = true;
            this.logInThemeContainer1.TabIndex = 0;
            // 
            // hook
            // 
            this.hook.BackColor = System.Drawing.Color.Transparent;
            this.hook.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.hook.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hook.Location = new System.Drawing.Point(79, 137);
            this.hook.MaxLength = 32767;
            this.hook.Multiline = false;
            this.hook.Name = "hook";
            this.hook.ReadOnly = false;
            this.hook.Size = new System.Drawing.Size(207, 47);
            this.hook.Style = LogIn_Theme_Dll_By_xVenoxi.LogInNormalTextBox.Styles.Rounded;
            this.hook.TabIndex = 7;
            this.hook.Text = "Webhook URL";
            this.hook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hook.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hook.UseSystemPasswordChar = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::Webhook_Tool.Properties.Resources.discord;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(443, 106);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(279, 238);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 6;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // hookDel
            // 
            this.hookDel.BackColor = System.Drawing.Color.Transparent;
            this.hookDel.BaseColour = System.Drawing.Color.Black;
            this.hookDel.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.hookDel.FontColour = System.Drawing.Color.Red;
            this.hookDel.HoverColour = System.Drawing.Color.Maroon;
            this.hookDel.Location = new System.Drawing.Point(79, 245);
            this.hookDel.Name = "hookDel";
            this.hookDel.PressedColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.hookDel.ProgressColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.hookDel.Size = new System.Drawing.Size(207, 73);
            this.hookDel.TabIndex = 5;
            this.hookDel.Text = "Delete Webhook";
            // 
            // logInLabel1
            // 
            this.logInLabel1.AutoSize = true;
            this.logInLabel1.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel1.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logInLabel1.Location = new System.Drawing.Point(533, 377);
            this.logInLabel1.Name = "logInLabel1";
            this.logInLabel1.Size = new System.Drawing.Size(120, 32);
            this.logInLabel1.TabIndex = 8;
            this.logInLabel1.Text = "@surtains";
            this.logInLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.logInThemeContainer1.ResumeLayout(false);
            this.logInThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Siticone.UI.WinForms.SiticoneResizeForm siticoneResizeForm1;
        private LoginTheme.LogInThemeContainer logInThemeContainer1;
        private LogIn_Theme_Dll_By_xVenoxi.LogInNormalTextBox hook;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private LoginTheme.LogInButton hookDel;
        private LoginTheme.LogInLabel logInLabel1;
    }
}

