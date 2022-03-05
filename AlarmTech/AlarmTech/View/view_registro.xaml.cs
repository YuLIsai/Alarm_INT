using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmTech.Model;
using AlarmTech.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlarmTech.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class view_registro : ContentPage
    {
        public view_registro()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new view_login());

        }

        private void bt_reg_Clicked(object sender, EventArgs e)
        {
            Usuario usu = new Usuario
            {
                Nombre = this.txtNombre.Text,
                Apellidos = this.txtNombre.Text,
                Correo_electronico = this.txtEmail.Text,
                contrasena = this.txtPass.Text

            };

            if (Registro.Registro_u(usu))
            {
                DisplayAlert("Listo", "Te has registrado correctamente", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "No se pudo registrar", "Aceptar");

            }
        }
    }
}