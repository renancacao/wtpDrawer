namespace wtpDrawer
{
    partial class frmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nAltura = new System.Windows.Forms.NumericUpDown();
            this.nEscala = new System.Windows.Forms.NumericUpDown();
            this.bOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura mínima:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nEscala);
            this.groupBox1.Controls.Add(this.nAltura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportação";
            // 
            // nAltura
            // 
            this.nAltura.Location = new System.Drawing.Point(86, 30);
            this.nAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAltura.Name = "nAltura";
            this.nAltura.Size = new System.Drawing.Size(95, 20);
            this.nAltura.TabIndex = 3;
            this.nAltura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nEscala
            // 
            this.nEscala.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nEscala.Location = new System.Drawing.Point(86, 56);
            this.nEscala.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nEscala.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nEscala.Name = "nEscala";
            this.nEscala.Size = new System.Drawing.Size(95, 20);
            this.nEscala.TabIndex = 4;
            this.nEscala.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bOK
            // 
            this.bOK.Image = global::wtpDrawer.Properties.Resources.check;
            this.bOK.Location = new System.Drawing.Point(170, 138);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(30, 30);
            this.bOK.TabIndex = 3;
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 180);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEscala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nEscala;
        private System.Windows.Forms.NumericUpDown nAltura;
        private System.Windows.Forms.Button bOK;
    }
}