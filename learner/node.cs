public class Node <T>{
//Data
public T Data {get; set;}
//Link
public Node<T> Next {get; internal set;}
//constructors
public Node (T data)
{
    this.Data = data;    
}
}