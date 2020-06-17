public class Node {
    int data;
    Node next;

    public Node(int data) {
        this.data = data
        this.next = null;
    }
}

public class SingleLinkedList {
    Node head;
    int length;

    public SingleLinkedList() {
        this.length = 0;
        this.head = null;
    }

    prependNode(data) {
        Node newNode = new Node(data);

        if (this.length == 0) {
            this.head = newNode;
        } else {
            newNode.next = this.head.next;
            this.head = newNode;
        }

        this.length++;
    }

    appendNode(data) {
        Node newNode = new Node(data);

        if(this.length == 0) {
            this.head = newNode;
            this.length++;
            return;
        } else {
            Node curNode = this.head;

            while(curNode.next != null) {
                curNode = curNode.next;
            }

            curNode.next = newNode;
            this.length++;
        }
    }
}
