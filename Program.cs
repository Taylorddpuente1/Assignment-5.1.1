// Give integer X, return true if x  is a palindrome, and false otherwise

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input integer: ");
        int x = int.Parse(Console.ReadLine());

        if (IsPalindrome(x))
            Console.WriteLine($"{x} is a palindrone ");

        else 
          Console.WriteLine($"{x} is not a palindrone ");
    }
        static bool IsPalindrome(int x)
        { 
        int original = x; //121
        int reversed = 0;

        while (x > 0)
        {
            
            reversed = reversed * 10 + x %10;
            x = x/10;
        }

        return original == reversed;
}
}

