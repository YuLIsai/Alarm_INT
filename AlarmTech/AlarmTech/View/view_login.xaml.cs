using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmTech.Model;
using AlarmTech.View;
using AlarmTech.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlarmTech.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class view_login : ContentPage
    {
        public view_login()
        {
            InitializeComponent();
        }
        Model_auth auth = new Model_auth();
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new view_registro());
        }

        private void bt_login_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtemail.Text) && !string.IsNullOrEmpty(txtpass.Text))
            {
                if (auth.Authentication(txtemail.Text, txtpass.Text))
                {
                    Navigation.PushAsync(new view_perfil());
                }
            }
            else
            {
                DisplayAlert("Ocurrio un error en el email o contraseña:(", "No dejes vacio el campo de texto", "Ok");
            }
            
        }
    }
}