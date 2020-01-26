using AdamPhones.Core.Helpers;
using AdamPhones.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdamPhones
{
    class Program
    {
       
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Please start typing..");
            char? inputChar;

            do
            {
                inputChar = Console.ReadKey().KeyChar;
                SearchHelper.InputChecks(ref inputChar, ref sb);

                var stationList = Stations.GetStations();

                var currentSearchedStations = SearchHelper.SearchForStation(sb.ToString().ToLower(), stationList);

                currentSearchedStations.ForEach(Console.WriteLine);
            } while (inputChar != '!');



            //TweetHelper.blurb = " Some Blurb";
            //TweetHelper.hashtag = " Developers, Engineers";
            //TweetHelper.url = " Some urls";

            

            //var builtString = TweetHelper.CheckTweetLenght("This is a test tweet");

        }
    }
}
