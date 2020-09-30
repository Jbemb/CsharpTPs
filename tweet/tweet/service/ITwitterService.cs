using System;
using System.Collections.Generic;
using System.Text;
using tweet.model;

namespace tweet.service
{
    public interface ITwitterService
    {
        bool Authenticate(String user, String password);
        List<Tweet> GetTweets();
    }
}
