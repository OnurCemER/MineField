namespace _163301059
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpMayin = new System.Windows.Forms.GroupBox();
            this.btnMayinBasla = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.grpParametreler = new System.Windows.Forms.GroupBox();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblMayinSayisi = new System.Windows.Forms.Label();
            this.numericSure = new System.Windows.Forms.NumericUpDown();
            this.numericMayin = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSoru1 = new System.Windows.Forms.Label();
            this.grpArmstrong = new System.Windows.Forms.GroupBox();
            this.btnArmstrongBul = new System.Windows.Forms.Button();
            this.lblArmstrong = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtUstSinir = new System.Windows.Forms.TextBox();
            this.txtAltSinir = new System.Windows.Forms.TextBox();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblSoru2 = new System.Windows.Forms.Label();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.grpMayin.SuspendLayout();
            this.grpParametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMayin)).BeginInit();
            this.grpArmstrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMayin
            // 
            this.grpMayin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMayin.Controls.Add(this.btnMayinBasla);
            this.grpMayin.Controls.Add(this.lblSure);
            this.grpMayin.Controls.Add(this.grpParametreler);
            this.grpMayin.Controls.Add(this.flowLayoutPanel1);
            this.grpMayin.Controls.Add(this.lblSoru1);
            this.grpMayin.Location = new System.Drawing.Point(11, 11);
            this.grpMayin.Name = "grpMayin";
            this.grpMayin.Size = new System.Drawing.Size(275, 436);
            this.grpMayin.TabIndex = 0;
            this.grpMayin.TabStop = false;
            this.grpMayin.Text = "Mayın Tarlası";
            // 
            // btnMayinBasla
            // 
            this.btnMayinBasla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMayinBasla.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMayinBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMayinBasla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMayinBasla.Location = new System.Drawing.Point(182, 390);
            this.btnMayinBasla.Name = "btnMayinBasla";
            this.btnMayinBasla.Size = new System.Drawing.Size(79, 34);
            this.btnMayinBasla.TabIndex = 4;
            this.btnMayinBasla.Text = "Başla";
            this.btnMayinBasla.UseVisualStyleBackColor = false;
            this.btnMayinBasla.Click += new System.EventHandler(this.btnMayinBasla_Click);
            // 
            // lblSure
            // 
            this.lblSure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSure.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(5, 390);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(171, 34);
            this.lblSure.TabIndex = 3;
            this.lblSure.Text = "Kalan Süre = __";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpParametreler
            // 
            this.grpParametreler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpParametreler.Controls.Add(this.lblSaniye);
            this.grpParametreler.Controls.Add(this.lblMayinSayisi);
            this.grpParametreler.Controls.Add(this.numericSure);
            this.grpParametreler.Controls.Add(this.numericMayin);
            this.grpParametreler.Location = new System.Drawing.Point(6, 314);
            this.grpParametreler.Name = "grpParametreler";
            this.grpParametreler.Size = new System.Drawing.Size(261, 73);
            this.grpParametreler.TabIndex = 2;
            this.grpParametreler.TabStop = false;
            this.grpParametreler.Text = "Parametreler";
            // 
            // lblSaniye
            // 
            this.lblSaniye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaniye.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(6, 45);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(123, 20);
            this.lblSaniye.TabIndex = 1;
            this.lblSaniye.Text = "Süre (SN) =";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayinSayisi
            // 
            this.lblMayinSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMayinSayisi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMayinSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayinSayisi.Location = new System.Drawing.Point(6, 21);
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Size = new System.Drawing.Size(123, 18);
            this.lblMayinSayisi.TabIndex = 1;
            this.lblMayinSayisi.Text = "Mayın Sayısı = ";
            this.lblMayinSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericSure
            // 
            this.numericSure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSure.Location = new System.Drawing.Point(135, 45);
            this.numericSure.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericSure.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSure.Name = "numericSure";
            this.numericSure.Size = new System.Drawing.Size(120, 20);
            this.numericSure.TabIndex = 0;
            this.numericSure.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericMayin
            // 
            this.numericMayin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericMayin.Location = new System.Drawing.Point(135, 19);
            this.numericMayin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericMayin.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericMayin.Name = "numericMayin";
            this.numericMayin.Size = new System.Drawing.Size(120, 20);
            this.numericMayin.TabIndex = 0;
            this.numericMayin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 240);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblSoru1
            // 
            this.lblSoru1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoru1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoru1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoru1.Location = new System.Drawing.Point(6, 16);
            this.lblSoru1.Name = "lblSoru1";
            this.lblSoru1.Size = new System.Drawing.Size(263, 43);
            this.lblSoru1.TabIndex = 0;
            this.lblSoru1.Text = "SORU - 1";
            this.lblSoru1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpArmstrong
            // 
            this.grpArmstrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpArmstrong.Controls.Add(this.btnArmstrongBul);
            this.grpArmstrong.Controls.Add(this.lblArmstrong);
            this.grpArmstrong.Controls.Add(this.listBox);
            this.grpArmstrong.Controls.Add(this.txtUstSinir);
            this.grpArmstrong.Controls.Add(this.txtAltSinir);
            this.grpArmstrong.Controls.Add(this.lblA3);
            this.grpArmstrong.Controls.Add(this.lblA2);
            this.grpArmstrong.Controls.Add(this.lblA1);
            this.grpArmstrong.Controls.Add(this.lblSoru2);
            this.grpArmstrong.Location = new System.Drawing.Point(309, 12);
            this.grpArmstrong.Name = "grpArmstrong";
            this.grpArmstrong.Size = new System.Drawing.Size(251, 435);
            this.grpArmstrong.TabIndex = 1;
            this.grpArmstrong.TabStop = false;
            this.grpArmstrong.Text = "Armstrong Sayısı";
            // 
            // btnArmstrongBul
            // 
            this.btnArmstrongBul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArmstrongBul.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnArmstrongBul.Location = new System.Drawing.Point(143, 332);
            this.btnArmstrongBul.Name = "btnArmstrongBul";
            this.btnArmstrongBul.Size = new System.Drawing.Size(101, 35);
            this.btnArmstrongBul.TabIndex = 5;
            this.btnArmstrongBul.Text = "BUL";
            this.btnArmstrongBul.UseVisualStyleBackColor = false;
            this.btnArmstrongBul.Click += new System.EventHandler(this.btnArmstrongBul_Click);
            // 
            // lblArmstrong
            // 
            this.lblArmstrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmstrong.BackColor = System.Drawing.Color.SlateGray;
            this.lblArmstrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArmstrong.Location = new System.Drawing.Point(10, 373);
            this.lblArmstrong.Name = "lblArmstrong";
            this.lblArmstrong.Size = new System.Drawing.Size(234, 50);
            this.lblArmstrong.TabIndex = 4;
            this.lblArmstrong.Text = "Armstrong Sayısı";
            this.lblArmstrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(10, 194);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(127, 173);
            this.listBox.TabIndex = 3;
            // 
            // txtUstSinir
            // 
            this.txtUstSinir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUstSinir.Location = new System.Drawing.Point(137, 163);
            this.txtUstSinir.Name = "txtUstSinir";
            this.txtUstSinir.Size = new System.Drawing.Size(108, 20);
            this.txtUstSinir.TabIndex = 2;
            this.txtUstSinir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltSinir_KeyPress);
            // 
            // txtAltSinir
            // 
            this.txtAltSinir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAltSinir.Location = new System.Drawing.Point(10, 163);
            this.txtAltSinir.Name = "txtAltSinir";
            this.txtAltSinir.Size = new System.Drawing.Size(108, 20);
            this.txtAltSinir.TabIndex = 2;
            this.txtAltSinir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltSinir_KeyPress);
            // 
            // lblA3
            // 
            this.lblA3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA3.Location = new System.Drawing.Point(137, 127);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(108, 27);
            this.lblA3.TabIndex = 1;
            this.lblA3.Text = "Üst Sınır";
            this.lblA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA2
            // 
            this.lblA2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA2.Location = new System.Drawing.Point(10, 127);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(108, 27);
            this.lblA2.TabIndex = 1;
            this.lblA2.Text = "Alt Sınır";
            this.lblA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA1
            // 
            this.lblA1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA1.Location = new System.Drawing.Point(10, 71);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(234, 44);
            this.lblA1.TabIndex = 1;
            this.lblA1.Text = "- SAYI -";
            this.lblA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoru2
            // 
            this.lblSoru2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoru2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoru2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoru2.Location = new System.Drawing.Point(6, 16);
            this.lblSoru2.Name = "lblSoru2";
            this.lblSoru2.Size = new System.Drawing.Size(239, 43);
            this.lblSoru2.TabIndex = 0;
            this.lblSoru2.Text = "SORU - 2";
            this.lblSoru2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 464);
            this.Controls.Add(this.grpArmstrong);
            this.Controls.Add(this.grpMayin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vize - 2020 | Onur Cem ERDOĞAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMayin.ResumeLayout(false);
            this.grpParametreler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMayin)).EndInit();
            this.grpArmstrong.ResumeLayout(false);
            this.grpArmstrong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpMayin;
        public System.Windows.Forms.Button btnMayinBasla;
        public System.Windows.Forms.Label lblSure;
        public System.Windows.Forms.GroupBox grpParametreler;
        public System.Windows.Forms.NumericUpDown numericSure;
        public System.Windows.Forms.NumericUpDown numericMayin;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblSoru1;
        public System.Windows.Forms.GroupBox grpArmstrong;
        public System.Windows.Forms.Label lblSoru2;
        public System.Windows.Forms.Label lblSaniye;
        public System.Windows.Forms.Label lblMayinSayisi;
        public System.Windows.Forms.Button btnArmstrongBul;
        public System.Windows.Forms.Label lblArmstrong;
        public System.Windows.Forms.ListBox listBox;
        public System.Windows.Forms.TextBox txtUstSinir;
        public System.Windows.Forms.TextBox txtAltSinir;
        public System.Windows.Forms.Label lblA3;
        public System.Windows.Forms.Label lblA2;
        public System.Windows.Forms.Label lblA1;
        public System.Windows.Forms.Timer timerSure;

    }
}

