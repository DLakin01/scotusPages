using System;
using System.Collections.Generic;
using System.Drawing;
namespace scotusPages
{
    public class ImageList
    {
        public static List<Tuple<string, string>> Images;

        public static void ListContainer()
        {
            Images = GetList();
        }

        public static List<Tuple<string, string>> GetList()
        {
            Images = new List<Tuple<string, string>>();

            Images.Add(new Tuple<string, string>("LGBTQ Rights", "images/LGBTQ_TedEytan.jpg"));
            Images.Add(new Tuple<string, string>("Gun Safety", "images/Guns_ClintSatterwhite.jpg"));
            Images.Add(new Tuple<string, string>("Corruption In Politics", "images/Bribery_Meiling.jpg"));
            Images.Add(new Tuple<string, string>("Healthcare and the ACA", "images/Healthcare_Waywuwei.jpg"));
            Images.Add(new Tuple<string, string>("Abortion and Reproductive Care", "images/WomensMarch.jpg"));
            Images.Add(new Tuple<string, string>("Voting Rights", "images/IVoted_JoeHall.jpg"));
            Images.Add(new Tuple<string, string>("Labor and Unions", "images/Labor_strike_RichardZinho.jpg"));
            Images.Add(new Tuple<string, string>("Inequality and Equal Pay", "images/Inequality_MichaelPanse.jpg"));
            Images.Add(new Tuple<string, string>("Social Media and Privacy", "images/SocialMedia_MarkKens.jpg"));

            return Images;
        }
    }
}
