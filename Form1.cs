using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa5Ahumada
{
    public partial class frmEtapa5 : Form
    {
        public frmEtapa5()
        {
            InitializeComponent();
        }

        //Creo las clases, un randomizador y un pct para las imagenes

        clsVehiculo objAuto = new clsVehiculo();
        clsVehiculo objAvion = new clsVehiculo();
        clsVehiculo objBarco = new clsVehiculo();

        Random rnd = new Random();

        private PictureBox imagenAleatoria;

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int indiceAleatorio = rnd.Next(1, 4);
            // Elimina el pct si ya hay uno existente en pantalla
            if (Controls.Contains(imagenAleatoria))
            {
                Controls.Remove(imagenAleatoria);
                imagenAleatoria.Dispose();
            }

            switch (indiceAleatorio)
            {
                case 1:
                    objAuto.crearAuto();
                    objAuto.Auto.Location = new Point(400, 500);
                    imagenAleatoria = objAuto.Auto;

                    break;

                case 2:
                    objAvion.crearAvion();
                    objAvion.Avion.Location = new Point(200, 100);
                    imagenAleatoria = objAvion.Avion;

                    break;

                case 3:
                    objBarco.crearBarco();
                    objBarco.Barco.Location = new Point(300, 350);
                    imagenAleatoria = objBarco.Barco;

                    break;
            }
            Controls.Add(imagenAleatoria);

        }
    }
}
