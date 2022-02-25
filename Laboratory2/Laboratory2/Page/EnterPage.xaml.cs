using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratory2.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterPage : ContentPage
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void BtnRestorePassword_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Восстновление пароля", "Данная функция в разработке", "ОК");
        }

        private void BtnRegistration_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Регистрация", "Данная функция в разработке", "ОК");
        }

        private void BtnEnter_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Вход", "Данная функция в разработке", "ОК");
        }
    }
}