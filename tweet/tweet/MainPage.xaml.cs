using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tweet.model;
using tweet.service;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tweet
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private const string LOGIN_ERROR = "Please enter an id at least 3 characters long.";
        private const string PASSWORD_ERROR = "Please enter password at least 6 characters long.";
        private const string INCORRECT_ERROR = "Your password and/or user name are incorrect.";

        public MainPage()
        {
            InitializeComponent();
            this.connecter.Clicked += Connecter_Clicked;
            var current = Connectivity.NetworkAccess;
            if (current != NetworkAccess.Internet)
            {
                this.error.Text = "Connect to internet to sign in";
                this.error.IsVisible = true;
            }
        }

        private void Connecter_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Connection is clicked");
            var id = this.Identifiant.Text;
            var mdp = this.Password.Text;
            var remember = this.RememberMe.IsToggled;
            var testLogin = true;
            var testPassword = true;
            Boolean isConnected = false;
            TwitterService tService = new TwitterService();
            StringBuilder builder = new StringBuilder();

            if(String.IsNullOrEmpty(id) || id.Length < 3) 
            {
                testLogin = false;
                builder.Append(LOGIN_ERROR);
            }
            if (String.IsNullOrEmpty(mdp) || mdp.Length < 6)
            {
                testPassword = false;
                if (!testLogin) 
                {
                    builder.Append("\n");
                }
                builder.Append(PASSWORD_ERROR);
                
            }

            if(testPassword && testLogin)
            {
                isConnected = tService.Authenticate(id, mdp);
                if (!isConnected) 
                {
                    builder.Append(INCORRECT_ERROR);
                }
            }

            if (isConnected) 
            {
                this.tweets.IsVisible = true;
                this.signIn.IsVisible = false;
                List<Tweet> tweetsFromData = tService.GetTweets();
            }
            else
            {
                this.error.Text = builder.ToString();
                this.error.IsVisible = true;
            }
        }
    }
}
