using System;
//https://www.youtube.com/watch?v=CBYHwZcbD-s
class Program
{
    static void Main(string[] args)
    {
        // Your code goes here
        LinkedList<string> ll =  new LinkedList<string>();

        Node<string> a = new Node<string>("aaa");
        ll.AddFirst(a);
        Node<string> b = new Node<string>("bbb");
        ll.AddFirst(b);
        Node<string> c = new Node<string>("ccc");
        ll.AddFirst(c);
        Node<string> d = new Node<string>("ddd");
        ll.AddFirst(d);

    }
}
