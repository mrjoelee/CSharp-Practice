using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheirtancePart2
{
    internal class VideoPost : Post
    {

        //properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        //default constructor
        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUserName, string videoURL, bool isPublic, int length)
        {
            this.ID = IncrementID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.Length = length;

        }

     // method override to add videourl and length
        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {VideoURL} - {Length} - {IsPublic} - posted by {SendByUserName}");
        }
    }
}
