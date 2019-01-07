using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using App12.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Movie> _lstMovies = null;
        public MainPage()
        {
            this.InitializeComponent();
       
        }

        private async void SearchMovie_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            _lstMovies = new List<Movie>();

            lstMovies.Items.Clear();
            HttpClient _web = new HttpClient();
           String _Movies =  await _web.GetStringAsync("http://www.omdbapi.com/?s="+args.QueryText+"&apikey=6ff571af");
            JsonObject _jsonMovie = JsonObject.Parse(_Movies);
           JsonArray _jsonArray =  _jsonMovie["Search"].GetArray();
            foreach (JsonValue item in _jsonArray)
            {
                // lstMovies.Items.Add(item.GetObject().GetNamedString("Title").ToString());
                _lstMovies.Add(new Movie { Title = item.GetObject().GetNamedString("Title").ToString(),
                    Year = item.GetObject().GetNamedString("Year").ToString(),
                    Poster = new BitmapImage(new Uri(item.GetObject().GetNamedString("Poster").ToString()))

                });
            }
            mvColectionSource.Source = _lstMovies;
        }
    }
}
