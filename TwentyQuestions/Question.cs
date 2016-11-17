using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyQuestions
{
    class Question
    {
        public string question;
        public Question yes;
        public Question no;
        public Question parent;

        public bool IsLeaf()
        {
            return yes == null && no == null;
        }

        public Question(string q)
        {
            question = (q.IndexOf('?') == -1) ? "Is it " + q + "?" : q;
        }

        public Question(Question cur)
        {
            cur.question = question;
            cur.yes = yes;
            cur.no = no;
            cur.parent = parent;
        }

        public Question()
        {

        }
    }
}
