using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Windows;

namespace WPFExhangeApiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
            const string API_KEY = "4a78e801032cc7b7401a97a80f2e2dbb";
            static string BASE_URL_LATEST = $"http://api.exchangeratesapi.io/v1/latest";
            static string URL_SYMBOLS = $"http://api.exchangeratesapi.io/v1/symbols";
            public void GetPrice()
            {
            var URL = new UriBuilder(BASE_URL_LATEST);
            var query = HttpUtility.ParseQueryString(string.Empty);

            query["access_key"] = API_KEY;

            string symbolsQuery = string.Empty;
            foreach(Coin coin in coins)
            {
                if (coin.check_status == true)
                {

                    symbolsQuery += $"{coin.symbol},";
                }
            }
            query["symbols"] = symbolsQuery;

            URL.Query = query.ToString();

            var client = new WebClient();
            client.Headers.Add("Accepts", "application/json");
            client.Headers.Add("Accept", "application/json");
            string json = client.DownloadString(URL.ToString());


            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            rateList.Items.Clear();


            List<dynamic> rates = new List<dynamic>();

            foreach (dynamic entry in data.rates)
            {
                {
                    
                    rates.Add(entry.Value);
                }


            }

            rateList.ItemsSource = rates;

        }
        public void GetSymbols()
            {

            var URL = new UriBuilder(URL_SYMBOLS);
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["access_key"] = API_KEY;
            URL.Query = query.ToString();

            var client = new WebClient();
            client.Headers.Add("Accepts", "application/json");
            client.Headers.Add("Accept", "application/json");
            string json = client.DownloadString(URL.ToString());


            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            coins = new List<Coin>();

            foreach (dynamic entry in data.symbols)
            {
                {
                    coins.Add(new Coin { symbol = entry.Name });
                }

                //information.Text = $"{coins}";

            }

            coinComboBox.ItemsSource = coins;

            BindListBox();
            GetPrice();
        }

        private void BindListBox()
        {
            informationList.Items.Clear();

            foreach (Coin coin in coins)
            { 
                if (coin.check_status == true)
                {
                    informationList.Items.Add(coin.symbol);
                }
            }
        }

        public List<Coin> coins = new List<Coin>();
        public static HttpClient APIClient { get; set; } = new HttpClient();



        public MainWindow()
        {
            InitializeComponent();

            GetSymbols();
            BindListBox();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetPrice();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            BindListBox();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            BindListBox();

        }
    }
}
