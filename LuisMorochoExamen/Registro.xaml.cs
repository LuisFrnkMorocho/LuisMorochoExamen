using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LuisMorochoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();

            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;

        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUser.Text;
            string nombre = txtDato1.Text;
            double monto_inicial = Convert.ToDouble(txtDato2.Text);
            double resultado = 1800 - monto_inicial;
            double Pago_mensual = resultado / 3;
            double cancelar = Pago_mensual + Pago_mensual * 0.05;
            txtDato3.Text = cancelar.ToString();
            double Totalidad = monto_inicial + cancelar * 3;

            await Navigation.PushAsync(new Resumen(usuario, nombre, Totalidad));
            DisplayAlert("Informacion", "Elemento guardado con exito", "OK");

        }

     }
}