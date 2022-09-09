using System;

namespace DataStructures.SLL;

public class Node<T> {
    public T data;
    public Node<T>? next;

    public Node(T data) {
        this.data = data;
        this.next = null;
    }

    public bool Compare(T other) {
        if(!this.data.Equals(other)) {
            return false;
        }
        return true;
    }
}

public class SingleLinkedList<T> {
    public Node<T> head;
    public int length;

    public SingleLinkedList(){
        this.length = 0;
        this.head = null;
    }

    public void prependNode(T data){
        Node<T> newNode = new Node<T>(data);

        if (this.length == 0) {
            this.head = newNode;
        } else {
            newNode.next = this.head;
            this.head = newNode;
        }

        this.length++;
    }

    public void appendNode(T data) {
        Node<T> newNode = new Node<T>(data);

        if (this.length == 0) {
            this.head = newNode;
        } else {
            Node<T> curNode = this.head;

            while (curNode.next != null) {
                curNode = curNode.next;
            }

            curNode.next = newNode;
        }

        this.length++;
    }

    public void deleteNode(T data) {
        if (this.length == 0) return;

        Node<T> curNode = this.head;
        if (curNode.Compare(data)) {
            this.head = this.head.next;
            curNode.next = null;
            this.length--;
        }

        while (curNode.next != null) {
            if (curNode.next.Compare(data)) {
                Node<T> deleteNode = curNode.next;
                curNode.next = deleteNode.next;
                deleteNode = null;
                this.length--;
            } else {
                curNode = curNode.next;
            }
        }
    }

    public void deleteAllNodes(T data) {
        if (this.length == 0) {
            return;
        }
        Node<T> curNode = this.head;
        while (this.head.Compare(data)) {
            this.head = this.head.next;
            curNode = this.head;
            this.length--;
            // Stop if the List is empty
            if (curNode == null) return;
        }

        while (curNode.next != null) {
            if(curNode.next.Compare(data)) {
                Node<T> deleteNode = curNode.next;
                curNode.next = deleteNode.next;
                deleteNode = null;
                this.length--;
            } else {
                curNode = curNode.next;
            }
        }
    }

    public Boolean isEmpty() {
        return this.length == 0 ? true : false;
    }

    public Node<T> findNode(T data) {
        Node<T> curNode = this.head;

        while (!curNode.Compare(data)) {
            if(curNode.next == null) {
                return null;
            } else {
                curNode = curNode.next;
            }
        }

        return curNode;
    }

    public Node<T> getNextNode(Node<T> node) {
        if (node is Node<T>) {
            return node.next;
        }
        return null;
    }

    public void printList() {
        Node<T> curNode = this.head;
        Console.WriteLine($"\nPrinting List of Length: {this.length}\n--START--");
        while(curNode != null) {
            Console.WriteLine(curNode.data);
            curNode = curNode.next;
        }
        Console.WriteLine("--FINISH--");
    }
}
