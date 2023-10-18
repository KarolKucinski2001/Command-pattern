using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecPolecenieZad1
{
    //Polecenie (Invoker): W tym przypadku, klasa Moderator jest obiektem wykonującym polecenia. Ma możliwość zatwierdzania lub odrzucania komentarzy.
    //moderacja automatyczna jezeli jest jakies słowo post usuwany albo jakies info 
    public class Moderator
    {
        public void ProcessComment(ICommand command)
        {
            command.Execute();
        }
    }
}
