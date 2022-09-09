using System;

namespace DataStructures.DLL;
public class Node<T> {
    public T data;
    public Node<T> next;
    public Node<T> prev;

    public Node(T data) {
        this.data = data;
        this.next = null;
        this.prev = null;
    }

    public bool Compare(T other) {
        if(!this.data.Equals(other)) {
            return false;
        }
        return true;
    }
}

public class DoubleLinkedList<T> {
    public Node<T> head;
    public Node<T> tail;
    public int length;

    public DoubleLinkedList() {
        this.length = 0;
        this.head = null;
        this.tail = null;
    }

    public void prependNode(T data) {
        Node<T> newNode = new Node<T>(data);

        if(this.length == 0) {
            this.head = newNode;
            this.tail = newNode;
        } else {
            newNode.next = this.head;
            this.head.prev = newNode;
            this.head = newNode;
        }

        this.length++;
    }

    public void appendNode(T data) {
        Node<T> newNode = new Node<T>(data);

        if(this.length ==0) {
            this.head = newNode;
            this.tail = newNode;
        } else {
            // Node<T> curNode = this.head;
            // while (curNode.next != null) {
            //     curNode = curNode.next;
            // }

            // newNode.prev = curNode;
            // curNode.next = newNode;
            // this.tail = newNode;

            this.tail.next = newNode;
            newNode.prev = this.tail;
            this.tail = newNode;
        }

        this.length++;
    }

    // public void deleteNode(T data) {
    //     if(this.length == 0) return;

    //     Node<T> curNode = this.head;
    //     if (curNode.Compare(data)) {
    //         this.head = this.head.next;
    //     }
    // }

    public Node<T> getNextNode(Node<T> node) {
        return (node.next == null) ? null : node.next;
    }

    public Boolean isEmpty() {
        return this.length == 0;
    }

    public void printList() {
        Node<T> curNode = this.head;
        Console.WriteLine($"\nPrinting List of Length: {this.length}\n--START--");
        while (curNode != null) {
            Console.WriteLine(curNode.data);
            curNode = curNode.next;
        }
        Console.WriteLine("--FINISH--");
    }
}
