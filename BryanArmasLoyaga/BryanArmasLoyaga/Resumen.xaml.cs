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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double montoInicial, double cuotaMensual, string variables)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            double total = (cuotaMensual * 5);
            txtTotal.Text = (montoInicial + total).ToString();
            lblUser.Text = variables;
        }
    }
}