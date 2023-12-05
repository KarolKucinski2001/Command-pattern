using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecPolecenieZad1
{
    public class CommentCommand : ICommand
    {
        private Comment comment;
        private string forbiddenWord;
        private Forum forum;

        public CommentCommand(Comment comment, string forbiddenWord, Forum forum)
        {
            this.comment = comment;
            this.forbiddenWord = forbiddenWord;
            this.forum = forum;
        }

        public void Execute()
        {
         
            if (comment.Text.Contains(forbiddenWord))
            {
                comment.Reject();
            }
            else
            {
                comment.Approve();
                forum.AddAcceptedComments(comment);
            }
        }
    }
}
