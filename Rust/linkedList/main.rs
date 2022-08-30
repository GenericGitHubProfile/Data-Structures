mod singleLinkedList;
use crate::singleLinkedList::SingleLinkedList;

fn main() {
    let mut sll: SingleLinkedList<i32> = SingleLinkedList::new();
    sll.appendNode(37i32);
    println!("{}", sll.length());
    println!("{:?}", sll);
}