using System;


//1 simple adding


int number =Convert.ToInt32( Console.ReadLine());
int sum = 0;
for (int z = 1; z<=number; z++)
{
    sum += z;

}
Console.WriteLine("the sum is: " + sum);



//3 Factorial

int Fnumber = Convert.ToInt32(Console.ReadLine());
int FirstFactorial= 0;
for (int z = 1; z <= Fnumber; z++)
{
    FirstFactorial *= z;

}
Console.WriteLine("the Factorial is: " + FirstFactorial);



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


//evens
string numsrt = "24618";
string val="";
foreach(int c in numsrt)
{
    if (c % 2 != 0)
    {

       val= "false";
        break;
    }
    
       
}


Console.WriteLine(" result"+val  );
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
//Console.WriteLine("enter a number");
//int number2(int num)
//{
//    if (num % 2 == 0)
//    {
  //      return num ;
  //  }
 //   else
 //   {
 //       return num ;
 //   }
//}
#endregion

#region call function
Console.WriteLine("enter a letter");
char check = Convert.ToChar(Console.ReadLine());
Console.WriteLine(letters(check));

//Console.WriteLine("enter number");
//int Count = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("the number is :   " + number2(Count));


#endregion