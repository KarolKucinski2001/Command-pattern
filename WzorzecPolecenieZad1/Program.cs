using System;

namespace WzorzecPolecenieZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Moderator moderator = new Moderator();

            Comment comment1 = new Comment("pomidor to moj ulubiony owoc.");
            Comment comment2 = new Comment("To jest komentarz ktore zostanie zaakceptowany.");
            Comment comment3 = new Comment("W podstawowce dzieci graja w gre pomidor.");

            Forum f1 = new Forum();
            ICommand command1 = new CommentCommand(comment1, "pomidor",f1);
            ICommand command2 = new CommentCommand(comment2, "pomidor",f1);
            ICommand command3 = new CommentCommand(comment3, "pomidor",f1);

            moderator.AddCommand(command1);
            moderator.AddCommand(command2);
            moderator.AddCommand(command3);

            moderator.ProcessComment();

            
      


           
        }
    }

}
