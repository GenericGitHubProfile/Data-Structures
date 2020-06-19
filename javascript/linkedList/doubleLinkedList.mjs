import { LinkedList } from './linkedList.mjs';

class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
        this.prev = null;
    }
};

export class DoubleLinkedList extends LinkedList  {
    constructor() {
        this.length = 0;
        this.head = null;
        this.tail = null;
    }

    prependNode(data) {
        let newNode = new Node(data);
        if(this.length === 0) {
            this.head = newNode;
            this.tail = newNode;
            newNode.next = newNode;
            newNode.prev = newNode;
        } else {
            newNode.next = this.head.next;
            newNode.prev = this.head.prev;
            this.head.prev.next = newNode;
            this.head.next.prev = newNode;

            this.head = newNode;
        }

        this.length++;
    }

    appendNode(data) {
        let newNode = new Node(data);
        if(this.length === 0) {
            this.head = newNode;
            this.tail = newNode;
            newNode.next = newNode;
            newNode.prev = newNode;
        } else {
            let curNode = this.head;
            while(curNode.next !== this.head) {
                curNode = curNode.next;
            }
            newNode.next = curNode.next;
            newNode.prev = curNode;
            curNode.next = newNode;
            this.tail = newNode;
        }
        this.length++;
    }
};

let dLL = new DoubleLinkedList();
dLL.prependNode(1);
dLL.prependNode(2);
// dLL.prependNode(3);
// dLL.prependNode(4);
// dLL.prependNode(5);
// dLL.prependNode(6);

dLL.printList();
console.log(dLL.head);

console.log(Object.getOwnPropertyNames(Object.getPrototypeOf(dLL)));
