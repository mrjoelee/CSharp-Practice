using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheirtancePart2
{
    public class Post
    {
        private static int currentPostId;

        //properties - protected only be utilize by the derived classes and this class(Post Class)
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //default consturctor
        public Post()
        {
            ID = 0;
            Title = "My 1st Post";
            SendByUserName = "Joe";
            IsPublic = true;
        }

        //constructor with 3 parameters
        public Post(string title, string sendByUserName, bool isPublic)
        {
            this.ID = IncrementID();
            this.Title = title; 
            this.SendByUserName = sendByUserName;   
            IsPublic = isPublic;    
        }

        //method to increment ID 
        protected int IncrementID()
        {
            return ++currentPostId;
        }

        //method to update post
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //this method original comes as virtual from the object class so it  can be
        //override
        public override string ToString()
        {
            return String.Format($"{ID} - {Title} - {IsPublic} - posted by {SendByUserName}");
        }
    }
}
