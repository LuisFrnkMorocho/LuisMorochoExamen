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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string nombre, double totalPago)
        {
            InitializeComponent();

            //muestra usuario conectado
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;

            //muestra el nombre
            string nombreUsuario = txtDato1.ToString();
            txtDato1.Text = nombre;

            //muestra el total a pagar
            string cuota = txtDato2.ToString();
            txtDato2.Text = totalPago.ToString(); ;

        }
    }
}