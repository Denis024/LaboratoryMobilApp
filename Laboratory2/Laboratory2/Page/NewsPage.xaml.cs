using Laboratory2.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratory2.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        private ObservableCollection<ContactModel> myrootobject;
        
        public NewsPage()
        {
            InitializeComponent();

            BindingContext = this;

            Get();
        }

        public void Get()
        {
            var assembly = typeof(NewsPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Laboratory2.Data.DataNews1.json");

            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                List<ContactModel> mylist = JsonConvert.DeserializeObject<List<ContactModel>>(json);
                myrootobject = new ObservableCollection<ContactModel>(mylist);
                MyListView.ItemsSource = myrootobject;
            }
        }

        private async void myList2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ContactModel selectedNews = e.Item as ContactModel;
            if (selectedNews != null)
                await DisplayAlert($"{selectedNews.Title}", $"{selectedNews.Text}", "OK");
        }
    }
}