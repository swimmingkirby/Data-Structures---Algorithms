using System;
using System.Collections;

public class SampleStack
{
    public static void Main2()
    {
        Stack mainStack = new Stack();
        Stack tempStack = new Stack();
        PopulateValues(mainStack);

        while (true)
        {
            Console.WriteLine("What would you like to do? (Type 'undo' or 'redo')");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "undo":
                    Undo(mainStack, tempStack);
                    break;

                case "redo":
                    Redo(mainStack, tempStack);
                    break;

                default:
                    Console.WriteLine("Invalid input. Please type 'undo' or 'redo'.");
                    break;
            }

            DisplayStackInfo("myStack", mainStack);
            DisplayStackInfo("tempStack", tempStack);
        }
    }

    public static void Redo(Stack mainStack, Stack tempStack)
    {
        if (tempStack.Count > 0)
        {
            object poppedValue = tempStack.Pop();
            mainStack.Push(poppedValue);
        }
        else
        {
            Console.WriteLine("Cannot redo. tempStack is empty.");
        }
    }

    public static void Undo(Stack mainStack, Stack tempStack)
    {
        if (mainStack.Count > 0)
        {
            object poppedValue = mainStack.Pop();
            tempStack.Push(poppedValue);
        }
        else
        {
            Console.WriteLine("Cannot undo. mainStack is empty.");
        }
    }

    public static void PopulateValues(Stack stack)
    {
        for (int i = 0; i < 5; i++)
        {
            stack.Push($"Action {i + 1}");
        }
    }

    public static void DisplayStackInfo(string stackName, Stack stack)
    {
        Console.WriteLine($"{stackName}");
        Console.WriteLine($"\tCount:    {stack.Count}");
        Console.Write("\tValues:");
        PrintValues(stack);
        Console.WriteLine("-----------------------------------");
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (object obj in myCollection)
            Console.Write($"    {obj}");
        Console.WriteLine();
    }
}