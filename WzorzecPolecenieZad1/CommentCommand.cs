using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecPolecenieZad1
{
    //Komenda(Command) : W tym przypadku, komenda reprezentuje komentarz, który trafia do moderatora do moderacji.Komenda zawiera treść komentarza oraz informację o słowie, które trzeba zmoderować(np. "pomidor").
    public class CommentCommand : ICommand
    {
        private Comment comment;
        private string forbiddenWord;

        public CommentCommand(Comment comment, string forbiddenWord)
        {
            this.comment = comment;
            this.forbiddenWord = forbiddenWord;
        }

        public void Execute()
        {
            // Tutaj można zaimplementować logikę moderacji.
            // Jeśli treść komentarza zawiera zakazane słowo, to komentarz jest odrzucany.
            if (comment.Text.Contains(forbiddenWord))
            {
                comment.Reject();
            }
            else
            {
                comment.Approve();
            }
        }
    }
}
