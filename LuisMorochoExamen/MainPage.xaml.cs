using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LuisMorochoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnlogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;


            if (txtUser.Text.Equals("estudiante2020") && txtPass.Text.Equals("uisrael2020"))
            {
                await Navigation.PushAsync(new Registro(user,pass));

            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Credenciales incorrectas", "Reintentar");
            }
        }
    }
}
