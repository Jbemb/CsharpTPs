using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public MainPage()
        {
            InitializeComponent();
            this.connecter.Clicked += Connecter_Clicked;
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
            StringBuilder builder = new StringBuilder();

            if(String.IsNullOrEmpty(id) || id.Length < 3) 
            {
                testLogin = false;
                // this.error.Text = "Please enter an id at least 3 characters long.";
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
                // this.error.Text = "Please enter password at least 6 characters long.";
            }

            if(testPassword && testLogin)
            {
                isConnected = true;
                this.tweets.IsVisible = true;
                this.signIn.IsVisible = false;
            }else 
            {
                this.error.Text = builder.ToString();
                this.error.IsVisible = true;
            }

            //if(isConnected == true) 
            //{
            //    this.tweets.IsVisible = true;
            //    this.signIn.IsVisible = false;
            //}


        }
    }
}
