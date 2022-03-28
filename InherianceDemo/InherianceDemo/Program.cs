using System;
using System.Timers;

namespace InherianceDemo
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
           Post post1 = new Post("Thanks for the birthday wished", true, "Xiaoguang");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost(" Check out my new shoes", "Xiaoguang ","https:// image.com/shoes",true);

            Console.WriteLine(imagePost1.ToString());


            VideoPost videoPost1 = new VideoPost("Zhong Li kills all enemies in Genshin Impact!", "Xiaoguang", true, "https://www.annnew.com", 10086);

          

           
        }
       

    }
}
