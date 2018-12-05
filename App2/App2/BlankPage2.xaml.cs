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
using Windows.Storage.Pickers;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        FileOpenPicker fp = null;
        public BlankPage2()
        {
            this.InitializeComponent();
            fp = new FileOpenPicker();
            fp.FileTypeFilter.Add(".mp4");
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            var file = await fp.PickSingleFileAsync();
            if (file != null) {
                var strem = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                movieWindow.SetSource(strem, file.ContentType);
            }
        }
    }
}
