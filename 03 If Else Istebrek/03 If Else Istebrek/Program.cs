////1.Even or Odd:
Console.WriteLine("Input a number of your choice.");
int responseNumber = Convert.ToInt32(Console.ReadLine());

if (responseNumber % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else if (responseNumber % 2 == 1)
{
    Console.WriteLine("The number is odd");
}


////2. Age Bracket:
Console.WriteLine("How old are you?");
int responseAge = Convert.ToInt32(Console.ReadLine());

if (responseAge < 13)
{
    Console.WriteLine("You are a child young one");
}
else if (13 < responseAge && responseAge < 19)
{
    Console.WriteLine("You are a teenager");
}
else if (responseAge > 19)
{
    Console.WriteLine("You're an adult");
}


////3. Grade System:
Console.WriteLine("What score did you get on the test from 0-100?");
int responseScore = Convert.ToInt32(Console.ReadLine());

if (90 <= responseScore && 100 >= responseScore)
{
    Console.WriteLine("According to the calculations of your score, your grade is A, great job!");
}
else if (80 <= responseScore && 89 >= responseScore)
{
    Console.WriteLine("According to the calculations of your score, your grade is B, well done!");
}
else if (70 <= responseScore && 79 >= responseScore)
{
    Console.WriteLine("According to the calculations of your score, your grade is C, not too shabby!");
}
else if (60 <= responseScore && 69 >= responseScore)
{
    Console.WriteLine("According to the calculations of your score, your grade is D, barely made it!");
}
else if (60 > responseScore)
{
    Console.WriteLine("According to the calculations of your score, your grade is F, better luck next time!");
}



////4. Leap Year Checker:
Console.WriteLine("Input a year");
int responseYear = Convert.ToInt32(Console.ReadLine());

if (responseYear % 4 == 0 && responseYear % 100 != 0 || responseYear % 400 == 0)
{
    Console.WriteLine($"The year {responseYear} is a leap year");
}
else
{
    Console.WriteLine($"The year {responseYear} is not a leap year");
}



////5.Maximum of Three:
Console.WriteLine("Please do me the honor of getting 3 different number inputs from you");
int responseNum1 = Convert.ToInt32(Console.ReadLine());
int responseNum2 = Convert.ToInt32(Console.ReadLine());
int responseNum3 = Convert.ToInt32(Console.ReadLine());

if (responseNum1 > responseNum2 && responseNum1 > responseNum3)
{
    Console.WriteLine($"{responseNum1} is the maximum number of your numbers, your honor");
}
else if (responseNum2 > responseNum1 && responseNum2 > responseNum3)
{
    Console.WriteLine($"{responseNum2} is the maximum number of your numbers, your honor");
}
else if (responseNum3 > responseNum2 && responseNum3 > responseNum1)
{
    Console.WriteLine($"{responseNum3} is the maximum number of your numbers, your honor");
}

////6.Positive, Negative, or Zero:
Console.WriteLine("Please input a number");
int responseNum = Convert.ToInt32(Console.ReadLine());

if (responseNum == 0)
{
    Console.WriteLine("Your number is Zero your highness");
}
else if (responseNum < 0)
{
    Console.WriteLine("With all due respect, your number is negative your highness");
}
else if (responseNum > 0)
{
    Console.WriteLine("Your number is positive your highness");
}


////7.Discount System:
Console.WriteLine("What is the total of your purchase?");
int responseTotalPurchase = Convert.ToInt32(Console.ReadLine());

if (responseTotalPurchase > 1000)
{
    Console.WriteLine($"You get a discount of 10%, so your total today is {responseTotalPurchase * 0.9}$");
}
else
{
    Console.WriteLine($"Your total today is {responseTotalPurchase}$, if you purchase for another {1001 - responseTotalPurchase}$, you can get a 10% discount");
}

//8.Weekdays:
Console.WriteLine("Choose a number from 1 to 7");
int responseDays = Convert.ToInt32(Console.ReadLine());

switch (responseDays)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("The instructions are simple, try again");
        break;
}


////9.Password Checker:
string password = "Csharp123!";
Console.WriteLine("Password");
string responsePassword = Console.ReadLine();

if (password == responsePassword)
{
    Console.WriteLine("Access granted");
}
else
{
    Console.WriteLine("Access denied");
}


////10.Temperature Converter:
Console.WriteLine("Type CELSIUS for conversion to Fahrenheit and FAHRENHEIT for conversion to Celsius. Then enter the temperature you'd like to convert");
string responseConversion = Console.ReadLine();
int responseTemp = Convert.ToInt32(Console.ReadLine());

if (responseConversion == "CELSIUS")
{
    Console.WriteLine($"The temperature {responseTemp}°C is {(responseTemp * 1.8) + 32}°F");
}
else if (responseConversion == "FAHRENHEIT")
{
    Console.WriteLine($"The temperature {responseTemp}°F is {(responseTemp - 32) / 1.8}°C");
}