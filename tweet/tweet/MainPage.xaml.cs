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
            Boolean isConnected = false;
            if(id == null || id.Length < 3) 
            {
                this.error.IsVisible = true;
                this.error.Text = ("Please enter an id at least 3 characters long.");
            }
            else if (mdp == null || mdp.Length < 6)
            {
                this.error.IsVisible = true;
                this.error.Text = ("Please enter password at least 6 characters long.");
            }else
            {
                this.error.IsVisible = false;
                this.error.Text = ("");
                isConnected = true;
            }

            if(isConnected == true) 
            {
                this.tweets.IsVisible = true;
                this.signIn.IsVisible = false;
            }
            

        }
    }
}
