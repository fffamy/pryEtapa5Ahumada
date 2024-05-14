using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pryEtapa5Ahumada
{
    internal class clsVehiculo
    {
        public PictureBox Auto;
        public PictureBox Avion;
        public PictureBox Barco;
        public string tipoVehiculo;
        public void crearAuto()
        {
            Auto = new PictureBox();
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "auto.png");
            Auto.ImageLocation = ruta;
            Auto.SizeMode = PictureBoxSizeMode.Zoom;
            Auto.Size = new Size(100, 100);
            Auto.BackColor = Color.Transparent;
            tipoVehiculo = "Auto";
        }

        public void crearAvion()
        {
            Avion = new PictureBox();
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "avion.jpg");
            Avion.ImageLocation = ruta;
            Avion.SizeMode = PictureBoxSizeMode.Zoom;
            Avion.Size = new Size(100, 100);
            Avion.BackColor = Color.Transparent;
            tipoVehiculo = "Avion";
        }

        public void crearBarco()
        {
            Barco = new PictureBox();
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "barco.png");
            Barco.ImageLocation = ruta;
            Barco.SizeMode = PictureBoxSizeMode.Zoom;
            Barco.Size = new Size(120, 120);
            Barco.BackColor = Color.Transparent;
            tipoVehiculo = "Barco";
        }
    }
}
