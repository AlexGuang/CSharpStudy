using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseGeterAndSetterInClass
{
    internal class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public void SetLength(int length)
        {
            this.length=length;
        }
        private int GetVolume()
        {
            return this.length*this.height*this.width;
        }

        public void SetHight(int height)
        {
            if (height < 0)
            {
                throw new Exception("You should input a value which is greater than 0");
                
            }
            else
            {
                this.height=height;
            }
        }

        public void DescribeBox()
        {
            Console.WriteLine("The length,height,width and volume of this box are:{0},{1},{2},{3}",length,height,width,GetVolume());
        }
    }
    
}
