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
            this.cabecalho1 = new System.Windows.Forms.Panel();
            this.txttitle = new System.Windows.Forms.Label();
            this.menulateral1 = new System.Windows.Forms.Panel();
            this.BtnVoltar = new System.Windows.Forms.LinkLabel();
            this.txtmenu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textcolaborador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textferiafim = new System.Windows.Forms.TextBox();
            this.textferiaini = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ferias_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cabecalho1.SuspendLayout();
            this.menulateral1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cabecalho1
            // 
            this.cabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.cabecalho1.Controls.Add(this.txttitle);
            this.cabecalho1.Location = new System.Drawing.Point(-5, 0);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(810, 81);
            this.cabecalho1.TabIndex = 3;
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.BackColor = System.Drawing.Color.Transparent;
            this.txttitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.Color.White;
            this.txttitle.Location = new System.Drawing.Point(358, 23);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(215, 32);
            this.txttitle.TabIndex = 0;
            this.txttitle.Text = "Agendar Ferias";
            // 
            // menulateral1
            // 
            this.menulateral1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.menulateral1.Controls.Add(this.BtnVoltar);
            this.menulateral1.Controls.Add(this.txtmenu);
            this.menulateral1.Controls.Add(this.label8);
            this.menulateral1.Location = new System.Drawing.Point(-1, 81);
            this.menulateral1.Name = "menulateral1";
            this.menulateral1.Size = new System.Drawing.Size(145, 370);
            this.menulateral1.TabIndex = 4;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.AutoSize = true;
            this.BtnVoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BtnVoltar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVoltar.Location = new System.Drawing.Point(14, 65);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(41, 16);
            this.BtnVoltar.TabIndex = 2;
            this.BtnVoltar.TabStop = true;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnVoltar_LinkClicked);
            // 
            // txtmenu
            // 
            this.txtmenu.AutoSize = true;
            this.txtmenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmenu.ForeColor = System.Drawing.Color.White;
            this.txtmenu.Location = new System.Drawing.Point(10, 24);
            this.txtmenu.Name = "txtmenu";
            this.txtmenu.Size = new System.Drawing.Size(57, 19);
            this.txtmenu.TabIndex = 0;
            this.txtmenu.Text = "MENU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "____________";
            // 
            // textcolaborador
            // 
            this.textcolaborador.FormattingEnabled = true;
            this.textcolaborador.Items.AddRange(new object[] {
            "Gabriel",
            "Gabriel Lindo"});
            this.textcolaborador.Location = new System.Drawing.Point(278, 106);
            this.textcolaborador.Name = "textcolaborador";
            this.textcolaborador.Size = new System.Drawing.Size(121, 21);
            this.textcolaborador.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Colaborador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Incio Ferias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Fim Ferias:";
            // 
            // textferiafim
            // 
            this.textferiafim.Location = new System.Drawing.Point(300, 75);
            this.textferiafim.Name = "textferiafim";
            this.textferiafim.Size = new System.Drawing.Size(100, 20);
            this.textferiafim.TabIndex = 14;
            this.textferiafim.Text = "dd\\mm\\aaaa";
            // 
            // textferiaini
            // 
            this.textferiaini.Location = new System.Drawing.Point(300, 51);
            this.textferiaini.Name = "textferiaini";
            this.textferiaini.Size = new System.Drawing.Size(100, 20);
            this.textferiaini.TabIndex = 13;
            this.textferiaini.Text = "dd\\mm\\aaaa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Fim Ferias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data Incio Ferias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "dd\\mm\\aaaa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "dd\\mm\\aaaa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(181, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 137);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "dd\\mm\\aaaa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(177, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Data Fim Ferias:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ferias_btn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textferiafim);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textferiaini);
            this.panel3.Location = new System.Drawing.Point(181, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 152);
            this.panel3.TabIndex = 12;
            // 
            // ferias_btn
            // 
            this.ferias_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.ferias_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ferias_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ferias_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ferias_btn.ForeColor = System.Drawing.Color.White;
            this.ferias_btn.Location = new System.Drawing.Point(232, 117);
            this.ferias_btn.Name = "ferias_btn";
            this.ferias_btn.Size = new System.Drawing.Size(144, 23);
            this.ferias_btn.TabIndex = 24;
            this.ferias_btn.Text = "CONFIRMAR";
            this.ferias_btn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 36);
            this.panel4.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(216, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Agendamento de Ferias";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(181, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 36);
            this.panel1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ferias Agendadas:";
            // 
            // pg_agenda_ferias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcolaborador);
            this.Controls.Add(this.cabecalho1);
            this.Controls.Add(this.menulateral1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pg_agenda_ferias";
            this.Text = "pg_agenda_ferias";
            this.cabecalho1.ResumeLayout(false);
            this.cabecalho1.PerformLayout();
            this.menulateral1.ResumeLayout(false);
            this.menulateral1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cabecalho1;
        private System.Windows.Forms.Label txttitle;
        private System.Windows.Forms.Panel menulateral1;
        private System.Windows.Forms.Label txtmenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox textcolaborador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textferiafim;
        private System.Windows.Forms.TextBox textferiaini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ferias_btn;
        private System.Windows.Forms.LinkLabel BtnVoltar;
    }
}