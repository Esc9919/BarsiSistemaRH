
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
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            ponto_btn = new Button();
            label1 = new Label();
            txtsenha = new TextBox();
            txtlogin = new TextBox();
            cabecalho1 = new Panel();
            txttitle = new Label();
            panel2.SuspendLayout();
            cabecalho1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ponto_btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtsenha);
            panel2.Controls.Add(txtlogin);
            panel2.Location = new Point(347, 211);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 304);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 26;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 25;
            label2.Text = "Login";
            // 
            // ponto_btn
            // 
            ponto_btn.BackColor = Color.FromArgb(0, 121, 255);
            ponto_btn.BackgroundImageLayout = ImageLayout.None;
            ponto_btn.FlatStyle = FlatStyle.Popup;
            ponto_btn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ponto_btn.ForeColor = Color.White;
            ponto_btn.Location = new Point(92, 226);
            ponto_btn.Margin = new Padding(4, 5, 4, 5);
            ponto_btn.Name = "ponto_btn";
            ponto_btn.Size = new Size(192, 35);
            ponto_btn.TabIndex = 24;
            ponto_btn.Text = "Entrar";
            ponto_btn.UseVisualStyleBackColor = false;
            ponto_btn.Click += ponto_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 5;
            label1.Text = "Bem-Vindo a Barsi!";
            // 
            // txtsenha
            // 
            txtsenha.ForeColor = SystemColors.WindowFrame;
            txtsenha.Location = new Point(35, 160);
            txtsenha.Margin = new Padding(4, 5, 4, 5);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(303, 27);
            txtsenha.TabIndex = 1;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // txtlogin
            // 
            txtlogin.ForeColor = SystemColors.WindowFrame;
            txtlogin.Location = new Point(35, 99);
            txtlogin.Margin = new Padding(4, 5, 4, 5);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(303, 27);
            txtlogin.TabIndex = 0;
            txtlogin.TextChanged += txtlogin_TextChanged;
            // 
            // cabecalho1
            // 
            cabecalho1.BackColor = Color.FromArgb(53, 58, 64);
            cabecalho1.Controls.Add(txttitle);
            cabecalho1.Location = new Point(-3, 0);
            cabecalho1.Margin = new Padding(4, 5, 4, 5);
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1080, 125);
            cabecalho1.TabIndex = 6;
            // 
            // txttitle
            // 
            txttitle.AutoSize = true;
            txttitle.BackColor = Color.Transparent;
            txttitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txttitle.ForeColor = Color.White;
            txttitle.Location = new Point(479, 39);
            txttitle.Margin = new Padding(4, 0, 4, 0);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(102, 40);
            txttitle.TabIndex = 7;
            txttitle.Text = "Barsi";
            // 
            // pg_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 121, 255);
            ClientSize = new Size(1073, 692);
            Controls.Add(cabecalho1);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "pg_login";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            cabecalho1.ResumeLayout(false);
            cabecalho1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txtlogin;
        private Label label1;
        private TextBox txtsenha;
        private Panel cabecalho1;
        private Label label3;
        private Label label2;
        private Button ponto_btn;
        private Label txttitle;
    }
}

