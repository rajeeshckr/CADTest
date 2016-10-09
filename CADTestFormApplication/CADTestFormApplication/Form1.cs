using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CADImport;

namespace CADTestFormApplication
{
    public partial class Form1 : Form
    {
        CADImage _cadImage;

        public Form1()
        {

            InitializeComponent();
            string path = @"C:\Users\Rajeesh\Documents\CAD .NET 11\Files\123.dxf";
            _cadImage = CADImage.CreateImageByExtension(path);
            _cadImage.LoadFromFile(path);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (_cadImage != null)
            {
                RectangleF R;
                R = new RectangleF(0, 0, 500, 500);
                R.Height = (float)(R.Width * _cadImage.Extents.Height /
                _cadImage.Extents.Width);
                // width of image is 500, height depends on height/width of the drawing
                _cadImage.Draw(e.Graphics, R);
            }

        }
    }
}
