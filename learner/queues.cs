using System;
using System.Collections;

public class Queues
{
    public static void Main3()
    {
        //FIFO data structure
        Queue myQueue = new Queue();
        PopulateValues(myQueue);
        PrintValues(myQueue);

        for (int i=0; myQueue.Count > 1; i++) {

            object frontPerson = myQueue.Peek();
            if (frontPerson.ToString() != "Person 3")
            {
                Console.WriteLine($"{frontPerson} can pass.");
                myQueue.Dequeue();
                
            } else {
                Console.WriteLine($"Excuse me Person 3 can you go back to the back of the queue");
                myQueue.Enqueue(frontPerson);
                myQueue.Dequeue();
               
            }

        }
    }


    public static void PopulateValues(Queue queue)
    {
        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue($"Person {i + 1}");
        }
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        Console.WriteLine("myQ");
        Console.Write("\tValues:");
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}
