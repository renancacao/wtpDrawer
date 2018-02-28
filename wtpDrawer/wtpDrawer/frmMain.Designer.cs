namespace wtpDrawer
{
    partial class frmMain
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
            this.pCor = new System.Windows.Forms.Panel();
            this.pPaleta = new System.Windows.Forms.FlowLayoutPanel();
            this.menuModelo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelGrandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bConfig = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.bColors = new System.Windows.Forms.RadioButton();
            this.bOpen = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.pcCanvas = new System.Windows.Forms.PictureBox();
            this.bGrid = new System.Windows.Forms.CheckBox();
            this.bModelo = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bFill = new System.Windows.Forms.RadioButton();
            this.bPen = new System.Windows.Forms.RadioButton();
            this.menuModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pCor
            // 
            this.pCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCor.Location = new System.Drawing.Point(489, 12);
            this.pCor.Name = "pCor";
            this.pCor.Size = new System.Drawing.Size(50, 50);
            this.pCor.TabIndex = 5;
            this.pCor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pCor_MouseDoubleClick);
            // 
            // pPaleta
            // 
            this.pPaleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pPaleta.AutoScroll = true;
            this.pPaleta.Location = new System.Drawing.Point(489, 68);
            this.pPaleta.Margin = new System.Windows.Forms.Padding(0);
            this.pPaleta.Name = "pPaleta";
            this.pPaleta.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pPaleta.Size = new System.Drawing.Size(150, 344);
            this.pPaleta.TabIndex = 8;
            // 
            // menuModelo
            // 
            this.menuModelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelToolStripMenuItem,
            this.pixelGrandeToolStripMenuItem});
            this.menuModelo.Name = "menuModelo";
            this.menuModelo.Size = new System.Drawing.Size(140, 48);
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pixelToolStripMenuItem.Text = "Pixel";
            this.pixelToolStripMenuItem.Click += new System.EventHandler(this.pixelToolStripMenuItem_Click);
            // 
            // pixelGrandeToolStripMenuItem
            // 
            this.pixelGrandeToolStripMenuItem.Name = "pixelGrandeToolStripMenuItem";
            this.pixelGrandeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pixelGrandeToolStripMenuItem.Text = "Pixel Grande";
            this.pixelGrandeToolStripMenuItem.Click += new System.EventHandler(this.pixelGrandeToolStripMenuItem_Click);
            // 
            // bConfig
            // 
            this.bConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bConfig.Image = global::wtpDrawer.Properties.Resources.settings;
            this.bConfig.Location = new System.Drawing.Point(12, 468);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(30, 30);
            this.bConfig.TabIndex = 16;
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // bExport
            // 
            this.bExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExport.Image = global::wtpDrawer.Properties.Resources.exportimg;
            this.bExport.Location = new System.Drawing.Point(500, 468);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(30, 30);
            this.bExport.TabIndex = 15;
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bColors
            // 
            this.bColors.Appearance = System.Windows.Forms.Appearance.Button;
            this.bColors.Image = global::wtpDrawer.Properties.Resources.colors;
            this.bColors.Location = new System.Drawing.Point(358, 84);
            this.bColors.Name = "bColors";
            this.bColors.Size = new System.Drawing.Size(30, 30);
            this.bColors.TabIndex = 14;
            this.bColors.TabStop = true;
            this.bColors.UseVisualStyleBackColor = true;
            this.bColors.CheckedChanged += new System.EventHandler(this.bColors_CheckedChanged);
            // 
            // bOpen
            // 
            this.bOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpen.Image = global::wtpDrawer.Properties.Resources.folder;
            this.bOpen.Location = new System.Drawing.Point(572, 468);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(30, 30);
            this.bOpen.TabIndex = 13;
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Image = global::wtpDrawer.Properties.Resources.save;
            this.bSave.Location = new System.Drawing.Point(608, 468);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(30, 30);
            this.bSave.TabIndex = 12;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // pcCanvas
            // 
            this.pcCanvas.Location = new System.Drawing.Point(12, 12);
            this.pcCanvas.Name = "pcCanvas";
            this.pcCanvas.Size = new System.Drawing.Size(340, 400);
            this.pcCanvas.TabIndex = 0;
            this.pcCanvas.TabStop = false;
            this.pcCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcCanvas_MouseMove);
            this.pcCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcCanvas_MouseClick);
            // 
            // bGrid
            // 
            this.bGrid.Appearance = System.Windows.Forms.Appearance.Button;
            this.bGrid.Image = global::wtpDrawer.Properties.Resources.grid;
            this.bGrid.Location = new System.Drawing.Point(358, 120);
            this.bGrid.Name = "bGrid";
            this.bGrid.Size = new System.Drawing.Size(30, 30);
            this.bGrid.TabIndex = 9;
            this.bGrid.UseVisualStyleBackColor = true;
            this.bGrid.CheckedChanged += new System.EventHandler(this.cGrid_CheckedChanged);
            // 
            // bModelo
            // 
            this.bModelo.Image = global::wtpDrawer.Properties.Resources.pixel;
            this.bModelo.Location = new System.Drawing.Point(358, 156);
            this.bModelo.Name = "bModelo";
            this.bModelo.Size = new System.Drawing.Size(30, 30);
            this.bModelo.TabIndex = 10;
            this.bModelo.UseVisualStyleBackColor = true;
            this.bModelo.Click += new System.EventHandler(this.bModelo_Click);
            // 
            // bNew
            // 
            this.bNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNew.Image = global::wtpDrawer.Properties.Resources._new;
            this.bNew.Location = new System.Drawing.Point(536, 468);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(30, 30);
            this.bNew.TabIndex = 1;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bFill
            // 
            this.bFill.Appearance = System.Windows.Forms.Appearance.Button;
            this.bFill.Image = global::wtpDrawer.Properties.Resources.fill;
            this.bFill.Location = new System.Drawing.Point(358, 48);
            this.bFill.Name = "bFill";
            this.bFill.Size = new System.Drawing.Size(30, 30);
            this.bFill.TabIndex = 7;
            this.bFill.TabStop = true;
            this.bFill.UseVisualStyleBackColor = true;
            this.bFill.CheckedChanged += new System.EventHandler(this.pFill_CheckedChanged);
            // 
            // bPen
            // 
            this.bPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.bPen.Image = global::wtpDrawer.Properties.Resources.edit2;
            this.bPen.Location = new System.Drawing.Point(358, 12);
            this.bPen.Name = "bPen";
            this.bPen.Size = new System.Drawing.Size(30, 30);
            this.bPen.TabIndex = 4;
            this.bPen.TabStop = true;
            this.bPen.UseVisualStyleBackColor = true;
            this.bPen.CheckedChanged += new System.EventHandler(this.bPen_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 510);
            this.Controls.Add(this.bConfig);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bColors);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.pPaleta);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.pcCanvas);
            this.Controls.Add(this.pCor);
            this.Controls.Add(this.bGrid);
            this.Controls.Add(this.bModelo);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bFill);
            this.Controls.Add(this.bPen);
            this.Name = "frmMain";
            this.Text = "WTP Drawer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.menuModelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcCanvas;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.RadioButton bPen;
        private System.Windows.Forms.Panel pCor;
        private System.Windows.Forms.RadioButton bFill;
        private System.Windows.Forms.FlowLayoutPanel pPaleta;
        private System.Windows.Forms.CheckBox bGrid;
        private System.Windows.Forms.Button bModelo;
        private System.Windows.Forms.ContextMenuStrip menuModelo;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelGrandeToolStripMenuItem;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.RadioButton bColors;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bConfig;

    }
}

