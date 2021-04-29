using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * List.Add, List.Insert
             * List.Find, list.FindLast
             * list.FindIndex, list.FindAll
             * list.Remove, list.RemoveAll, list.RemoveAt, list.RemoveRange
             */

            string name;
            int index;

            // empty list
            List<String> list = new List<string>();

            // charged list
            List<String> list2 = new List<string> { "Amanda", "Alex" };
            list2.Insert(1, "Joao");
            list2.Insert(1, "Camila");
            list2.Insert(1, "Arthur");
            list2.Insert(1, "Antonio");
            list2.Insert(1, "Beatriz");
            list2.Insert(1, "Juan");
            list2.Insert(1, "Paulo");

            List<Client> listClients = new List<Client>();
            listClients.Add(new Client("Jessica", false));
            listClients.Add(new Client("Leonardo", true));
            listClients.Add(new Client("Pedro", false));
            listClients.Add(new Client("Sara", true));

            // proccess

            Console.WriteLine();
            Console.WriteLine("### list");
            Console.WriteLine("list.Count " + list.Count);

            DisplaySomeStringList(list, "display all content");

            Console.WriteLine("-----------------------------");

            Console.WriteLine();
            Console.WriteLine("### list2");
            Console.WriteLine("list2.Count " + list2.Count);

            DisplaySomeStringList(list2, "display all content");

            name = list2.Find(x => x[0] == 'A');
            Console.WriteLine($"list2 First A : {name}");

            name = list2.FindLast(x => x[0] == 'A');
            Console.WriteLine($"list2 Last A : {name}");

            index = list2.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"list2 First position 'A' : {index}");

            index = list2.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"list2 Last position 'A' : {index}");

            List<string> result = list2.FindAll(x => x.Length == 4);
            DisplaySomeStringList(result, "result by x.Length == 4");

            list2.Remove("Alex");
            DisplaySomeStringList(list2, "remove 'Alex'");

            list2.RemoveAt(1);
            DisplaySomeStringList(list2, "removeAt 1");

            list2.RemoveRange(2, 2);
            DisplaySomeStringList(list2, "removeRange 2 (index) at 2 (next values) ");

            Console.WriteLine("-----------------------------");

            Console.WriteLine();
            Console.WriteLine("### listClients");
            Console.WriteLine("listClients.Count " + listClients.Count);
            DisplayClientList(listClients, "display all content");

            List<Client> filterClientByFlag;
            filterClientByFlag = listClients.FindAll(x => x.Flag == true);
            DisplayClientList(filterClientByFlag, "only true Clients flag");

            filterClientByFlag = listClients.FindAll(x => x.Flag == false);
            DisplayClientList(filterClientByFlag, "only false Clients flag");


            static void DisplaySomeStringList(List<string> somelist, string msg)
            {
                Console.WriteLine($"Output {somelist} {msg}");
                foreach (string obj in somelist)
                {
                    Console.WriteLine($"   Name={obj}");
                }
            }

            static void DisplayClientList(List<Client> clientList, string msg)
            {
                Console.WriteLine($"Output {clientList} {msg}");
                foreach (Client obj in clientList)
                {
                    Console.WriteLine($"   clientList obj={obj.Name} - {obj.Flag}");
                }
            }
        }
    }
}
