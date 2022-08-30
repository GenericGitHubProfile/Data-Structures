#![allow(non_snake_case)]

#[derive(Debug)]
pub struct SingleLinkedList<T: 'static> {
    length: u32, 
    head: Next<T>,
}

#[derive(Debug)]
struct Node<T: 'static> {
    data: T,
    next: &'static Next<T>,
}

#[derive(Debug)]
enum Next<T: 'static> {
    Some(Node<T>),
    None
}

impl<T: std::fmt::Debug> SingleLinkedList<T> {
    pub fn new() -> SingleLinkedList<T> {
        SingleLinkedList { length: 0, head: Next::None }
    }

    pub fn print() {
        println!("Hello, World!");
    }

    pub fn length(&self) -> u32 {
        return self.length;
    }

    pub fn appendNode(&mut self, data: T) {
        println!("{:?}", &self.head);

        let newNode = Node::<T> { data: data, next: &Next::None };

        self.head = Next::Some(newNode);
        self.length += 1;

        let curNode = &self.head;

        match curNode {
            Next::None => println!("Nothing lmao"),
            Next::Some(node) => println!("{:?}", node),
        }
    }
}