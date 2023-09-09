namespace Barsi.Desktop
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
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuarioLbl = new System.Windows.Forms.Label();
            this.senhaLbl = new System.Windows.Forms.Label();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.usuarioTxt.Location = new System.Drawing.Point(105, 33);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(171, 22);
            this.usuarioTxt.TabIndex = 1;
            this.usuarioTxt.Tag = "USUARIO";
            this.usuarioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuarioTxt.TextChanged += new System.EventHandler(this.usuarioTxt_TextChanged);
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(105, 80);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(171, 22);
            this.senhaTxt.TabIndex = 3;
            this.senhaTxt.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.entrarBtn);
            this.panel1.Controls.Add(this.senhaLbl);
            this.panel1.Controls.Add(this.usuarioLbl);
            this.panel1.Controls.Add(this.usuarioTxt);
            this.panel1.Controls.Add(this.senhaTxt);
            this.panel1.Location = new System.Drawing.Point(201, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 199);
            this.panel1.TabIndex = 4;
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.AutoSize = true;
            this.usuarioLbl.Location = new System.Drawing.Point(41, 36);
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(58, 16);
            this.usuarioLbl.TabIndex = 4;
            this.usuarioLbl.Text = "USUÁIO";
            this.usuarioLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // senhaLbl
            // 
            this.senhaLbl.AutoSize = true;
            this.senhaLbl.Location = new System.Drawing.Point(41, 83);
            this.senhaLbl.Name = "senhaLbl";
            this.senhaLbl.Size = new System.Drawing.Size(54, 16);
            this.senhaLbl.TabIndex = 5;
            this.senhaLbl.Text = "SENHA";
            // 
            // entrarBtn
            // 
            this.entrarBtn.BackColor = System.Drawing.Color.Blue;
            this.entrarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.entrarBtn.Location = new System.Drawing.Point(115, 124);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(143, 51);
            this.entrarBtn.TabIndex = 6;
            this.entrarBtn.Text = "ENTRAR";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usuarioLbl;
        private System.Windows.Forms.Label senhaLbl;
        private System.Windows.Forms.Button entrarBtn;
    }
}

