using System;
using DataStructures.SLL;

namespace testDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingleLinkedList sLL = new SingleLinkedList();
            sLL.prependNode(1);
            sLL.prependNode(2);
            sLL.appendNode(3);
            sLL.appendNode(4);
            sLL.printList();
            sLL.deleteNode(3);
            sLL.printList();
        }
    }
}
