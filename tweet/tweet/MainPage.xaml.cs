using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tweet.model;
using tweet.service;
using tweet.view;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tweet
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
  
        private ITwitterService tService = new TwitterService();
        public MainPage()
        {
            this.tService = new TwitterService(); ;
            InitializeComponent();
            


            LoadTweets();

        }

        private void LoadTweets()
        {
            
            foreach (Tweet item in tService.GetTweets()) 
            {
                tweets.Children.Add(new TweetList().LoadData(item));
            }
            
        }

       
    }
}
