//This is the learner app
//Time To go over some OOP concepts In relation to c# 
using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
class ArraySort
{
  
    static void Main1()
    {
      //Creates Family array
      Character[] family = CreateFamily();
      PrintFamily(family);
      SortAlphabetically(family);
      PrintFamily(family);
      SortByAge(family);
      PrintFamily(family);

    }
    
   static Character[] CreateFamily()
    {
      Console.WriteLine("How many members are in your familly?");
      int members = int.Parse(Console.ReadLine());
      Character[] familly = new Character[members];

      for(int i = 0; i < familly.Length; i++){
      Character currentcharacter = new Character();
      Console.WriteLine($"What is the name of Family member {i+1}:");
      currentcharacter.Name  = Console.ReadLine();
      Console.WriteLine($"What is the age of Family member {i+1}:");
      currentcharacter.Age =  int.Parse(Console.ReadLine());
      familly[i] = currentcharacter;
      }
      return familly;
    }

    static void PrintFamily(Character[] family){
      for (int i=0; i<family.Length ; i++){
        Console.WriteLine($"Family Member {i + 1}: {family[i].Name}");
      }
    }

    static void SortAlphabetically(Character[] array){
      Array.Sort(array, (char1,char2) => string.Compare(char1.Name, char2.Name, StringComparison.Ordinal));
    }

    static void SortByAge (Character[] array){
      Array.Sort(array, (char1,char2) => char1.Age.CompareTo(char2.Age));
    }
 
}
