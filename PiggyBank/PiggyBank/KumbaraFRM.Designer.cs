namespace PiggyBank
{
    partial class KumbaraFRM
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
            this.cmbBozukPara = new System.Windows.Forms.ComboBox();
            this.cmbKagitPara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnParaKatla = new System.Windows.Forms.Button();
            this.btnKumbaraSalla = new System.Windows.Forms.Button();
            this.btnKumbaraKir = new System.Windows.Forms.Button();
            this.lbKumbara = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamHacim = new System.Windows.Forms.Label();
            this.lblFazlaHacimText = new System.Windows.Forms.Label();
            this.lblFazlaHacim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBozukPara
            // 
            this.cmbBozukPara.FormattingEnabled = true;
            this.cmbBozukPara.Location = new System.Drawing.Point(197, 60);
            this.cmbBozukPara.Name = "cmbBozukPara";
            this.cmbBozukPara.Size = new System.Drawing.Size(216, 28);
            this.cmbBozukPara.TabIndex = 0;
            this.cmbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cmbBozukPara_SelectedIndexChanged);
            // 
            // cmbKagitPara
            // 
            this.cmbKagitPara.FormattingEnabled = true;
            this.cmbKagitPara.Location = new System.Drawing.Point(198, 94);
            this.cmbKagitPara.Name = "cmbKagitPara";
            this.cmbKagitPara.Size = new System.Drawing.Size(216, 28);
            this.cmbKagitPara.TabIndex = 1;
            this.cmbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cmbKagitPara_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bozuk Para: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kağıt Para: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "KUMBARAYA ATMAK İSTEDİĞİNİZ PARAYI SEÇİNİZ";
            // 
            // btnParaAt
            // 
            this.btnParaAt.Location = new System.Drawing.Point(60, 148);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(167, 51);
            this.btnParaAt.TabIndex = 5;
            this.btnParaAt.Text = "Para At";
            this.btnParaAt.UseVisualStyleBackColor = true;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnParaKatla
            // 
            this.btnParaKatla.Location = new System.Drawing.Point(233, 148);
            this.btnParaKatla.Name = "btnParaKatla";
            this.btnParaKatla.Size = new System.Drawing.Size(180, 51);
            this.btnParaKatla.TabIndex = 6;
            this.btnParaKatla.Text = "Parayı Katla";
            this.btnParaKatla.UseVisualStyleBackColor = true;
            this.btnParaKatla.Click += new System.EventHandler(this.btnParaKatla_Click);
            // 
            // btnKumbaraSalla
            // 
            this.btnKumbaraSalla.Location = new System.Drawing.Point(62, 205);
            this.btnKumbaraSalla.Name = "btnKumbaraSalla";
            this.btnKumbaraSalla.Size = new System.Drawing.Size(350, 43);
            this.btnKumbaraSalla.TabIndex = 7;
            this.btnKumbaraSalla.Text = "Kumbarayı Salla";
            this.btnKumbaraSalla.UseVisualStyleBackColor = true;
            this.btnKumbaraSalla.Click += new System.EventHandler(this.btnKumbaraSalla_Click);
            // 
            // btnKumbaraKir
            // 
            this.btnKumbaraKir.Location = new System.Drawing.Point(63, 254);
            this.btnKumbaraKir.Name = "btnKumbaraKir";
            this.btnKumbaraKir.Size = new System.Drawing.Size(350, 46);
            this.btnKumbaraKir.TabIndex = 8;
            this.btnKumbaraKir.Text = "KUMBARAYI KIR !!!";
            this.btnKumbaraKir.UseVisualStyleBackColor = true;
            this.btnKumbaraKir.Click += new System.EventHandler(this.btnKumbaraKir_Click);
            // 
            // lbKumbara
            // 
            this.lbKumbara.FormattingEnabled = true;
            this.lbKumbara.ItemHeight = 20;
            this.lbKumbara.Location = new System.Drawing.Point(462, 19);
            this.lbKumbara.Name = "lbKumbara";
            this.lbKumbara.Size = new System.Drawing.Size(253, 284);
            this.lbKumbara.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "KUMBARA HACMİ: ";
            // 
            // lblToplamHacim
            // 
            this.lblToplamHacim.AutoSize = true;
            this.lblToplamHacim.Location = new System.Drawing.Point(314, 345);
            this.lblToplamHacim.Name = "lblToplamHacim";
            this.lblToplamHacim.Size = new System.Drawing.Size(18, 20);
            this.lblToplamHacim.TabIndex = 11;
            this.lblToplamHacim.Text = "0";
            // 
            // lblFazlaHacimText
            // 
            this.lblFazlaHacimText.AutoSize = true;
            this.lblFazlaHacimText.Location = new System.Drawing.Point(16, 369);
            this.lblFazlaHacimText.Name = "lblFazlaHacimText";
            this.lblFazlaHacimText.Size = new System.Drawing.Size(289, 20);
            this.lblFazlaHacimText.TabIndex = 12;
            this.lblFazlaHacimText.Text = "PARANIN KAPLADIĞI FAZLA HACİM: ";
            // 
            // lblFazlaHacim
            // 
            this.lblFazlaHacim.AutoSize = true;
            this.lblFazlaHacim.Location = new System.Drawing.Point(314, 369);
            this.lblFazlaHacim.Name = "lblFazlaHacim";
            this.lblFazlaHacim.Size = new System.Drawing.Size(18, 20);
            this.lblFazlaHacim.TabIndex = 13;
            this.lblFazlaHacim.Text = "0";
            // 
            // KumbaraFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 423);
            this.Controls.Add(this.lblFazlaHacim);
            this.Controls.Add(this.lblFazlaHacimText);
            this.Controls.Add(this.lblToplamHacim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbKumbara);
            this.Controls.Add(this.btnKumbaraKir);
            this.Controls.Add(this.btnKumbaraSalla);
            this.Controls.Add(this.btnParaKatla);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKagitPara);
            this.Controls.Add(this.cmbBozukPara);
            this.Name = "KumbaraFRM";
            this.Text = "Kumbara";
            this.Load += new System.EventHandler(this.KumbaraFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBozukPara;
        private System.Windows.Forms.ComboBox cmbKagitPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnParaKatla;
        private System.Windows.Forms.Button btnKumbaraSalla;
        private System.Windows.Forms.Button btnKumbaraKir;
        private System.Windows.Forms.ListBox lbKumbara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamHacim;
        private System.Windows.Forms.Label lblFazlaHacimText;
        private System.Windows.Forms.Label lblFazlaHacim;
    }
}

