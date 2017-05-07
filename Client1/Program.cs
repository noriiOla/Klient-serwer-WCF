using Client1.ServiceReference1;
using System;

namespace Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            IssueTrackerClient client1 = new IssueTrackerClient();

            Issue issue1 = new Issue();
            issue1.Title = "is1";
            issue1.Priority = 1;

            Issue issue2 = new Issue();
            issue2.Title = "is2";
            issue2.Priority = 1;

            Console.Out.WriteLine("KLIENT 1 Wcisnij co kolwiek by zaczac");
            Console.ReadKey();

            int id1 = client1.putIssue(issue1, "projekt1");
            Console.Out.WriteLine("put issue1 to project 1: Odebrano id: " + id1.ToString());

            int id2 = client1.putIssue(issue2, "projekt1");
            Console.Out.WriteLine("put issue2 to project 1: Odebrano id: " + id2.ToString());

            Console.Out.WriteLine("Przejdz do klienta 2");
            Console.ReadKey();
            //////////////////////////////////////////////////////////////////////////////
            Issue issue1o = client1.getIssue(id1, "projekt1");
            Console.Out.WriteLine("Odebrano issue id: " + id1 + "z projektu 1 : " + issue1o.Title);  //12

            Console.Out.WriteLine("Wpidz id issue 3 z projektu 1");
            int idIssue3 = Convert.ToInt32(Console.ReadLine());         

            Issue issue3o = client1.getIssue(idIssue3, "projekt1");     //14
            Console.Out.WriteLine("Odebrano issue id: "+idIssue3+"  z projektu 1: " + (issue3o == null ? "null" : issue3o.Title));

            Console.Out.WriteLine("Wpidz id issue 4 z projektu 2");
            int idIssue4 = Convert.ToInt32(Console.ReadLine());

            Issue issue4o = client1.getIssue(idIssue4, "projekt2");     //16
            Console.Out.WriteLine("Odebrano issue  id: " + idIssue4 + "  z projektu 2: " + issue4o == null ? "null" : issue4o.Title);

            Console.Out.WriteLine("Przejdz do klienta 2");
            Console.ReadKey();

            //26  get id2 from   project 1
            Issue issue2o = client1.getIssue(id2, "projekt1");     //19
            Console.Out.WriteLine("Odebrano issue: "+id2+" z projektu 1" + (issue2o == null ? "null" : issue2o.Title));

            bool usuniecieIss3 = client1.delete(idIssue3, "projekt1");     //21
            Console.Out.WriteLine("Wynik usuniecia: "+ idIssue3 +" z projektu 1 " + usuniecieIss3);
            //dodatkowo
            bool dodBool = client1.delete(idIssue3, "projekt1");     //21
            Console.Out.WriteLine("Wynik usuniecia: " + idIssue3 + " z projektu 1 " + dodBool);

            Console.Out.WriteLine("Koniec");
            Console.ReadKey();

        }
    }
}
