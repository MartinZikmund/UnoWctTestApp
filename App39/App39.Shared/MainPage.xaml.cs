using Microsoft.Toolkit.Collections;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App39
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public PhotoDataItem[] Pictures { get; set; } = new PhotoDataItem[]
            {
                new PhotoDataItem() {Title="A", Thumbnail = "ms-appx:///Assets/People/dave.png"},
                new PhotoDataItem() {Title="B", Thumbnail = "ms-appx:///Assets/People/david.png"},
                new PhotoDataItem() {Title="D", Thumbnail = "ms-appx:///Assets/People/dolphin.jpg"},
                new PhotoDataItem() {Title="G", Thumbnail = "ms-appx:///Assets/People/giorgio.png"},

            };

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            this.Loaded += MainPage_Loaded;

        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
        }

        public class PhotoDataItem
        {
            public string Title { get; set; }

            public string Category { get; set; }

            public string Thumbnail { get; set; }

            public override string ToString()
            {
                return Title;
            }
        }
    }
}
