using System;
using System.ComponentModel.DataAnnotations;

public class LinkedList<T>
{
  //properties
  public Node<T> First {get; private set;}
  public Node<T> Last {get; private set;}
  public int Count {get; private set;}

  public LinkedList()
  {
    this.First = null;
    this.Last = null;

  }

  public void AddFirst(Node<T> newNode)
  {
    if (this.First == null)
    {
        //this means the linked list is empty
        //insert the new node and point the head and tail to the node
        this.First = newNode;
        this.Last = newNode;
        
    } else {

        newNode.Next = this.First;
        this.First = newNode;
    }
    Count++;
  }

  public void AddLast(Node<T> newNode)
  {
    if (this.First == null)
    {
        //this means the linked list is empty
        //insert the new node and point the head and tail to the node
        this.First = newNode;
        this.Last = newNode;
        
    } else {

        this.Last.Next = newNode;
        Last = newNode;
    }
    Count++;
  }

  public void AddAfter(Node<T> newNode, Node<T> existingNode){
    //if you are adding after the last node, then
    //you need to repoint the Last Pointer

    if (this.Last == existingNode)
    {
        Last = newNode;
    }
    newNode.Next = existingNode.Next;
    existingNode.Next = newNode;
    this.Count++;

  } 

  public Node<T> Find(T target){
    Node<T> currentNode = First;

    while (currentNode != null && !currentNode.Data.Equals(target))
    {
        currentNode = currentNode.Next;
    }

    return currentNode;
  }

  public void RemoveFirst(){
    if (First == null || this.Count == 0){
        //nothing to do. Return
        return;

    }

    First = First.Next;
    this.Count--;

  }

  public void Remove(Node<T> doomedNode){
    
    if (First == null || this.Count == 0){

        //nothing to do. Return
        return;
    }

    if (this.First == doomedNode){
        this.RemoveFirst();
        return;
    }
    //else, you will need to traverse the linked list to find
    //the doomedNode and remove it
    Node<T> previous = First;
    Node<T> current = previous.Next;

    while (current != null && current != doomedNode){
        //move to the next node
        previous = current;
        current = previous.Next;
    }

    //remove it
    if(current != null){
    previous.Next = current.Next = current.Next;
    this.Count --;
    }

  }

    public void Traverse(){
        Console.WriteLine("\nFirst" + this.First.Data);
        Console.WriteLine("Last" + this.Last.Data);

        Node<T> node = this.First;

        while (node.Next != null){
            Console.WriteLine(node.Data);
            node = node.Next;
        }
        Console.WriteLine(node.Data);

    }
}