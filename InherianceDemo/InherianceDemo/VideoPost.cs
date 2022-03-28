using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace InherianceDemo
{
    internal class VideoPost : Post
    {
      
        public static Timer aTimer;
        public string VideoURL { get; set; }

        public int Length { get; set; }

        public bool isPlay { get; set; }

        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUser, bool isPublic, string videoURL, int length)
        {
            this.Title = title;
            this.Length = length;
            this.VideoURL = videoURL;
            this.ID = GetNextID();
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUser;
            this.isPlay = false;

        }


        public override string ToString()
        {
            return String.Format("{0} -  {1}, by {2},from {3}, length is {4}",this.ID,this.Title,this.SendByUsername,this.VideoURL, this.Length);
        }
        public void Play()
        {

            aTimer = new Timer();
            aTimer.Enabled = true;
            aTimer.Interval = 1;
            aTimer.Elapsed += new ElapsedEventHandler()
           
            aTimer.Start();

        }
        
        public void Stop()
        {
            if (aTimer != null)
            {
                
                aTimer.Stop();
                Console.WriteLine();
            }
        }
    }
}
