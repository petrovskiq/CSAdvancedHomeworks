using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class Medium
    {
        public delegate void NewsDelegate(object sender, NewsEventArgs e);

        public event NewsDelegate EventBreakingNews;

        public void SendBreakingNews(string title, string content, DateTime date)
        {
            NewsEventArgs News = new NewsEventArgs(title, content, date);
            if (EventBreakingNews == null)
            {
                Console.WriteLine("No subscribers");
                return;
            }
            EventBreakingNews(this, News);

        }

        public class NewsEventArgs : EventArgs
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime Date { get; set; }

            public NewsEventArgs(string title, string content, DateTime date)
            {
                Title = title;
                Content = content;
                Date = date;
            }
        }
    }
}
