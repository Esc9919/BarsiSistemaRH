namespace Login
{
    partial class pg_folha_pgto
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
            this.txttitle = new System.Windows.Forms.Label();
            this.cabecalho1 = new System.Windows.Forms.Panel();
            this.menulateral1 = new System.Windows.Forms.Panel();
            this.c = new System.Windows.Forms.LinkLabel();
            this.txtmenu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_colocaborador = new System.Windows.Forms.ComboBox();
            this.folha_btn = new System.Windows.Forms.Button();
            this.cabecalho1.SuspendLayout();
            this.menulateral1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.AutoSize = true;
            this.txttitle.BackColor = System.Drawing.Color.Transparent;
            this.txttitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.ForeColor = System.Drawing.Color.White;
            this.txttitle.Location = new System.Drawing.Point(286, 26);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(286, 32);
            this.txttitle.TabIndex = 0;
            this.txttitle.Text = "Folha de Pagamento";
            this.txttitle.Click += new System.EventHandler(this.txttitle_Click);
            // 
            // cabecalho1
            // 
            this.cabecalho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.cabecalho1.Controls.Add(this.txttitle);
            this.cabecalho1.Location = new System.Drawing.Point(-5, 0);
            this.cabecalho1.Name = "cabecalho1";
            this.cabecalho1.Size = new System.Drawing.Size(810, 81);
            this.cabecalho1.TabIndex = 5;
            // 
            // menulateral1
            // 
            this.menulateral1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.menulateral1.Controls.Add(this.c);
            this.menulateral1.Controls.Add(this.txtmenu);
            this.menulateral1.Controls.Add(this.label8);
            this.menulateral1.Location = new System.Drawing.Point(-1, 81);
            this.menulateral1.Name = "menulateral1";
            this.menulateral1.Size = new System.Drawing.Size(145, 370);
            this.menulateral1.TabIndex = 6;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.c.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.c.LinkColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(7, 66);
            this.c.Name = "c";
            this.c.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.c.Size = new System.Drawing.Size(41, 16);
            this.c.TabIndex = 8;
            this.c.TabStop = true;
            this.c.Text = "Voltar";
            this.c.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.c_LinkClicked);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Colaborador:";
            // 
            // comboBox_colocaborador
            // 
            this.comboBox_colocaborador.FormattingEnabled = true;
            this.comboBox_colocaborador.Items.AddRange(new object[] {
            "Gabriel",
            "Gabriel Lindo"});
            this.comboBox_colocaborador.Location = new System.Drawing.Point(423, 142);
            this.comboBox_colocaborador.Name = "comboBox_colocaborador";
            this.comboBox_colocaborador.Size = new System.Drawing.Size(121, 21);
            this.comboBox_colocaborador.TabIndex = 20;
            // 
            // folha_btn
            // 
            this.folha_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.folha_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.folha_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.folha_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folha_btn.ForeColor = System.Drawing.Color.White;
            this.folha_btn.Location = new System.Drawing.Point(384, 214);
            this.folha_btn.Name = "folha_btn";
            this.folha_btn.Size = new System.Drawing.Size(144, 23);
            this.folha_btn.TabIndex = 23;
            this.folha_btn.Text = "GERAR FOLHA";
            this.folha_btn.UseVisualStyleBackColor = false;
            // 
            // pg_folha_pgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.folha_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_colocaborador);
            this.Controls.Add(this.cabecalho1);
            this.Controls.Add(this.menulateral1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pg_folha_pgto";
            this.Text = "pg_folhapgto";
            this.cabecalho1.ResumeLayout(false);
            this.cabecalho1.PerformLayout();
            this.menulateral1.ResumeLayout(false);
            this.menulateral1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttitle;
        private System.Windows.Forms.Panel cabecalho1;
        private System.Windows.Forms.Panel menulateral1;
        private System.Windows.Forms.LinkLabel c;
        private System.Windows.Forms.Label txtmenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_colocaborador;
        private System.Windows.Forms.Button folha_btn;
    }
}