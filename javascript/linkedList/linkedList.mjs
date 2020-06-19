export class LinkedList {
    constructor() {
        this.length = 0;
        this.head = null;
    }

    /*
    * Returns next node if parameter given is a valid node
    */
    getNextNode(node) {
        return ((node instanceof Node) ? node.next : false);
    }

    /*
    * Returns whether the Linked List is empty or not
    */
    isEmpty() {
        return this.length === 0;
    }

    /*
    * Prints the Linked List
    */
    printList() {
        let curNode = this.head;

        while(curNode.next !== this.head || curNode.next !== null) {
            console.log(curNode);
            curNode = curNode.next;
        }
    }
};
