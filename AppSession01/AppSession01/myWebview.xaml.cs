using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppSession01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class myWebview : Page
    {
        
        public myWebview()
        {
            this.InitializeComponent();
        }

        private void SearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            String udata = args.QueryText.ToString();
            String[] prifixHttps = udata.Split('/');
            if (prifixHttps[0] == "https:")
            {
                myBrowser.Navigate(new Uri(udata));
                lstHistory.Items.Add(udata);
            }
            else
            {
                myBrowser.Navigate(new Uri(String.Concat("https://", udata)));
                lstHistory.Items.Add(String.Concat("https://", udata));

            }
        }

        private void lstHistory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            myBrowser.Navigate(new Uri(lstHistory.SelectedValue.ToString()));
            searchData.QueryText = lstHistory.SelectedValue.ToString();
        }
    }
}
