using CsvHelper;
using Laboratory2.Model;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratory2.Page
{

    public partial class ServicesPage : ContentPage
    {
        public ServicesPage()
        {
            InitializeComponent();

            GetServices();
        }

        public void GetServices()
        {
            var list = new List<ServicesModel>();
            var assembly = Assembly.GetExecutingAssembly();
            var resourcesName = "Laboratory2.Data.services.csv";

            using (Stream stream = assembly.GetManifestResourceStream(resourcesName))
            using (StreamReader reader = new StreamReader(stream))
            {
                if (reader != null)
                {
                    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                    {
                        while (csv.Read())
                        {
                            list.Add(new ServicesModel
                            {
                                Code = csv.GetField<string>(0),
                                Services = csv.GetField<string>(1),
                                Price = csv.GetField<string>(2)
                            });
                        }
                    }
                }
            }

            MyListView.ItemsSource = list;
        }
    }
}