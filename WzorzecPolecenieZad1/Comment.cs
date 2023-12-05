using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecPolecenieZad1
{
    public class Comment
    {

        public string Text { get; private set; }
        public bool IsApproved { get; private set; }
       


        public Comment(string text)
        {
            Text = text;
            IsApproved = false;
        }

        public void Approve()
        {
            IsApproved = true;
            Console.WriteLine("Komentarz został zatwierdzony: " + Text);
        }

        public void Reject()
        {
            IsApproved = false;
            Console.WriteLine("Komentarz został odrzucony: " + Text);
        }
    }

}
