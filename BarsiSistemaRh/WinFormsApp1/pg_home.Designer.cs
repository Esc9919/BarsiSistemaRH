
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
            txttitle = new Label();
            menulateral1 = new Panel();
            linkLabel1 = new LinkLabel();
            demitir_func_btn = new LinkLabel();
            cadastrar_func_btn = new LinkLabel();
            dadoscolob_btn = new LinkLabel();
            holerite_btn = new LinkLabel();
            histpontos_btn = new LinkLabel();
            folhapgt_btn = new LinkLabel();
            agendaferias_btn = new LinkLabel();
            txtmenu = new Label();
            label8 = new Label();
            label1 = new Label();
            fundo_ultreg = new Panel();
            label5 = new Label();
            label2 = new Label();
            fundo_hextras = new Panel();
            label6 = new Label();
            label3 = new Label();
            fundo_dia = new Panel();
            labelDia = new Label();
            labelData = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ponto_btn = new Button();
            textIdFuncionario = new TextBox();
            label9 = new Label();
            cabecalho1.SuspendLayout();
            menulateral1.SuspendLayout();
            fundo_ultreg.SuspendLayout();
            fundo_hextras.SuspendLayout();
            fundo_dia.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cabecalho1
            // 
            cabecalho1.BackColor = Color.FromArgb(53, 58, 64);
            cabecalho1.Controls.Add(txttitle);
            cabecalho1.Location = new Point(-7, 0);
            cabecalho1.Margin = new Padding(4, 5, 4, 5);
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1080, 125);
            cabecalho1.TabIndex = 1;
            cabecalho1.Paint += panel1_Paint;
            // 
            // txttitle
            // 
            txttitle.AutoSize = true;
            txttitle.BackColor = Color.Transparent;
            txttitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txttitle.ForeColor = Color.White;
            txttitle.Location = new Point(527, 37);
            txttitle.Margin = new Padding(4, 0, 4, 0);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(113, 40);
            txttitle.TabIndex = 0;
            txttitle.Text = "Home";
            txttitle.Click += txttitle_Click;
            // 
            // menulateral1
            // 
            menulateral1.BackColor = Color.FromArgb(0, 122, 255);
            menulateral1.Controls.Add(linkLabel1);
            menulateral1.Controls.Add(demitir_func_btn);
            menulateral1.Controls.Add(cadastrar_func_btn);
            menulateral1.Controls.Add(dadoscolob_btn);
            menulateral1.Controls.Add(holerite_btn);
            menulateral1.Controls.Add(histpontos_btn);
            menulateral1.Controls.Add(folhapgt_btn);
            menulateral1.Controls.Add(agendaferias_btn);
            menulateral1.Controls.Add(txtmenu);
            menulateral1.Controls.Add(label8);
            menulateral1.Location = new Point(0, 125);
            menulateral1.Margin = new Padding(4, 5, 4, 5);
            menulateral1.Name = "menulateral1";
            menulateral1.Size = new Size(193, 569);
            menulateral1.TabIndex = 2;
            menulateral1.Paint += menulateral_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ImageAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(8, 372);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.RightToLeft = RightToLeft.No;
            linkLabel1.Size = new Size(152, 19);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Alterar Colaborador";
            // 
            // demitir_func_btn
            // 
            demitir_func_btn.AutoSize = true;
            demitir_func_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            demitir_func_btn.ImageAlign = ContentAlignment.TopCenter;
            demitir_func_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            demitir_func_btn.LinkColor = Color.White;
            demitir_func_btn.Location = new Point(9, 286);
            demitir_func_btn.Margin = new Padding(4, 0, 4, 0);
            demitir_func_btn.Name = "demitir_func_btn";
            demitir_func_btn.RightToLeft = RightToLeft.No;
            demitir_func_btn.Size = new Size(156, 19);
            demitir_func_btn.TabIndex = 18;
            demitir_func_btn.TabStop = true;
            demitir_func_btn.Text = "Demitir Colaborador";
            // 
            // cadastrar_func_btn
            // 
            cadastrar_func_btn.AutoSize = true;
            cadastrar_func_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrar_func_btn.ImageAlign = ContentAlignment.TopCenter;
            cadastrar_func_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            cadastrar_func_btn.LinkColor = Color.White;
            cadastrar_func_btn.Location = new Point(7, 412);
            cadastrar_func_btn.Margin = new Padding(4, 0, 4, 0);
            cadastrar_func_btn.Name = "cadastrar_func_btn";
            cadastrar_func_btn.RightToLeft = RightToLeft.No;
            cadastrar_func_btn.Size = new Size(176, 19);
            cadastrar_func_btn.TabIndex = 16;
            cadastrar_func_btn.TabStop = true;
            cadastrar_func_btn.Text = "Cadastrar Colaborador";
            // 
            // dadoscolob_btn
            // 
            dadoscolob_btn.AutoSize = true;
            dadoscolob_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dadoscolob_btn.ImageAlign = ContentAlignment.TopCenter;
            dadoscolob_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            dadoscolob_btn.LinkColor = Color.White;
            dadoscolob_btn.Location = new Point(9, 331);
            dadoscolob_btn.Margin = new Padding(4, 0, 4, 0);
            dadoscolob_btn.Name = "dadoscolob_btn";
            dadoscolob_btn.RightToLeft = RightToLeft.No;
            dadoscolob_btn.Size = new Size(151, 19);
            dadoscolob_btn.TabIndex = 15;
            dadoscolob_btn.TabStop = true;
            dadoscolob_btn.Text = "Dados Colaborador";
            // 
            // holerite_btn
            // 
            holerite_btn.AutoSize = true;
            holerite_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            holerite_btn.ImageAlign = ContentAlignment.TopCenter;
            holerite_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            holerite_btn.LinkColor = Color.White;
            holerite_btn.Location = new Point(9, 240);
            holerite_btn.Margin = new Padding(4, 0, 4, 0);
            holerite_btn.Name = "holerite_btn";
            holerite_btn.RightToLeft = RightToLeft.No;
            holerite_btn.Size = new Size(64, 19);
            holerite_btn.TabIndex = 12;
            holerite_btn.TabStop = true;
            holerite_btn.Text = "Holerite";
            holerite_btn.LinkClicked += holerite_btn_LinkClicked;
            // 
            // histpontos_btn
            // 
            histpontos_btn.AutoSize = true;
            histpontos_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            histpontos_btn.ImageAlign = ContentAlignment.TopCenter;
            histpontos_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            histpontos_btn.LinkColor = Color.White;
            histpontos_btn.Location = new Point(9, 194);
            histpontos_btn.Margin = new Padding(4, 0, 4, 0);
            histpontos_btn.Name = "histpontos_btn";
            histpontos_btn.RightToLeft = RightToLeft.No;
            histpontos_btn.Size = new Size(151, 19);
            histpontos_btn.TabIndex = 11;
            histpontos_btn.TabStop = true;
            histpontos_btn.Text = "Historico de Pontos";
            histpontos_btn.LinkClicked += histpontos_btn_LinkClicked;
            // 
            // folhapgt_btn
            // 
            folhapgt_btn.AutoSize = true;
            folhapgt_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            folhapgt_btn.ImageAlign = ContentAlignment.TopCenter;
            folhapgt_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            folhapgt_btn.LinkColor = Color.White;
            folhapgt_btn.Location = new Point(9, 148);
            folhapgt_btn.Margin = new Padding(4, 0, 4, 0);
            folhapgt_btn.Name = "folhapgt_btn";
            folhapgt_btn.RightToLeft = RightToLeft.No;
            folhapgt_btn.Size = new Size(159, 19);
            folhapgt_btn.TabIndex = 10;
            folhapgt_btn.TabStop = true;
            folhapgt_btn.Text = "Folha de Pagamento";
            folhapgt_btn.LinkClicked += folhapgt_btn_LinkClicked;
            // 
            // agendaferias_btn
            // 
            agendaferias_btn.AutoSize = true;
            agendaferias_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            agendaferias_btn.ImageAlign = ContentAlignment.TopCenter;
            agendaferias_btn.LinkBehavior = LinkBehavior.NeverUnderline;
            agendaferias_btn.LinkColor = Color.White;
            agendaferias_btn.Location = new Point(9, 106);
            agendaferias_btn.Margin = new Padding(4, 0, 4, 0);
            agendaferias_btn.Name = "agendaferias_btn";
            agendaferias_btn.RightToLeft = RightToLeft.No;
            agendaferias_btn.Size = new Size(122, 19);
            agendaferias_btn.TabIndex = 9;
            agendaferias_btn.TabStop = true;
            agendaferias_btn.Text = "Agendar Ferias";
            agendaferias_btn.LinkClicked += agendaferias_btn_LinkClicked;
            // 
            // txtmenu
            // 
            txtmenu.AutoSize = true;
            txtmenu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtmenu.ForeColor = Color.White;
            txtmenu.Location = new Point(13, 37);
            txtmenu.Margin = new Padding(4, 0, 4, 0);
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
            label8.Location = new Point(12, 51);
            label8.Margin = new Padding(4, 0, 4, 0);
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
            label1.Location = new Point(459, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 29);
            label1.TabIndex = 3;
            label1.Text = "Bem Vindo [Funcionario]!";
            label1.Click += label1_Click;
            // 
            // fundo_ultreg
            // 
            fundo_ultreg.BackColor = Color.FromArgb(0, 122, 255);
            fundo_ultreg.Controls.Add(label5);
            fundo_ultreg.Controls.Add(label2);
            fundo_ultreg.ForeColor = SystemColors.ActiveCaptionText;
            fundo_ultreg.Location = new Point(327, 251);
            fundo_ultreg.Margin = new Padding(4, 5, 4, 5);
            fundo_ultreg.Name = "fundo_ultreg";
            fundo_ultreg.Size = new Size(148, 168);
            fundo_ultreg.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 89);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 1;
            label5.Text = "00:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 0;
            label2.Text = "Ultimo Registro";
            // 
            // fundo_hextras
            // 
            fundo_hextras.BackColor = Color.FromArgb(0, 122, 255);
            fundo_hextras.Controls.Add(label6);
            fundo_hextras.Controls.Add(label3);
            fundo_hextras.ForeColor = SystemColors.ActiveCaptionText;
            fundo_hextras.Location = new Point(528, 251);
            fundo_hextras.Margin = new Padding(4, 5, 4, 5);
            fundo_hextras.Name = "fundo_hextras";
            fundo_hextras.Size = new Size(148, 168);
            fundo_hextras.TabIndex = 5;
            fundo_hextras.Paint += fundo_hextras_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 89);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 2;
            label6.Text = "00:00:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 1;
            label3.Text = "Horas Extra";
            label3.Click += label3_Click;
            // 
            // fundo_dia
            // 
            fundo_dia.BackColor = Color.FromArgb(0, 122, 255);
            fundo_dia.Controls.Add(labelDia);
            fundo_dia.Controls.Add(labelData);
            fundo_dia.Controls.Add(label4);
            fundo_dia.ForeColor = SystemColors.ActiveCaptionText;
            fundo_dia.Location = new Point(720, 251);
            fundo_dia.Margin = new Padding(4, 5, 4, 5);
            fundo_dia.Name = "fundo_dia";
            fundo_dia.Size = new Size(148, 168);
            fundo_dia.TabIndex = 6;
            fundo_dia.Paint += fundo_dia_Paint;
            // 
            // labelDia
            // 
            labelDia.AutoSize = true;
            labelDia.ForeColor = SystemColors.ButtonHighlight;
            labelDia.Location = new Point(23, 102);
            labelDia.Name = "labelDia";
            labelDia.Size = new Size(0, 20);
            labelDia.TabIndex = 4;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.ForeColor = Color.White;
            labelData.Location = new Point(39, 89);
            labelData.Margin = new Padding(4, 0, 4, 0);
            labelData.Name = "labelData";
            labelData.Size = new Size(0, 17);
            labelData.TabIndex = 3;
            labelData.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 2;
            label4.Text = "Dia da Semana";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ponto_btn);
            panel1.Location = new Point(480, 497);
            panel1.Margin = new Padding(4, 5, 4, 5);
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
            ponto_btn.Location = new Point(27, 6);
            ponto_btn.Margin = new Padding(4, 5, 4, 5);
            ponto_btn.Name = "ponto_btn";
            ponto_btn.Size = new Size(192, 35);
            ponto_btn.TabIndex = 1;
            ponto_btn.Text = "BATER PONTO";
            ponto_btn.UseVisualStyleBackColor = false;
            ponto_btn.Click += ponto_btn_Click;
            // 
            // textIdFuncionario
            // 
            textIdFuncionario.Location = new Point(567, 448);
            textIdFuncionario.Name = "textIdFuncionario";
            textIdFuncionario.Size = new Size(125, 27);
            textIdFuncionario.TabIndex = 8;
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
            // pg_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1067, 692);
            Controls.Add(label9);
            Controls.Add(textIdFuncionario);
            Controls.Add(panel1);
            Controls.Add(fundo_dia);
            Controls.Add(fundo_hextras);
            Controls.Add(fundo_ultreg);
            Controls.Add(label1);
            Controls.Add(menulateral1);
            Controls.Add(cabecalho1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "pg_home";
            Text = "pg_incial";
            cabecalho1.ResumeLayout(false);
            cabecalho1.PerformLayout();
            menulateral1.ResumeLayout(false);
            menulateral1.PerformLayout();
            fundo_ultreg.ResumeLayout(false);
            fundo_ultreg.PerformLayout();
            fundo_hextras.ResumeLayout(false);
            fundo_hextras.PerformLayout();
            fundo_dia.ResumeLayout(false);
            fundo_dia.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel cabecalho1;
        private Panel menulateral1;
        private Label txttitle;
        private Label label1;
        private Panel fundo_ultreg;
        private Panel fundo_hextras;
        private Panel fundo_dia;
        private Panel panel1;
        private Button ponto_btn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelData;
        private Label txtmenu;
        private Label label8;
        private LinkLabel agendaferias_btn;
        private LinkLabel folhapgt_btn;
        private LinkLabel holerite_btn;
        private LinkLabel histpontos_btn;
        private LinkLabel cadastrar_func_btn;
        private LinkLabel dadoscolob_btn;
        private LinkLabel demitir_func_btn;
        private LinkLabel linkLabel1;
        private TextBox textIdFuncionario;
        private Label label9;
        private Label labelDia;
    }
}