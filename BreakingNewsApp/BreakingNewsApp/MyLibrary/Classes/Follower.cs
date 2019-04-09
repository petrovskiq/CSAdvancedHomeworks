using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;
using static MyLibrary.Classes.Medium;

namespace MyLibrary.Classes
{
    public class Follower
    {
        public string Name { get; set; }

        public Follower(string name)
        {
            Name = name;
        }

        public void Subscribe(Medium medium)
        {
            medium.EventBreakingNews += new Medium.NewsDelegate(PrintNews);
        }

        public void PrintNews(object obj, NewsEventArgs e)
        {
            Console.WriteLine($"{e.Title} {e.Content} {e.Date}");
        }
    }
}
