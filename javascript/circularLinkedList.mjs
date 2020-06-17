class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
};

class CircularLinkedList {
    constructor() {
        this.length = 0;
        this.head = null;
    }

    prependNode(data) {
        let newNode = new Node(data);
        if(this.length === 0) {
            this.head = newNode;
            newNode.next = newNode;
        } else {
            let curNode = this.head;
            while(curNode.next !== this.head) {
                curNode = curNode.next;
            }

            curNode.next = newNode;
            newNode.next = this.head;
            this.head = newNode;
        }

        this.length++;
    }

    appendNode(data) {
        let newNode = new Node(data);
        if(this.length === 0) {
            this.head = newNode;
            newNode.next = this.head;
        } else {
            let curNode = this.head;
            while(curNode.next != this.head) {
                curNode = curNode.next;
            }

            curNode.next = newNode;

            newNode.next = this.head;
        }

        this.length++;
    }

    deleteNode(data) {
        console.log("start Delete");
        if(this.length === 0) {
            console.log("if Empty");
            return;
        }
        else if (this.length === 1) {
            console.log("if 1 length");
            if(this.head.data !== data) {
                return;
            }
            this.head = null;
        } else {
            let curNode = this.head;
            console.log("if multi");

            while(curNode.next != this.head && curNode.next.data != data) {
                console.count("iter");
                if(curNode.next.data = data) {
                    if(curNode.next === this.head) {
                        this.head = curNode.next.next;
                    }
                    curNode.next = curNode.next.next;
                    break;
                }

                curNode = curNode.next;
            }
        }

        this.length--;
    }

    isEmpty() {
        return this.length === 0;
    }

    findNode(data) {
        let curNode = this.head;

        while(curNode.data !== data) {
            if(curNode.next === this.head) {
                return false;
            } else {
                curNode = curNode.next;
            }
        }
        return curNode;
    }

    getNextNode(node) {
        if(node instanceof Node) {
            return node.next;
        }
        return false;
    }

    printList() {
        let curNode = this.head;

        while(curNode.next !== this.head) {
            console.log(curNode);
            curNode = curNode.next;
        }
    }
};


let cLL = new CircularLinkedList();

cLL.prependNode(2);
cLL.appendNode(3);
cLL.prependNode(1);
cLL.appendNode(4);

console.log(cLL.head);

// cLL.printList();

// console.log(Object.getOwnPropertyNames(Object.getPrototypeOf(cLL)));
