namespace TestWinLubo
{
    partial class frmKnijarnica
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
            this.grbJanr = new System.Windows.Forms.GroupBox();
            this.rbSpravochna = new System.Windows.Forms.RadioButton();
            this.rbNauchno = new System.Windows.Forms.RadioButton();
            this.rbhud = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbIzdatelstva = new System.Windows.Forms.ComboBox();
            this.lblizdatelstva = new System.Windows.Forms.Label();
            this.lblavtor = new System.Windows.Forms.Label();
            this.lblzaglavie = new System.Windows.Forms.Label();
            this.textBoxAvtor = new System.Windows.Forms.TextBox();
            this.TextBoxZaglavie = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMeka = new System.Windows.Forms.CheckBox();
            this.chbTvarda = new System.Windows.Forms.CheckBox();
            this.grbJanr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbJanr
            // 
            this.grbJanr.Controls.Add(this.rbSpravochna);
            this.grbJanr.Controls.Add(this.rbNauchno);
            this.grbJanr.Controls.Add(this.rbhud);
            this.grbJanr.Location = new System.Drawing.Point(608, 203);
            this.grbJanr.Name = "grbJanr";
            this.grbJanr.Size = new System.Drawing.Size(357, 164);
            this.grbJanr.TabIndex = 0;
            this.grbJanr.TabStop = false;
            this.grbJanr.Text = "Janar";
            this.grbJanr.Enter += new System.EventHandler(this.grbJanr_Enter);
            // 
            // rbSpravochna
            // 
            this.rbSpravochna.AutoSize = true;
            this.rbSpravochna.Location = new System.Drawing.Point(27, 122);
            this.rbSpravochna.Name = "rbSpravochna";
            this.rbSpravochna.Size = new System.Drawing.Size(99, 20);
            this.rbSpravochna.TabIndex = 2;
            this.rbSpravochna.TabStop = true;
            this.rbSpravochna.Text = "spravochna";
            this.rbSpravochna.UseVisualStyleBackColor = true;
            // 
            // rbNauchno
            // 
            this.rbNauchno.AutoSize = true;
            this.rbNauchno.Location = new System.Drawing.Point(27, 80);
            this.rbNauchno.Name = "rbNauchno";
            this.rbNauchno.Size = new System.Drawing.Size(144, 20);
            this.rbNauchno.TabIndex = 1;
            this.rbNauchno.TabStop = true;
            this.rbNauchno.Text = "nauchno-populqrna";
            this.rbNauchno.UseVisualStyleBackColor = true;
            // 
            // rbhud
            // 
            this.rbhud.AutoSize = true;
            this.rbhud.Location = new System.Drawing.Point(27, 43);
            this.rbhud.Name = "rbhud";
            this.rbhud.Size = new System.Drawing.Size(104, 20);
            this.rbhud.TabIndex = 0;
            this.rbhud.TabStop = true;
            this.rbhud.Text = "hudijestvena";
            this.rbhud.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "nameri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbIzdatelstva
            // 
            this.cmbIzdatelstva.FormattingEnabled = true;
            this.cmbIzdatelstva.Items.AddRange(new object[] {
            "24 квадрата",
            "*41Т\" ЕООД\"4U",
            "5 за 4 ООД5 ",
            "Звезди7 лъча",
            "A & C Black",
            "A Dell BookA",
            " T Publishing",
            "ABACUSABC",
            "AbramsAce ",
            "BooksACP ",
            "BooksAddison - Wesley",
            "Advantage Publishers",
            " GroupAdvizaAEC - AMHAgodsfield book",
            "AlexSoftAlgonquin ",
            "BooksAlma",
            " ClassicsAmazon",
            "AMG PublishingAmicitiaAnchor ",
            "booksAnimato Music",
            "AppleAquamarine"});
            this.cmbIzdatelstva.Location = new System.Drawing.Point(78, 222);
            this.cmbIzdatelstva.Name = "cmbIzdatelstva";
            this.cmbIzdatelstva.Size = new System.Drawing.Size(342, 24);
            this.cmbIzdatelstva.TabIndex = 2;
            this.cmbIzdatelstva.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblizdatelstva
            // 
            this.lblizdatelstva.AutoSize = true;
            this.lblizdatelstva.Location = new System.Drawing.Point(221, 203);
            this.lblizdatelstva.Name = "lblizdatelstva";
            this.lblizdatelstva.Size = new System.Drawing.Size(71, 16);
            this.lblizdatelstva.TabIndex = 3;
            this.lblizdatelstva.Text = "izdatelstva";
            // 
            // lblavtor
            // 
            this.lblavtor.AutoSize = true;
            this.lblavtor.Location = new System.Drawing.Point(221, 43);
            this.lblavtor.Name = "lblavtor";
            this.lblavtor.Size = new System.Drawing.Size(38, 16);
            this.lblavtor.TabIndex = 4;
            this.lblavtor.Text = "Avtor";
            // 
            // lblzaglavie
            // 
            this.lblzaglavie.AutoSize = true;
            this.lblzaglavie.Location = new System.Drawing.Point(736, 43);
            this.lblzaglavie.Name = "lblzaglavie";
            this.lblzaglavie.Size = new System.Drawing.Size(60, 16);
            this.lblzaglavie.TabIndex = 5;
            this.lblzaglavie.Text = "Zaglavie";
            // 
            // textBoxAvtor
            // 
            this.textBoxAvtor.Location = new System.Drawing.Point(158, 88);
            this.textBoxAvtor.Name = "textBoxAvtor";
            this.textBoxAvtor.Size = new System.Drawing.Size(166, 22);
            this.textBoxAvtor.TabIndex = 6;
            // 
            // TextBoxZaglavie
            // 
            this.TextBoxZaglavie.Location = new System.Drawing.Point(685, 88);
            this.TextBoxZaglavie.Name = "TextBoxZaglavie";
            this.TextBoxZaglavie.Size = new System.Drawing.Size(166, 22);
            this.TextBoxZaglavie.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbTvarda);
            this.groupBox1.Controls.Add(this.chbMeka);
            this.groupBox1.Location = new System.Drawing.Point(134, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vid Korica";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chbMeka
            // 
            this.chbMeka.AutoSize = true;
            this.chbMeka.Location = new System.Drawing.Point(34, 49);
            this.chbMeka.Name = "chbMeka";
            this.chbMeka.Size = new System.Drawing.Size(63, 20);
            this.chbMeka.TabIndex = 0;
            this.chbMeka.Text = "Meka";
            this.chbMeka.UseVisualStyleBackColor = true;
            // 
            // chbTvarda
            // 
            this.chbTvarda.AutoSize = true;
            this.chbTvarda.Location = new System.Drawing.Point(34, 96);
            this.chbTvarda.Name = "chbTvarda";
            this.chbTvarda.Size = new System.Drawing.Size(67, 20);
            this.chbTvarda.TabIndex = 1;
            this.chbTvarda.Text = "tvarda";
            this.chbTvarda.UseVisualStyleBackColor = true;
            // 
            // frmKnijarnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 639);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxZaglavie);
            this.Controls.Add(this.textBoxAvtor);
            this.Controls.Add(this.lblzaglavie);
            this.Controls.Add(this.lblavtor);
            this.Controls.Add(this.lblizdatelstva);
            this.Controls.Add(this.cmbIzdatelstva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbJanr);
            this.Name = "frmKnijarnica";
            this.Text = "Knijarnica";
            this.Load += new System.EventHandler(this.frmKnijarnica_Load);
            this.grbJanr.ResumeLayout(false);
            this.grbJanr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbJanr;
        private System.Windows.Forms.RadioButton rbSpravochna;
        private System.Windows.Forms.RadioButton rbNauchno;
        private System.Windows.Forms.RadioButton rbhud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbIzdatelstva;
        private System.Windows.Forms.Label lblizdatelstva;
        private System.Windows.Forms.Label lblavtor;
        private System.Windows.Forms.Label lblzaglavie;
        private System.Windows.Forms.TextBox textBoxAvtor;
        private System.Windows.Forms.TextBox TextBoxZaglavie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbTvarda;
        private System.Windows.Forms.CheckBox chbMeka;
    }
}

