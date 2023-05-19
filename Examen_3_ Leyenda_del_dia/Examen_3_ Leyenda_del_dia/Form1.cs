using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_3__Leyenda_del_dia
{
    public partial class LeyendaDia : Form
    {
        public LeyendaDia()
        {
            InitializeComponent();
        }

        private void LeyendaDia_Load(object sender, EventArgs e)
        {

        }

        private void DTP_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Forma corta

            string mensaje;
            mensaje = "La fecha seleccionada es " + DTP_fecha.Value.ToString("dd") 
                       + " del mes de " + DTP_fecha.Value.ToString("MMMM")
                       + " del año " + DTP_fecha.Value.ToString("yyyy");
            //Forma Larga
            mensaje = "La fecha seleccionada es " + DTP_fecha.Value.Day + " del mes de ";
            switch (DTP_fecha.Value.Month)
            {
                case 1:  mensaje += "Enero";     break;
                case 2:  mensaje += "Febrero";   break;
                case 3:  mensaje += "Marzo";     break;
                case 4:  mensaje += "Abril";     break;
                case 5:  mensaje += "Mayo";      break;
                case 6:  mensaje += "Junio";     break;
                case 7:  mensaje += "Julio";     break;
                case 8:  mensaje += "Agosto";    break;
                case 9:  mensaje += "Septiembre";break;
                case 10: mensaje += "Octubre";   break;
                case 11: mensaje += "Noviembre"; break;
                case 12: mensaje += "Diciembre"; break;
            }
            mensaje += " del año " + DTP_fecha.Value.Year;
            MessageBox.Show(mensaje);
        }
    }
}
