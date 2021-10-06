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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App39
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            this.Loaded += MainPage_Loaded;
            // Set up the original list with a few sample items
            var contacts = new[]
            {
    new Person { Name = "Staff" },
    new Person { Name = "Swan" },
    new Person { Name = "Orchid" },
    new Person { Name = "Flame" },
    new Person { Name = "Arrow" },
    new Person { Name = "Tempest" },
    new Person { Name = "Pearl" },
    new Person { Name = "Hydra" },
    new Person { Name = "Lamp Post" },
    new Person { Name = "Looking Glass" },
};

            // Group the contacts by first letter
            var grouped = contacts.GroupBy(g => g.Name[0]).OrderBy(g => g.Key);

            // Create an observable grouped collection
            var contactsSource = new ObservableGroupedCollection<char, Person>(grouped);

            // Set up the CollectionViewSource
            var cvs = new CollectionViewSource
            {
                IsSourceGrouped = true,
                Source = contactsSource,
            };

        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
        }

        public class Person
        {
            public string Name { get; set; }
        }

        public class Email
        {
            public string From { get; set; }

            public string Subject { get; set; }

            public string Body { get; set; }
        }

        public string[] LookupItems { get; } = new string[]
        {
            "Confirmation Code",
            "E-ticket number",
            "Mileage Plan number",
            "Unknown"
        };

        public List<Email> Emails { get; } = 
        new List<Email>
{
    new Email { From = "Steve Johnson", Subject = "Lunch Tomorrow", Body = "Are you available for lunch tomorrow? A client would like to discuss a project with you." },
    new Email { From = "Becky Davidson", Subject = "Kids game", Body = "Don't forget the kids have their soccer game this Friday. We have to supply end of game snacks." },
    new Email { From = "OneDrive", Subject = "Check out your event recap", Body = "Your new album.\r\nYou uploaded some photos to your OneDrive and automatically created an album for you." },
    new Email { From = "Twitter", Subject = "Follow randomPerson, APersonYouMightKnow", Body = "Here are some people we think you might like to follow:\r\n.@randomPerson\r\nAPersonYouMightKnow" },
};


    }
}
