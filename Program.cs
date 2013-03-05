using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Xemio.GameLibrary;
using Xemio.GameLibrary.Rendering.GDIPlus;
using Xemio.GameLibrary.Game;
using Xemio.SpriteFontGenerator.Scenes;

namespace Xemio.SpriteFontGenerator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();

            XGL.Initialize(new GDIGraphicsInitializer());
            XGL.Run(mainForm.SurfaceHandle, 350, 130, 5);

            SceneManager sceneManager = XGL.GetComponent<SceneManager>();
            sceneManager.Add(new FontScene());

            Application.Run(mainForm);
        }
    }
}
