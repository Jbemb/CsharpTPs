﻿using System;
using System.Collections.Generic;
using System.Text;
using tweet.model;

namespace tweet.service
{
    public class TwitterService : ITwitterService
    {
        public bool Authenticate(string user, string password)
        {   
            Boolean isValid = false;
            if (user.Equals("janet") && password.Equals("winner")) 
            {
                isValid = true;
            }
            return isValid;
        }

       

        public List<Tweet> GetTweets()
        {
            List<Tweet> tweets = new List<Tweet>();
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "1", userId = "1", userName = "janet", userPseudo = "@jj", text="opopopopopopopooooooooooooooooooooooooooooooooooooooooqsdfqdfqdffq" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "2", userId = "2", userName = "Kenan", userPseudo = "@kk", text = "jkljkljkkkkkkkkkkkkllllllllllllllllllllllllllllllllllllllqsdfqdfqdffqqsdfqsdfqdsf" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "3", userId = "2", userName = "Kenan", userPseudo = "@kk", text = "q'''''''''''hjjjjjjjjjjjjjjhfffffffffffffffffffsdfqdfqdffqertytyuhu" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "4", userId = "2", userName = "Karen", userPseudo = "@kiki", text = "fdddddddddddddddddddyyyyyyyyzerytzertzrtrtqsdfqdfqdffq" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "5", userId = "3", userName = "julie", userPseudo = "@jojo", text = "hhhhhhhhhhhhhhhhhhhhhfsdfguiuyqsdfqdfqdffq" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "6", userId = "1", userName = "janet", userPseudo = "@jj", text = "bbbbbbbbbbbbbbbbbvb,vbn,vbn,vbn,vbn,vbn,vbn,vbn,vbn,vbn,vbn,vbn,qssdfgsdfgsdfgdfqdfqdffq" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "7", userId = "1", userName = "jan", userPseudo = "@jaja", text = "nnnnnnnnnnnnnnnnnyuituioyipuyiopyuioyuioyuioyuioqsdyuituyityuiuituiuifqdfqdffq" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "8", userId = "1", userName = "janet", userPseudo = "@jj", text = "azerretzertreqsdfqdfqdffq" });
            tweets.Add(new Tweet() { dateCreation = DateTime.Today, identifiant = "9", userId = "1", userName = "janet", userPseudo = "@jj", text = "azertjklhkjljklklqsdfqdfqdffq" });
            return tweets;
        }

        
    }
}
