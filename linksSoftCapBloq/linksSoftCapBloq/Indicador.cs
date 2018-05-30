using System;
using System.Windows.Forms;

namespace linksSoftCapBloq
{
    public partial class Indicador : Form
    {
        public Indicador()
        {
            Screen screen = Screen.PrimaryScreen;

            int width = screen.Bounds.Width;

            int height = screen.Bounds.Height;

            InitializeComponent();

            this.Location = new System.Drawing.Point(width - 150, height - 150 );
        }
    }
}
