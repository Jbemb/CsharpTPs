using System;
using System.Collections.Generic;
using System.Text;

namespace tweet.model
{
    public class Tweet
    {
        public string identifiant { get; set; }
        public DateTime dateCreation { get; set; }
        public string text { get; set; }
        public string userName { get; set; }
        public string userId { get; set; }
        public string userPseudo { get; set; }
    }
}
