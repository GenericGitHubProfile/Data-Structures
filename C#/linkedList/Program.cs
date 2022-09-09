// See https://aka.ms/new-console-template for more information
using System;
// using DataStructures.SLL;
using DataStructures.DLL;

namespace DataStructures;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World");
        TestDLL();
    }

    // static void TestSLL() {
    //     SingleLinkedList<int> intsll = new SingleLinkedList<int>();
    //     Console.WriteLine($"{intsll.isEmpty()}");
    //     intsll.printList();

    //     intsll.appendNode(3);
    //     intsll.appendNode(4);

    //     Console.WriteLine($"{intsll.isEmpty()}");
    //     intsll.printList();

    //     // Console.WriteLine($"{typeof(sll)}");

    //     Node<int> node3 = intsll.findNode(3);

    //     Console.WriteLine($"Find Node 3: {node3}");

    //     SingleLinkedList<string> strsll = new SingleLinkedList<string>();

    //     strsll.appendNode("cheeseBoigah");
    //     strsll.prependNode("anglersnake");
    //     strsll.printList();
    //     strsll.appendNode("anglersnake");

    //     strsll.deleteNode("cheeseBoigah");

    //     strsll.printList();

    //     strsll.deleteAllNodes("anglersnake");

    //     strsll.printList();
    // }

    static void TestDLL() {
        DoubleLinkedList<int> intdll = new DoubleLinkedList<int>();
        Console.WriteLine($"Empty?: {intdll.isEmpty()}");
        intdll.printList();
        intdll.appendNode(3);
        intdll.prependNode(4);
        intdll.appendNode(24);

        Console.WriteLine($"Empty?: {intdll.isEmpty()}");

        intdll.printList();
        Console.WriteLine($"Length: {intdll.length}");
    }
}
