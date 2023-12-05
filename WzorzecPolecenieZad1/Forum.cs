using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecPolecenieZad1
{
    public class Forum
    {
        private List<Comment> acceptedComments = new List<Comment>();

       
        public void AddAcceptedComments(Comment comment)
        {
            acceptedComments.Add(comment);
        }


      

    }
}
