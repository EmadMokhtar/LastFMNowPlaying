using System;
using Lastfm.Services;


namespace LastFMcurrentPlayingSongCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the API KEY & SECRET
            string apiKEY = "12730d06a96eaaf4d3efbdabb2d57ee6";
            string apiSECRET = "8667f8a101852ccac4a5a8562a5618b0";
            Session session = new Session(apiKEY, apiSECRET);

            //Set the user to EmadMokhtar (http://www.last.fm/user/emadmokhtar) 
            var user = new User("EmadMokhtar", session);

            //Get the now play from Last.FM
            string nowPlaying = user.GetNowPlaying().ToString();

            // Display The now playing track info
            Console.WriteLine(nowPlaying);
            Console.ReadLine();
        }
    }
}
