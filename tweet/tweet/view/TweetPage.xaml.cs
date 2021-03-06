﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using tweet.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tweet.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetPage : ContentPage
    {
        public ObservableCollection<Tweet> Items { get; set; }
        private service.ITwitterService tService = new service.TwitterService();
        public TweetPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Tweet>();
            foreach (Tweet item in tService.GetTweets())
            {
                Items.Add(item);
            }

            ListOfTweets.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
