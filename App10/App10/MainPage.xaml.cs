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

namespace App10
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

        private async void SerMovie_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            HttpClient _webclient = new HttpClient();
            String _MovieJson = await _webclient.GetStringAsync("http://www.omdbapi.com/?t=" + args.QueryText + "&apikey=6ff571af");
            JsonObject _Movie = JsonObject.Parse(_MovieJson);
            txtTitle.Text = _Movie.GetObject().GetNamedString("Title").ToString();
            txtYear.Text = _Movie.GetObject().GetNamedString("Year").ToString();
            String _poster = _Movie.GetObject().GetNamedString("Poster").ToString();
            Uri _imgUri = new Uri(_poster);
            BitmapImage bmp = new BitmapImage(_imgUri);
            imgPoster.Source = bmp;

        }
        /*
         * HttpClient _webclient = new HttpClient();
            String _MovieJson =   await _webclient.GetStringAsync("http://www.omdbapi.com/?t="+ args.QueryText+"&apikey=6ff571af");
            JsonObject _Movie = JsonObject.Parse(_MovieJson);
            txtTitle.Text = _Movie.GetObject().GetNamedString("Title").ToString();
            txtYear.Text = _Movie.GetObject().GetNamedString("Year").ToString();
            String _poster = _Movie.GetObject().GetNamedString("Poster").ToString();
            Uri _imgUri = new Uri(_poster);
            BitmapImage bmp = new BitmapImage(_imgUri);
            imgPoster.Source = bmp;
         */
        /*
         *    HttpClient _webclient = new HttpClient();
           String _MovieJson =   await _webclient.GetStringAsync("http://www.omdbapi.com/?s="+ args.QueryText+"&apikey=6ff571af");
           JsonObject _Movie = JsonObject.Parse(_MovieJson);
           JsonArray _JsonArray = JsonArray.Parse(_Movie.GetObject().GetNamedString("Search").ToString());
           foreach (var item in _JsonArray)
           {
             JsonObject _js =  JsonObject.Parse(item.ToString());
           }*/
   }
}
