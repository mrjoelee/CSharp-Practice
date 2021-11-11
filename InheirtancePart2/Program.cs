using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheirtancePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Happy Veteran's Day", "Joe", true);
            Console.WriteLine(post1.ToString());


            Console.WriteLine("<-------------------------------------->");
            Image image1 = new Image("Just Do it", "Nike", 
            "\n https://nike.com", true);
            Console.WriteLine(image1.ToString());


            Console.WriteLine("<-------------------------------------->");
            VideoPost video1 = new VideoPost("Motiversity", "Motiversity", "\n https://motiversity.com", true, 10);
            Console.WriteLine(video1.ToString());

            Console.Read();
        }
    }
}
