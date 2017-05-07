using Client2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            IssueTrackerClient client2 = new IssueTrackerClient();

            Issue issue3 = new Issue();
            issue3.Title = "is3";
            issue3.Priority = 1;

            Issue issue4 = new Issue();
            issue4.Title = "is4";
            issue4.Priority = 1;

            Console.Out.WriteLine("KLIENT 2 Wcisnij co kolwiek by zaczac");
            Console.ReadKey();
            int id1 = client2.putIssue(issue3, "projekt2");
            Console.Out.WriteLine("put issue3 to projekt 2: Odebrano id: " + id1.ToString());

            int id2 = client2.putIssue(issue4, "projekt2");
            Console.Out.WriteLine("put issue4 to projekt 2: Odebrano id: " + id2.ToString());

            Console.Out.WriteLine("Przejdz do klienta 1");
            Console.ReadKey();

            /////////////////////////////////////////////////////////////////////

            Console.Out.WriteLine("Wpidz id issue 2 z projektu 1");
            int idIssue2 = Convert.ToInt32(Console.ReadLine());

            Issue issue2o = client2.getIssue(idIssue2, "projekt1");     //19
            Console.Out.WriteLine("Odebrano issue "+idIssue2+" z projektu 1: " + (issue2o == null ? "null" : issue2o.Title));

            bool usuniecieIss2 = client2.delete(idIssue2, "projekt1");     //21
            Console.Out.WriteLine("Wynik usuniecia issue 2 z projektu 1: " + usuniecieIss2);

            int idIs2 = client2.putIssue(issue2o, "projekt2");              //23
            Console.Out.WriteLine("put issue2 z projektu 2: Odebrano id: " + idIs2);

            Console.Out.WriteLine("To be continued on client1");
            Console.ReadKey();
        }
    }
}
