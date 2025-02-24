// See https://aka.ms/new-console-template for more information
using System;


string FizzBuzz(int number)
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

//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz
