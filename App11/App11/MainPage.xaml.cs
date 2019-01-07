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
using App11.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App11
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Movie> _lstMovie = null;
        public MainPage()
        {
            this.InitializeComponent();
            _lstMovie = new List<Movie>();
        }

        private async void SearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            HttpClient _webClient = new HttpClient();
          String _Movie=  await  _webClient.GetStringAsync("http://www.omdbapi.com/?s="+args.QueryText+"&apikey=6ff571af");
            JsonObject _mJson = JsonObject.Parse(_Movie);
            JsonArray _JsonArray = _mJson["Search"].GetArray();
            foreach (JsonValue item in _JsonArray)
            {
                _lstMovie.Add(new Movie { Title = item.GetObject().GetNamedString("Title").ToString(), Year = item.GetObject().GetNamedString("Year").ToString() });
             //  lstMovies.Items.Add(item.GetObject().GetNamedString("Title").ToString());

            }
            //     txtMovieName.Text = _mJson.GetNamedString("Title").ToString();
            //    txtMovieDirector.Text = _mJson.GetNamedString("Director").ToString();
            lstMoveViewSource.Source = _lstMovie;
        }
    }
}
