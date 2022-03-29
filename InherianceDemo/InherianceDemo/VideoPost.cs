using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace InherianceDemo
{
    internal class VideoPost : Post
    {
      
        public static Timer aTimer;
        public string VideoURL { get; set; }

        public int Length { get; set; }

        public bool isPlay = false;

        public int currentPlaying = 0;

        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUser, bool isPublished, string videoURL, int length)
        {
            this.Title = title;
            this.Length = length;
            this.VideoURL = videoURL;
            this.ID = GetNextID();
            this.IsPublished = isPublished;
            this.SendByUsername = sendByUser;
            this.isPlay = false;

        }


        public override string ToString()
        {
            return String.Format("{0} -  {1}, by {2},from {3}, length is {4}",
                this.ID,this.Title,this.SendByUsername,this.VideoURL, this.Length);
        }
        public void Play()
        {
            if (!this.isPlay)
            {
                isPlay = true;
               
                    aTimer = new Timer(TimerCallback, null, currentPlaying, 1000);
                    Console.WriteLine("The video starts at {0} second",currentPlaying);
               
            }

           
          
          

        }
        private void TimerCallback(object o)
        {
            if (currentPlaying < Length)
            {
                currentPlaying++;
                Console.WriteLine("Video is at {0} second", currentPlaying);
                GC.Collect();
            }
            else
            {
                Stop();
            }
          
        }

        public void Stop()
        {
            if (aTimer != null)
            {
                if (isPlay)
                {
                    isPlay=false;
                    aTimer.Dispose();
                    Console.WriteLine("Video stops at {0} seconds",currentPlaying);

                }
                
                
            }
        }
    }
}
