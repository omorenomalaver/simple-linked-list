using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_linked mySimpleLinked = new Simple_linked();
            mySimpleLinked.addNodes(2);
            mySimpleLinked.addNodes(5);
            mySimpleLinked.addNodes(7);
            mySimpleLinked.addNodes(1);
            mySimpleLinked.addNodes(3);
            mySimpleLinked.printAllNodes();
            Console.ReadKey();
        }
    }
}
