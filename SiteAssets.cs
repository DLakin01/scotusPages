using System;
using System.Collections.Generic;
namespace scotusPages
{
    public class SiteAssets
    {
        public static List<Tuple<string, string, string>> GetImages()
        {
            var Images = new List<Tuple<string, string, string>>();

            Images.Add(new Tuple<string, string, string>("/lgbtqRights", "LGBTQ Rights", "images/LGBTQ_TedEytan.jpg"));
            Images.Add(new Tuple<string, string, string>("/inequality", "Inequality and Equal Pay", "images/Inequality_MichaelPanse.jpg"));
            Images.Add(new Tuple<string, string, string>("/corruptPolitics", "Corruption In Politics", "images/Bribery_Meiling.jpg"));
            Images.Add(new Tuple<string, string, string>("/healthcare", "Healthcare and the ACA", "images/Healthcare_Waywuwei.jpg"));
            Images.Add(new Tuple<string, string, string>("/reproductiveCare", "Abortion and Reproductive Care", "images/WomensMarch.jpg"));
            Images.Add(new Tuple<string, string, string>("/votingRights", "Voting Rights", "images/IVoted_JoeHall.jpg"));
            Images.Add(new Tuple<string, string, string>("/labor", "Labor and Unions", "images/Labor_strike_RichardZinho.jpg"));
            Images.Add(new Tuple<string, string, string>("/gunSafety", "Gun Safety", "images/Guns_ClintSatterwhite.jpg"));
            Images.Add(new Tuple<string, string, string>("/socialMedia", "Social Media and Privacy", "images/SocialMedia_MarkKens.jpg"));

            return Images;
        }

        public static List<Tuple<string, string, string>> GetResources() 
        {
            var Resources = new List<Tuple<string, string, string>>
            {
                {new Tuple<string, string, string>("/scotusToEnglish", "SCOTUS-to-English", "Translate the legal phrases used by the Supreme Court to more accessible language.")},
                {new Tuple<string, string, string>("/kavanaugh", "Who is Brett Kavanaugh?", "Learn more about the background and dangerous philosophy of Trump's nominee.")},
                {new Tuple<string, string, string>("/vote", "Speak Up and Vote", "Make sure you're registered to vote this November to make your voice heard.")},
                {new Tuple<string, string, string>("/learnMore", "Learn More", "Learn more about the Supreme Court and its impact on your life.")}
            };

            return Resources;
        }

    }
}
