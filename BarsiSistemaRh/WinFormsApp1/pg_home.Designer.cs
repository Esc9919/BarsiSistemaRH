
namespace Login
{
    partial class pg_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pg_home));
            cabecalho1 = new Panel();
            btnSair = new Button();
            txttitle = new Label();
            menulateral1 = new Panel();
            histpontos_btn = new LinkLabel();
            folhapgt_btn = new LinkLabel();
            agendaferias_btn = new LinkLabel();
            txtmenu = new Label();
            label8 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ponto_btn = new Button();
            textIdFuncionario = new TextBox();
            label9 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            cabecalho1.SuspendLayout();
            menulateral1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cabecalho1
            // 
            cabecalho1.BackColor = Color.FromArgb(53, 58, 64);
            cabecalho1.Controls.Add(btnSair);
            cabecalho1.Controls.Add(txttitle);
            cabecalho1.Location = new Point(-7, 0);
            cabecalho1.Margin = new Padding(5);
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1080, 125);
            cabecalho1.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.AutoEllipsis = true;
            btnSair.ForeColor = Color.Black;
            btnSair.Location = new Point(976, 37);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(55, 29);
            btnSair.TabIndex = 1;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txttitle
            // 
            txttitle.AutoSize = true;
            txttitle.BackColor = Color.Transparent;
            txttitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txttitle.ForeColor = Color.White;
            txttitle.Location = new Point(527, 37);
            txttitle.Margin = new Padding(5, 0, 5, 0);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(113, 40);
            txttitle.TabIndex = 0;
            txttitle.Text = "Home";
            // 
            // menulateral1
            // 
            menulateral1.BackColor = Color.FromArgb(0, 122, 255);
            menulateral1.Controls.Add(histpontos_btn);
            menulateral1.Controls.Add(folhapgt_btn);
            menulateral1.Controls.Add(agendaferias_btn);
            menulateral1.Controls.Add(txtmenu);
            menulateral1.Controls.Add(label8);
            menulateral1.Location = new Point(0, 125);
            menulateral1.Margin = new Padding(5);
            menulateral1.Name = "menulateral1";
            menulateral1.Size = new Size(193, 569);
            menulateral1.TabIndex = 2;
            // 
            // histpontos_btn
            // 
            histpontos_btn.AutoSize = true;
            histpontos_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            histpontos_btn.ImageAlign = ContentAlignment.TopCenter;
            histpontos_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            histpontos_btn.LinkColor = Color.White;
            histpontos_btn.Location = new Point(9, 195);
            histpontos_btn.Margin = new Padding(5, 0, 5, 0);
            histpontos_btn.Name = "histpontos_btn";
            histpontos_btn.RightToLeft = RightToLeft.No;
            histpontos_btn.Size = new Size(151, 19);
            histpontos_btn.TabIndex = 11;
            histpontos_btn.TabStop = true;
            histpontos_btn.Text = "Historico de Pontos";
            histpontos_btn.LinkClicked += histpontos_btn_LinkClicked_1;
            // 
            // folhapgt_btn
            // 
            folhapgt_btn.AutoSize = true;
            folhapgt_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            folhapgt_btn.ImageAlign = ContentAlignment.TopCenter;
            folhapgt_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            folhapgt_btn.LinkColor = Color.White;
            folhapgt_btn.Location = new Point(9, 148);
            folhapgt_btn.Margin = new Padding(5, 0, 5, 0);
            folhapgt_btn.Name = "folhapgt_btn";
            folhapgt_btn.RightToLeft = RightToLeft.No;
            folhapgt_btn.Size = new Size(159, 19);
            folhapgt_btn.TabIndex = 10;
            folhapgt_btn.TabStop = true;
            folhapgt_btn.Text = "Folha de Pagamento";
            folhapgt_btn.LinkClicked += folhapgt_btn_LinkClicked_1;
            // 
            // agendaferias_btn
            // 
            agendaferias_btn.AutoSize = true;
            agendaferias_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            agendaferias_btn.ImageAlign = ContentAlignment.TopCenter;
            agendaferias_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            agendaferias_btn.LinkColor = Color.White;
            agendaferias_btn.Location = new Point(9, 107);
            agendaferias_btn.Margin = new Padding(5, 0, 5, 0);
            agendaferias_btn.Name = "agendaferias_btn";
            agendaferias_btn.RightToLeft = RightToLeft.No;
            agendaferias_btn.Size = new Size(122, 19);
            agendaferias_btn.TabIndex = 9;
            agendaferias_btn.TabStop = true;
            agendaferias_btn.Text = "Agendar Ferias";
            agendaferias_btn.LinkClicked += agendaferias_btn_LinkClicked_1;
            // 
            // txtmenu
            // 
            txtmenu.AutoSize = true;
            txtmenu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtmenu.ForeColor = Color.White;
            txtmenu.Location = new Point(13, 37);
            txtmenu.Margin = new Padding(5, 0, 5, 0);
            txtmenu.Name = "txtmenu";
            txtmenu.Size = new Size(68, 24);
            txtmenu.TabIndex = 0;
            txtmenu.Text = "MENU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(11, 51);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(142, 24);
            label8.TabIndex = 1;
            label8.Text = "____________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(539, 157);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 29);
            label1.TabIndex = 3;
            label1.Text = "Bem Vindo!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ponto_btn);
            panel1.Location = new Point(480, 497);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 52);
            panel1.TabIndex = 7;
            // 
            // ponto_btn
            // 
            ponto_btn.BackColor = Color.FromArgb(0, 121, 255);
            ponto_btn.BackgroundImageLayout = ImageLayout.None;
            ponto_btn.FlatStyle = FlatStyle.Popup;
            ponto_btn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ponto_btn.ForeColor = Color.White;
            ponto_btn.Location = new Point(27, 5);
            ponto_btn.Margin = new Padding(5);
            ponto_btn.Name = "ponto_btn";
            ponto_btn.Size = new Size(192, 35);
            ponto_btn.TabIndex = 1;
            ponto_btn.Text = "BATER PONTO";
            ponto_btn.UseVisualStyleBackColor = false;
            ponto_btn.Click += ponto_btn_Click_1;
            // 
            // textIdFuncionario
            // 
            textIdFuncionario.Enabled = false;
            textIdFuncionario.Location = new Point(567, 448);
            textIdFuncionario.Name = "textIdFuncionario";
            textIdFuncionario.Size = new Size(125, 27);
            textIdFuncionario.TabIndex = 8;
            textIdFuncionario.TextChanged += textIdFuncionario_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(400, 455);
            label9.Name = "label9";
            label9.Size = new Size(161, 20);
            label9.TabIndex = 9;
            label9.Text = "ID DO COLABORADOR";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(232, 616);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(114, 27);
            txtLogin.TabIndex = 10;
            txtLogin.Visible = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(366, 616);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(114, 27);
            txtSenha.TabIndex = 11;
            txtSenha.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 255);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(439, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 125);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 45);
            label2.Name = "label2";
            label2.Size = new Size(171, 31);
            label2.TabIndex = 0;
            label2.Text = "Bom Trabalho!";
            // 
            // pg_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1073, 692);
            Controls.Add(panel2);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label9);
            Controls.Add(textIdFuncionario);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menulateral1);
            Controls.Add(cabecalho1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "pg_home";
            Text = "pg_incial";
            cabecalho1.ResumeLayout(false);
            cabecalho1.PerformLayout();
            menulateral1.ResumeLayout(false);
            menulateral1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel cabecalho1;
        private Panel menulateral1;
        private Label txttitle;
        private Label label1;
        private Panel panel1;
        private Button ponto_btn;
        private Label txtmenu;
        private Label label8;
        private LinkLabel agendaferias_btn;
        private LinkLabel folhapgt_btn;
        private LinkLabel histpontos_btn;
        private TextBox textIdFuncionario;
        private Label label9;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnSair;
        private Panel panel2;
        private Label label2;
    }
}