using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BryanArmasLoyaga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        
        public Registro(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = "Bienvenido " + user + " código " + pass;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            const int valor = 3000;
            const double interes = 0.05;
            double montoInicial=0;
            if (double.Parse(txtCuota.Text) < valor)
            {
                montoInicial = double.Parse(txtCuota.Text);
                double diferencia = valor - montoInicial;
                double cuotaSinInteres = (diferencia / 5);
                double cuota = cuotaSinInteres + (valor * interes);
                txtPago.Text = cuota.ToString();
            }
            else
            {
                DisplayAlert("Error", "ingrese un valor menor a 3000","ok");
            }
            
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            double montoInicial = double.Parse(txtCuota.Text);
            double cuotaMensual = double.Parse(txtPago.Text);
            string variablesIniciales = lblUser.Text;

            if (!string.IsNullOrEmpty(nombre) && montoInicial != null && cuotaMensual != null)
            {
                DisplayAlert("Guardado ","con exito","Ok");
                await Navigation.PushAsync(new Resumen(nombre, montoInicial, cuotaMensual, variablesIniciales));
            }

            
        }
    }
}