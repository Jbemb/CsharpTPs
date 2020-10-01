using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tweet.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tweet.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetList : ContentView
    {
        public TweetList()
        {
            InitializeComponent();
        }

        internal View LoadData(Tweet tweet)
        {
            this.userId.Text = tweet.userPseudo;
            this.userName.Text = tweet.userName;
            this.date.Text = tweet.dateCreation.ToString();
            this.content.Text = tweet.text;
            return this;
                    
        }
    }
}