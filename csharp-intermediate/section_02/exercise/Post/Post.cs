using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tutorial
{
    public class Post
    {
        public static string Title { get; set; }
        public static string Description { get; set; }
        public DateTime datetime = new DateTime();
        public static DateTime DatePosted = DateTime.Now;
        private static int _upvotes = 0;
        private static int _downvotes = 0;

        public static int UpVotes
        {
            get { return _upvotes; }
            set { _upvotes = value; }
        }

        public static int DownVotes
        {
            get { return _downvotes; }
            set { _downvotes = value; }
        }

        public static List<string> StartPost()
        {
            Console.WriteLine("Title of Post");
            Post.Title = Console.ReadLine();
            Console.WriteLine("Drescription of Post");
            Post.Description = Console.ReadLine();
            Console.WriteLine("up vote or down vote ( yes)");
            string str = Console.ReadLine();
            if(str.ToLower() == "yes")
            {
                while(true)
                {
                    Console.WriteLine("type uv got up vote or dv for down vote or exit to leave");
                    string choice = Console.ReadLine();
                    if(choice.ToLower() == "uv")
                    {
                        Post.UpVotes++;
                    }
                    else if (choice.ToLower() == "dv")
                    {
                        Post.DownVotes++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            var postline = new List<string> { Post.Title, Post.Description };
            return postline;
        }

        public static void DisplayPost(List<string> list)
        {
            Console.WriteLine("Title: " + list[0] +"\n");
            Console.WriteLine("Description: " + list[1]+"\n");
            Console.WriteLine("up votes: "+Post.UpVotes);
            Console.WriteLine("Down votes: "+ Post.DownVotes);
            Console.WriteLine("Date posted: "+Post.DatePosted);
        }
    }
}
