using System.Net;

public class Character
{
    
//Properties of My class
private  string name;
private  int age;

//You can add additional logic inside the get and set accessors if needed. This allows you to enforce constraints or perform validations.
public string Name
{
    get { return name; }
    set { name = value; }
}

public int Age
{
    get { return age; }
    set { if (value >= 0)
        {
            age = value;
        }
        else
        {
            // Handle invalid input, such as throwing an exception or setting a default value.
            Console.WriteLine("Age must be a non-negative value.");
        } }
}

//Methods
public void sayHi(){

    Console.WriteLine($"Hello!, I am {Name}, and i am {Age} years old!");
}

}



//By following these steps, you ensure that the internal state of the object (the private fields) is controlled and accessed only through the specified public interface