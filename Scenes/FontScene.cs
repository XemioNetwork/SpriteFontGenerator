using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xemio.GameLibrary.Game;
using Xemio.GameLibrary.Rendering.Fonts;

namespace Xemio.SpriteFontGenerator.Scenes
{
    using Utility = Xemio.GameLibrary.Rendering.Fonts.Utility;
    using Xemio.GameLibrary.Rendering;
    using Xemio.GameLibrary;
    using Xemio.GameLibrary.Math;

    public class FontScene : Scene
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="FontScene"/> class.
        /// </summary>
        public FontScene()
        {
            this.FontFamily = "Segoe UI";

            this.Spacing = 10;
            this.Kerning = -5;
            this.Size = 12;
        }
        #endregion

        #region Fields
        private bool _isDirty;

        private string _fontFamily;
        private int _size;

        private int _kerning;
        private int _spacing;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the font family.
        /// </summary>
        public string FontFamily
        {
            get { return this._fontFamily; }
            set
            {
                this._fontFamily = value;
                this._isDirty = true;
            }
        }
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public int Size
        {
            get { return this._size; }
            set
            {
                this._size = value;
                this._isDirty = true;
            }
        }
        /// <summary>
        /// Gets or sets the kerning.
        /// </summary>
        public int Kerning
        {
            get { return this._kerning; }
            set
            {
                this._kerning = value;
                this._isDirty = true;
            }
        }
        /// <summary>
        /// Gets or sets the spacing.
        /// </summary>
        public int Spacing
        {
            get { return this._spacing; }
            set
            {
                this._spacing = value;
                this._isDirty = true;
            }
        }
        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        public SpriteFont Font { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Ticks the specified elapsed.
        /// </summary>
        /// <param name="elapsed">The elapsed.</param>
        public override void Tick(float elapsed)
        {
            if (this._isDirty)
            {
                ITextureFactory factory = XGL.GetComponent<ITextureFactory>();

                try
                {
                    this.Font = Utility.SpriteFontGenerator.Create(factory, this.FontFamily, this.Size, Color.White);
                    this.Font.Kerning = this.Kerning;
                    this.Font.Spacing = this.Spacing;
                }
                catch
                {
                }
            }
        }
        /// <summary>
        /// Renders this instance.
        /// </summary>
        public override void Render()
        {
            this.Font.Render("The red fox jumps over the brown dog.", new Vector2(10, 10));
        }
        #endregion
    }
}
