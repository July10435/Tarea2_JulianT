using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2_JulianT
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            try
            {
                double SeguimientoUno = Convert.ToDouble(txtS1.Text);
                double ExamenUno = Convert.ToDouble(txtE1.Text);

                double N1 = SeguimientoUno * 0.3;
                double E1 = ExamenUno * 0.2;

                double suma = N1 + E1;
                txtPa1.Text = Convert.ToString(suma);

                double SeguimientoDos = Convert.ToDouble(txtS2.Text);
                double ExamenDos = Convert.ToDouble(txtE2.Text);

                double N2 = SeguimientoDos * 0.3;
                double E2 = ExamenDos * 0.2;

                double suma2 = N2 + E2;
                txtPa2.Text = Convert.ToString(suma2);

                double NotaFinal = suma + suma2;
                txtNf.Text = Convert.ToString(NotaFinal);

                if (NotaFinal >= 7)
                {
                    txtEstado.Text = Convert.ToString("Aprobado");
                }
                else
                {
                    txtEstado.Text = Convert.ToString("Reprobado");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }
        }
    }
}
