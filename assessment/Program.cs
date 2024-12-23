// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//1 simple adding
int[] number = { 1, 2, 3, 4, 5, };
int sum = 0;
for (int z = 0; z <= number.Length; z++)
{
    sum += z;

}
Console.WriteLine("the sum is: " + sum);



//3 Factorial
int FirstFactorial = 1;
int num;
if ( num < 1 || num > 18)
{

    for (int i= 1; i=num; i++){
        FirstFacorial *= i;

    }
}

//one decrement



Console.WriteLine("9876654");
string str = "9876654";
int count = 0;
for(int y=1; y <str.Length; y++)
{
    int currentDigit = str[y];
    int previousDigit =str[y - 1]-1;

    if(currentDigit == previousDigit)
    {
        count++;
    }
}

#region function

//chech vowels
string letters(char check)
{
    if (char.IsLetter(check))
    {
        if (check == 'a' || check == 'o' || check == 'u' || check == 'i' || check == 'e')

            return check + " vowel";

    }
    // return "";

    return check + "not vowel";

}


//check evens
Console.WriteLine("enter a number");
int number2(int num)
{
    if (num % 2 == 0)
    {
        return num * 2;
    }
    else
    {
        return num * num;
    }
}
#endregion

#region call function
Console.WriteLine("enter a letter");
char check = Convert.ToChar(Console.ReadLine());
Console.WriteLine(letters(check));

Console.WriteLine("enter number");
int Count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the number is :   " + number2(Count));


#endregion