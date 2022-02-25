using Laboratory2.Page;
using Xamarin.Forms;

namespace Laboratory2
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new NewsPage())
            {
                BarBackgroundColor = Color.FromHex("#76E383"),
                BarTextColor = Color.FromHex("#000000")
            };
        }

        private void BtnEnter_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new EnterPage())
            {
                BarBackgroundColor = Color.FromHex("#76E383"),
                BarTextColor = Color.FromHex("#000000")
            };

            IsPresented = false;
        }

        private void BtnExit_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Выход", "Данная функция в разработке", "ОК");
        }

        private void BtnRegistration_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Регистрация", "Данная функция в разработке", "ОК");
        }

        private void BtnNews_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new NewsPage())
            {
                BarBackgroundColor = Color.FromHex("#76E383"),
                BarTextColor = Color.FromHex("#000000")

            };

            IsPresented = false;
        }

        private void BtnListOfServices_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new ServicesPage())
            {
                BarBackgroundColor = Color.FromHex("#76E383"),
                BarTextColor = Color.FromHex("#000000")
            };

            IsPresented = false;
        }

        private void BtnPersonalArea_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Личный кабинет", "Данная функция в разработке", "ОК");
        }
    }
}
