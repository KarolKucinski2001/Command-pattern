using System;

namespace WzorzecPolecenieZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Moderator moderator = new Moderator();

            Comment comment1 = new Comment("To jest przykładowy komentarz z zakazanym słowem pomidor.");
            Comment comment2 = new Comment("To jest inny komentarz bez zakazanych słów.");
            Comment comment3 = new Comment("W podstawowce dzieci graja w gre pomidor.");


            ICommand command1 = new CommentCommand(comment1, "pomidor");
            ICommand command2 = new CommentCommand(comment2, "pomidor");
            ICommand command3 = new CommentCommand(comment3, "pomidor");

            moderator.ProcessComment(command1);
            moderator.ProcessComment(command2);
            moderator.ProcessComment(command3);


            Console.ReadKey();
        }
    }

}
