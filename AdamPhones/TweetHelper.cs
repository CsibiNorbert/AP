using System;
using System.Collections.Generic;
using System.Text;

namespace AdamPhones
{
    static class TweetHelper
    {
        public static string blurb = String.Empty;
        public static string url = String.Empty;
        public static string hashtag = String.Empty;

        public static string CheckTweetLenght(string str)
        {
            StringBuilder sb = new StringBuilder();

            if (str.Length > 240)
            {
                return "Lengths exceeds 240 characters";
            }

            return sb.AppendJoin(blurb + ", ", url + ", ", hashtag + ", ", str).ToString();
        }
    }
}
