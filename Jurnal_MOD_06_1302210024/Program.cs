using Jurnal_MOD_06_1302210024;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            //1
            SayaTubeVideo Video = new SayaTubeVideo("The Perks of Being A Wallflower");
            Video.IncreasePlayCount(10);
            Video.PrintVideoDetails();

            //2
            SayaTubeVideo Video2 = new SayaTubeVideo("The Breakfast Club");
            Video2.IncreasePlayCount(5);
            Video2.PrintVideoDetails();

            //3
            SayaTubeVideo Video3 = new SayaTubeVideo("School of Rock");
            Video3.IncreasePlayCount(1);
            Video3.PrintVideoDetails();

            //4
            SayaTubeVideo Video4 = new SayaTubeVideo("The Fault in Our Stars");
            Video4.IncreasePlayCount(20);
            Video4.PrintVideoDetails();

            //5
            SayaTubeVideo Video5 = new SayaTubeVideo("King of Carrot Flower Pt.1");
            Video5.IncreasePlayCount(15);
            Video5.PrintVideoDetails();

            //6
            SayaTubeVideo Video6 = new SayaTubeVideo("King of Carrot Flower Pt.2");
            Video6.IncreasePlayCount(15);
            Video6.PrintVideoDetails();

            //7
            SayaTubeVideo Video7 = new SayaTubeVideo("King of Carrot Flower Pt.3");
            Video7.IncreasePlayCount(15);
            Video7.PrintVideoDetails();

            //8
            SayaTubeVideo Video8 = new SayaTubeVideo("Overlord");
            Video8.IncreasePlayCount(2);
            Video8.PrintVideoDetails();

            //9
            SayaTubeVideo Video9 = new SayaTubeVideo("Death by Dignity");
            Video9.IncreasePlayCount(10);
            Video9.PrintVideoDetails();

            //10
            SayaTubeVideo Video10 = new SayaTubeVideo("Call Me By Your Name");
            Video10.IncreasePlayCount(100);
            Video10.PrintVideoDetails();
            
            Console.WriteLine(" ");

            SayaTubeUser user = new SayaTubeUser("Habli");

            user.AddVideo(Video);
            user.AddVideo(Video2);
            user.AddVideo(Video3);
            user.AddVideo(Video4);
            user.AddVideo(Video5);
            user.AddVideo(Video6);
            user.AddVideo(Video7);
            user.AddVideo(Video8);
            user.AddVideo(Video9);
            user.AddVideo(Video10);
            user.PrintAllVideoPlayCount();
            Console.WriteLine("Total Play Count Semua Film : " + user.GetTotalVideoPlayCount());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
