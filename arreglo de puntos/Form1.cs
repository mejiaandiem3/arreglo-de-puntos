using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglo_de_puntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //arreglo para puntos
            /*Point[] puntos = {new Point (0,100),
                              new Point (50,80),
                              new Point (100,20),
                              new Point (150,80),
                              new Point (200,100)};

            //se inicializa los componentes
            Pen lapiz = new Pen(Color.White);
            Graphics papel = this.CreateGraphics();
            papel.DrawCurve(lapiz,puntos);

            //para hacer estrella se puede con un poligono*/

           


        }
    }
}
