using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheirtancePart2
{
    public class Image : Post
    {
        public string ImageURL { get; set; }

        public Image()
        {

        }
        public Image(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            //this increment method is from the Post class
            this.ID = IncrementID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;

        }

        //override the method to include image url
        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {ImageURL} - {IsPublic} - posted by {SendByUserName}");
        }
    }
}
