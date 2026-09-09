//Zionn Showers
//9-9-2026
//Mini Challenge # 4 - Greater Than Or Less Than
//I made the user type in two different numbers and save them as strings. I then made the code convert the strings into integers. I then used a lot of else if statements to correctly calculate the integers. Afterwards, the program says if the two numbers are greater, lesser, or equal to each other
//Peer Review:Callen Thomason
/*
review: 
The program works as intended. Variables are clear and make sense. 
Good job taking user input and converting it into integer
Good use of if statments but you could have used fewer using some >< logic. If one side is true the other side must be also. 
Great flow chart, the code matches up
*/ 


Console.Clear(); //Setup

Console.WriteLine("Enter a number:"); //Number setups
string num1 = Console.ReadLine();
Console.WriteLine("Enter another number:");
string num2 = Console.ReadLine();
int actualNum1 = Convert.ToInt32(num1);
int actualNum2 = Convert.ToInt32(num2);


if(actualNum1 > actualNum2)// 1st Number Output
{
    Console.WriteLine($"{actualNum1} is greater than {actualNum2}!");
}
else if(actualNum1 < actualNum2)
{
    Console.WriteLine($"{actualNum1} is lesser than {actualNum2}!");
}
else
{
    Console.WriteLine($"{actualNum1} is equal to {actualNum2}!");
}

if(actualNum2 > actualNum1)// 2nd Number Output
{
    Console.WriteLine($"{actualNum2} is greater than {actualNum1}!");
}
else if(actualNum2 < actualNum1)
{
    Console.WriteLine($"{actualNum2} is lesser than {actualNum1}!");
}
else
{
    Console.WriteLine($"{actualNum2} is equal to {actualNum1}!");
}