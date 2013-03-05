namespace Xemio.SpriteFontGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mFile = new System.Windows.Forms.MenuItem();
            this.mOpen = new System.Windows.Forms.MenuItem();
            this.mSave = new System.Windows.Forms.MenuItem();
            this.mView = new System.Windows.Forms.MenuItem();
            this.mZoom50 = new System.Windows.Forms.MenuItem();
            this.mZoom100 = new System.Windows.Forms.MenuItem();
            this.mZoom200 = new System.Windows.Forms.MenuItem();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.cbxFonts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nbxSpacing = new System.Windows.Forms.NumericUpDown();
            this.nbxKerning = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nbxSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbxSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxKerning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxSize)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mFile,
            this.mView});
            // 
            // mFile
            // 
            this.mFile.Index = 0;
            this.mFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mOpen,
            this.mSave});
            this.mFile.Text = "File";
            // 
            // mOpen
            // 
            this.mOpen.Index = 0;
            this.mOpen.Text = "Open";
            // 
            // mSave
            // 
            this.mSave.Index = 1;
            this.mSave.Text = "Save";
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // mView
            // 
            this.mView.Index = 1;
            this.mView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mZoom50,
            this.mZoom100,
            this.mZoom200});
            this.mView.Text = "View";
            // 
            // mZoom50
            // 
            this.mZoom50.Index = 0;
            this.mZoom50.Text = "50%";
            // 
            // mZoom100
            // 
            this.mZoom100.Index = 1;
            this.mZoom100.Text = "100%";
            // 
            // mZoom200
            // 
            this.mZoom200.Index = 2;
            this.mZoom200.Text = "200%";
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.previewPanel.Location = new System.Drawing.Point(0, 119);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(350, 130);
            this.previewPanel.TabIndex = 0;
            // 
            // cbxFonts
            // 
            this.cbxFonts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFonts.FormattingEnabled = true;
            this.cbxFonts.Location = new System.Drawing.Point(15, 25);
            this.cbxFonts.Name = "cbxFonts";
            this.cbxFonts.Size = new System.Drawing.Size(244, 21);
            this.cbxFonts.TabIndex = 2;
            this.cbxFonts.SelectedIndexChanged += new System.EventHandler(this.cbxFonts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Font:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spacing:";
            // 
            // nbxSpacing
            // 
            this.nbxSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nbxSpacing.Location = new System.Drawing.Point(15, 76);
            this.nbxSpacing.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nbxSpacing.Name = "nbxSpacing";
            this.nbxSpacing.Size = new System.Drawing.Size(172, 22);
            this.nbxSpacing.TabIndex = 5;
            this.nbxSpacing.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbxSpacing.ValueChanged += new System.EventHandler(this.nbxSpacing_ValueChanged);
            // 
            // nbxKerning
            // 
            this.nbxKerning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbxKerning.Location = new System.Drawing.Point(193, 76);
            this.nbxKerning.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbxKerning.Name = "nbxKerning";
            this.nbxKerning.Size = new System.Drawing.Size(141, 22);
            this.nbxKerning.TabIndex = 7;
            this.nbxKerning.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nbxKerning.ValueChanged += new System.EventHandler(this.nbxKerning_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kerning:";
            // 
            // nbxSize
            // 
            this.nbxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbxSize.Location = new System.Drawing.Point(265, 26);
            this.nbxSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nbxSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbxSize.Name = "nbxSize";
            this.nbxSize.Size = new System.Drawing.Size(69, 22);
            this.nbxSize.TabIndex = 9;
            this.nbxSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nbxSize.ValueChanged += new System.EventHandler(this.nbxSize_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Size:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 249);
            this.Controls.Add(this.nbxSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nbxKerning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nbxSpacing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFonts);
            this.Controls.Add(this.previewPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XGL SpriteFont Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbxSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxKerning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mFile;
        private System.Windows.Forms.MenuItem mOpen;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.MenuItem mView;
        private System.Windows.Forms.MenuItem mZoom50;
        private System.Windows.Forms.MenuItem mZoom100;
        private System.Windows.Forms.MenuItem mZoom200;
        private System.Windows.Forms.ComboBox cbxFonts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbxSpacing;
        private System.Windows.Forms.NumericUpDown nbxKerning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuItem mSave;
        private System.Windows.Forms.NumericUpDown nbxSize;
        private System.Windows.Forms.Label label5;
    }
}

