using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using Xemio.SpriteFontGenerator.Scenes;
using Xemio.GameLibrary;
using Xemio.GameLibrary.Game;
using Xemio.GameLibrary.Rendering.Fonts.Utility;

namespace Xemio.SpriteFontGenerator
{
    public partial class MainForm : Form
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the surface handle.
        /// </summary>
        public IntPtr SurfaceHandle
        {
            get { return this.previewPanel.Handle; }
        }
        /// <summary>
        /// Gets the font scene.
        /// </summary>
        public FontScene FontScene
        {
            get
            { 
                SceneManager sceneManager = XGL.GetComponent<SceneManager>();
                Scene scene = sceneManager.GetScene(s => s is FontScene);

                return scene as FontScene;
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Load event of the MainForm.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                this.cbxFonts.Items.Add(family.Name);
            }

            this.cbxFonts.SelectedIndex = this.cbxFonts.Items.IndexOf("Segoe UI");
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbxFonts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cbxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FontScene.FontFamily = cbxFonts.SelectedItem.ToString();
        }
        /// <summary>
        /// Handles the ValueChanged event of the nbxSize control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void nbxSize_ValueChanged(object sender, EventArgs e)
        {
            this.FontScene.Size = (int)nbxSize.Value;
        }
        /// <summary>
        /// Handles the ValueChanged event of the nbxSpacing control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void nbxSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.FontScene.Spacing = (int)nbxSpacing.Value;
        }
        /// <summary>
        /// Handles the ValueChanged event of the nbxKerning control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void nbxKerning_ValueChanged(object sender, EventArgs e)
        {
            this.FontScene.Kerning = (int)nbxKerning.Value;
        }
        /// <summary>
        /// Handles the Click event of the mSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void mSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                fileDialog.Filter = "SpriteFont (*.sf)|*.sf";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    SpriteFontSerializer.Save(this.FontScene.Font, fileDialog.FileName);
                }
            }
        }
        #endregion
    }
}
