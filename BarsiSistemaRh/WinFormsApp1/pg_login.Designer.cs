
namespace Login
{
    partial class pg_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ponto_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.cabecalho1 = new System.Windows.Forms.Panel();
            this.txttitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.cabecalho1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ponto_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtsenha);
            this.panel2.Controls.Add(this.txtlogin);
            this.panel2.Location = new System.Drawing.Point(347, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 244);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Login";
            // 
            // ponto_btn
            // 
            this.ponto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.ponto_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ponto_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ponto_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto_btn.ForeColor = System.Drawing.Color.White;
            this.ponto_btn.Location = new System.Drawing.Point(92, 181);
            this.ponto_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ponto_btn.Name = "ponto_btn";
            this.ponto_btn.Size = new System.Drawing.Size(192, 28);
            this.ponto_btn.TabIndex = 24;
            this.ponto_btn.Text = "Entrar";
            this.ponto_btn.UseVisualStyleBackColor = false;
            this.ponto_btn.Click += new System.EventHandler(this.ponto_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bem-Vindo a Barsi!";
            // 
            // txtsenha
            // 
            this.txtsenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtsenha.Location = new System.Drawing.Point(35, 128);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(303, 22);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.Text = "Digite sua senha";
            // 
            // txtlogin
            // 
            this.txtlogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtlogin.Location = new System.Drawing.Point(35, 79);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(303, 22);
            this.txtlogin.TabIndex = 0;
            this.txtlogin.Text = "seuemail@emailcom";
            this.txtlogin.TextChanged += new System.EventHandler(this.txtlogin_TextChanged);
            // 
            // cabecalho1
            // 
            this.cabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.cabecalho1.Controls.Add(this.txttitle);
            this.cabecalho1.Location = new System.Drawing.Point(-3, 0);
            this.cabecalho1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(1080, 100);
            this.cabecalho1.TabIndex = 6;
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.BackColor = System.Drawing.Color.Transparent;
            this.txttitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.Color.White;
            this.txttitle.Location = new System.Drawing.Point(479, 31);
            this.txttitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(102, 40);
            this.txttitle.TabIndex = 7;
            this.txttitle.Text = "Barsi";
            // 
            // pg_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1073, 554);
            this.Controls.Add(this.cabecalho1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "pg_login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cabecalho1.ResumeLayout(false);
            this.cabecalho1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Panel cabecalho1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ponto_btn;
        private System.Windows.Forms.Label txttitle;
    }
}

