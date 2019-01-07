using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Json;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppMovieFinder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void SearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            HttpClient _webClient =  new HttpClient();
          String _MoviesData = await  _webClient.GetStringAsync("http://www.omdbapi.com/?t="+args.QueryText+"&apikey=6ff571af");
            txtName.Text = _MoviesData;
            JsonObject _json = JsonObject.Parse(_MoviesData);
            String _response = _json.GetObject().GetNamedString("Response").ToString();
            if (_response == "True")
            {
                txtName.Text = _json.GetObject().GetNamedString("Title").ToString();

                String _poster = _json.GetObject().GetNamedString("Poster").ToString();
                if (_poster != "N/A")
                {
                    Uri _posterUri = new Uri(_poster);
                    BitmapImage bmp = new BitmapImage(_posterUri);
                    ImgPoster.Source = bmp;
                }
               else
                {

                    Uri _posterUri = new Uri("ms-appx://assets/No-image-available.jpg");
                    BitmapImage bmp = new BitmapImage(_posterUri);
                    ImgPoster.Source = bmp;
                }

            }
            else {
                txtName.Text = "No Movie found";
            }
        }
    }
}
