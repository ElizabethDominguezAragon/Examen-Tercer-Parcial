using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_3_Impares_y_Pares
{
    public partial class ImparesPares : Form
    {
        public ImparesPares()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            int nbase = Environment.TickCount;
            Random aleatorio = new Random(nbase); 
           
            int Numero;
            ListTodos.Items.Clear(); ListPares.Items.Clear(); ListImpares.Items.Clear();
            for (int i = 1; i <= 30; i++)
            {
                //Crear 30 numeros Ranmon entre 25 y 180
                Numero = aleatorio.Next(25, 180);
                ListTodos.Items.Add(i + ": " + Numero);
                // separarlos por par o impar
                if (Numero % 2 == 0){
                    ListPares.Items.Add(i + ": " + Numero);
                }else{
                    ListImpares.Items.Add(i + ": " + Numero);
                }
            }
        }
    }
}
