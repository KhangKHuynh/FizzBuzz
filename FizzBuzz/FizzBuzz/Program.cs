namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please enter a number!");

        var number = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine($"Your word is {FizzBuzz(number)} ");
    }
    
    
    static string FizzBuzz(int number)
    {
        var answer = "";
     
        if (number % 3 == 0)
        {
            answer = "fizz";
        }

        if (number % 5 == 0)
        {
            answer = "buzz";
        }
        
        if (number % 3 == 0 && number % 5 == 0)
        {
            answer = "fizzbuzz";
        }
        return answer;
    }
}


//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz