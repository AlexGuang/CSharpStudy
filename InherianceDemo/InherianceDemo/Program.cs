using System;
using System.Timers;

namespace InherianceDemo
{
    
    internal class Program
    {
        public static int spaceStatus = 0;
        static void Main(string[] args)
        {
           //Post post1 = new Post("Thanks for the birthday wished", true, "Xiaoguang");
           // Console.WriteLine(post1.ToString());

           // ImagePost imagePost1 = new ImagePost(" Check out my new shoes", "Xiaoguang ","https:// image.com/shoes",true);

           // Console.WriteLine(imagePost1.ToString());


            VideoPost videoPost1 = new VideoPost("Zhong Li kills all enemies in Genshin Impact!", "Xiaoguang", true, "https://www.annnew.com", 10);


            //Console.WriteLine(videoPost1.ToString());
            Console.WriteLine("Please enter any key to start: ");
            while (videoPost1.currentPlaying < videoPost1.Length)
            {
                Console.ReadKey();
                switch (ChangeKeyStatus())
                {
                    case 0:
                        videoPost1.Play();
                        break;
                    case 1:
                        videoPost1.Stop();
                        break;
                    default:
                        break;
                }
            }
            
        }
       
        public static int ChangeKeyStatus()
        {
            
            if (spaceStatus == 0)
            {
                spaceStatus = 1;
                return spaceStatus;
            }
            else
            {
                spaceStatus = 0;
                return spaceStatus;
            }
        }

    }
}
