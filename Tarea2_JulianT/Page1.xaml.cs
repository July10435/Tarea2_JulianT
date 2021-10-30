using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_JulianT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void vtnIngresar_Clicked(object sender, EventArgs e)
        {
            String Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            if(Usuario=="Estudiante2021" && Contraseña == "UIsrael2021")
            {
                await Navigation.PushAsync(new MainPage(Usuario));
            }
        }
    }
}