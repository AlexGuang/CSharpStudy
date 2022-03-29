using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceDemo
{
    class Post
    {
        private static int currentPostId;
        //properties

        protected int ID { get; set; }

        protected  string Title { get; set; }

        protected string SendByUsername { get; set; }   

        protected bool IsPublished { get; set; }


        //Default constructor. If a derived class does not invoke a base class constructor explicity,
        //the default constructor is called implicity.

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublished = true;
            SendByUsername = "Xiao Guang";
        }
        //Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.Title = title;
            this.IsPublished = isPublic;
            this.ID = GetNextID();
            this.SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublished = isPublic;
        }

        //Virtual method override of the ToString method that is inerited
        // from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }

       
     
    }
}
