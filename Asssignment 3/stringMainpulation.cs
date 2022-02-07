using System;

public class stringMainpulation
{
  /*  public static void Main()
    {int choice = 0;
        Console.WriteLine("please enter the qustion number\n");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {

            Question1();
        }
        else if (choice == 2)
        {
            Question2();
        }
    }*/
    public static void Question1()
    {
        string sentence;
        int length;
        int lastChar;

        Console.WriteLine("Please enter the sentence?\n");
        sentence = Console.ReadLine();
        length = sentence.Length;
        lastChar = Convert.ToInt32(sentence[length - 1]);
        Console.WriteLine($"length of the sentence is {length} letters.\n ");
        if (lastChar == 46)
        {
            Console.WriteLine($"{sentence} is a declarative sentence.");

        }
        else if (lastChar == 63)
        {
            Console.WriteLine($"{sentence} is a interrogatory sentence.");
        }
        else if (lastChar == 33)
        {
            Console.WriteLine($"{sentence} is a exclamation sentance.");

        }
        else
        {
            Console.WriteLine($"{sentence} is grammatically wrong. ");
        }
    }
    public static void Question2()
    {
        string fullName;
        Console.WriteLine("Please write full name here \n");
        fullName = Console.ReadLine();
        string[] names=fullName.Split(' ');
      if (names.Length == 2)
        {
            Console.WriteLine($" First name: {names[0] } and last name : {names[1]}");

        }
      else
        {
            Console.WriteLine($" First name :{names[0]} and last name: \"not specified \" ");

        }



    }
}
