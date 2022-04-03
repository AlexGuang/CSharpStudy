using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateAndEvents
{
    internal class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler( object source,EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void VideoEndcoding(Video video)
        {
            Console.WriteLine("Your video {0} is starting encoding...",video.Title);
            Thread.Sleep(2000);
            Console.WriteLine("Encoding completed 20%,");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding completed 30%");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding completed 60%");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding completed 90%");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding completed 100%");

            Console.WriteLine("视频编码成功，即将发送信息通知客户：");
            Thread.Sleep(2000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded!= null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
