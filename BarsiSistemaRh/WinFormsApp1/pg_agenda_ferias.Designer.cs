namespace Login
{
    partial class pg_agenda_ferias
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
            cabecalho1 = new Panel();
            txttitle = new Label();
            menulateral1 = new Panel();
            BtnVoltar = new LinkLabel();
            txtmenu = new Label();
            label8 = new Label();
            textcolaborador = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textferiafim = new TextBox();
            textferiaini = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ferias_btn = new Button();
            panel4 = new Panel();
            label14 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            cabecalho1.SuspendLayout();
            menulateral1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            cabecalho1.TabIndex = 3;
            // 
            // txttitle
            // 
            txttitle.AutoSize = true;
            txttitle.BackColor = Color.Transparent;
            txttitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txttitle.ForeColor = Color.White;
            txttitle.Location = new Point(477, 35);
            txttitle.Margin = new Padding(4, 0, 4, 0);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(264, 40);
            txttitle.TabIndex = 0;
            txttitle.Text = "Agendar Ferias";
            // 
            // menulateral1
            // 
            menulateral1.BackColor = Color.FromArgb(0, 122, 255);
            menulateral1.Controls.Add(BtnVoltar);
            menulateral1.Controls.Add(txtmenu);
            menulateral1.Controls.Add(label8);
            menulateral1.Location = new Point(-1, 125);
            menulateral1.Margin = new Padding(4, 5, 4, 5);
            menulateral1.Name = "menulateral1";
            menulateral1.Size = new Size(193, 569);
            menulateral1.TabIndex = 4;
            // 
            // BtnVoltar
            // 
            BtnVoltar.AutoSize = true;
            BtnVoltar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVoltar.LinkBehavior = LinkBehavior.NeverUnderline;
            BtnVoltar.LinkColor = Color.FromArgb(224, 224, 224);
            BtnVoltar.Location = new Point(19, 100);
            BtnVoltar.Margin = new Padding(4, 0, 4, 0);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(50, 19);
            BtnVoltar.TabIndex = 2;
            BtnVoltar.TabStop = true;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.LinkClicked += BtnVoltar_LinkClicked;
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
            // textcolaborador
            // 
            textcolaborador.FormattingEnabled = true;
            textcolaborador.Items.AddRange(new object[] { "Gabriel", "Gabriel Lindo" });
            textcolaborador.Location = new Point(371, 163);
            textcolaborador.Margin = new Padding(4, 5, 4, 5);
            textcolaborador.Name = "textcolaborador";
            textcolaborador.Size = new Size(160, 28);
            textcolaborador.TabIndex = 5;
            textcolaborador.SelectedIndexChanged += textcolaborador_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 165);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 6;
            label1.Text = "Colaborador:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(233, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 19);
            label2.TabIndex = 7;
            label2.Text = "Data Incio Ferias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(233, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 19);
            label3.TabIndex = 8;
            label3.Text = "Data Fim Ferias:";
            // 
            // textferiafim
            // 
            textferiafim.Location = new Point(400, 115);
            textferiafim.Margin = new Padding(4, 5, 4, 5);
            textferiafim.Name = "textferiafim";
            textferiafim.Size = new Size(132, 27);
            textferiafim.TabIndex = 14;
            textferiafim.Text = "dd\\mm\\aaaa";
            // 
            // textferiaini
            // 
            textferiaini.Location = new Point(400, 78);
            textferiaini.Margin = new Padding(4, 5, 4, 5);
            textferiaini.Name = "textferiaini";
            textferiaini.Size = new Size(132, 27);
            textferiaini.TabIndex = 13;
            textferiaini.Text = "dd\\mm\\aaaa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(233, 115);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 19);
            label6.TabIndex = 12;
            label6.Text = "Data Fim Ferias:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(233, 80);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(146, 19);
            label7.TabIndex = 11;
            label7.Text = "Data Incio Ferias:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 83);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "dd\\mm\\aaaa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 118);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 10;
            label5.Text = "dd\\mm\\aaaa";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(241, 209);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 211);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(ferias_btn);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textferiafim);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textferiaini);
            panel3.Location = new Point(241, 440);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(795, 234);
            panel3.TabIndex = 12;
            // 
            // ferias_btn
            // 
            ferias_btn.BackColor = Color.FromArgb(0, 121, 255);
            ferias_btn.BackgroundImageLayout = ImageLayout.None;
            ferias_btn.FlatStyle = FlatStyle.Popup;
            ferias_btn.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ferias_btn.ForeColor = Color.White;
            ferias_btn.Location = new Point(309, 180);
            ferias_btn.Margin = new Padding(4, 5, 4, 5);
            ferias_btn.Name = "ferias_btn";
            ferias_btn.Size = new Size(192, 35);
            ferias_btn.TabIndex = 24;
            ferias_btn.Text = "CONFIRMAR";
            ferias_btn.UseVisualStyleBackColor = false;
            ferias_btn.Click += ferias_btn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label14);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(795, 55);
            panel4.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(288, 17);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(194, 19);
            label14.TabIndex = 11;
            label14.Text = "Agendamento de Ferias";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(241, 209);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 55);
            panel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(320, 15);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 19);
            label9.TabIndex = 11;
            label9.Text = "Ferias Agendadas:";
            // 
            // pg_agenda_ferias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1067, 692);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(textcolaborador);
            Controls.Add(cabecalho1);
            Controls.Add(menulateral1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "pg_agenda_ferias";
            Text = "pg_agenda_ferias";
            cabecalho1.ResumeLayout(false);
            cabecalho1.PerformLayout();
            menulateral1.ResumeLayout(false);
            menulateral1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel cabecalho1;
        private Label txttitle;
        private Panel menulateral1;
        private Label txtmenu;
        private Label label8;
        private ComboBox textcolaborador;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textferiafim;
        private TextBox textferiaini;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private Panel panel1;
        private Label label9;
        private Button ferias_btn;
        private LinkLabel BtnVoltar;
    }
}