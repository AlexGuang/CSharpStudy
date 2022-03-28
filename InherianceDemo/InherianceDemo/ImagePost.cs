using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherianceDemo
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        

        public ImagePost() :base()
        {

        }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // The following properties and the GetNexID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }


        public override string ToString()
        {
           return String.Format("{0}, {1}, by {2} from {3}",this.ID,this.Title, this.SendByUsername, this.ImageURL);
        }
    }
}
