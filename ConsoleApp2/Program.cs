
////////////////////////            Console.WriteLine("Hello");
////////////////////////// Declare a variable
/////////////////////////*
//////////////////////// * multi line 
//////////////////////// */


////////////////////////string a = "Ron Swanson";

////////////////////////// Variable can be overwritten
////////////////////////// Used for variable in the same line

////////////////////////Console.Write(a);

////////////////////////Console.ReadKey();



////////////////////////Calculator 




//////////////////////Console.WriteLine("Hey its calculator");


//////////////////////// Utf18 used for rule of string 
//////////////////////// variable with name userinput and data type string
//////////////////////// String are use for text

//////////////////////String userinput = Console.ReadLine();

//////////////////////Console.WriteLine(userinput);
//////////////////////Console.ReadKey();


//////////////////////string 

////////////////////// Reference type
////////////////////string myname = "Hello";
////////////////////// value type
////////////////////int myvalues = 3;
////////////////////double pi = 3.14;

////////////////////byte age = 255;
////////////////////short linkedinConnection = 32000;

////////////////////long phonenumbers = 984102012;

////////////////////// intialize
////////////////////string petsname;

////////////////////// entering a value

////////////////////petsname = "rosco";

////////////////////Console.WriteLine(petsname);




//////////////////////double ages = Double.Parse(Console.ReadLine());
//////////////////////Console.WriteLine(ages);


////////////////////double a = 0.0;
////////////////////double b = 0.0;
////////////////////// Calculator

////////////////////Console.WriteLine("Calculator, Please enter your first Number");
//////////////////// a = Convert.ToDouble(Console.ReadLine());

////////////////////Console.WriteLine("Calculator, Please enter your Second Number");

//////////////////// b = Convert.ToDouble(Console.ReadLine());


////////////////////double c = a + b;

////////////////////Console.WriteLine($"The score of {a} + {b} = {c} ");

////////////////////Console.ReadKey();


////////////////////// Implicit conversion
////////////////////int myint = 30;
////////////////////double mydouble = myint;

////////////////////Console.ReadKey();


//////////////////string boolString = "false";

//////////////////bool mybool = Convert.ToBoolean(boolString);
//////////////////Console.WriteLine(mybool);

//////////////////// Implicit type 

//////////////////var a = 3;

//////////////////Console.WriteLine(a);

//////////////////// +, - , / , *


//////////////////int num1 = 5;
//////////////////int num2 = 65;
//////////////////Console.WriteLine("age is " + num1);



////////////////int num = 10;
////////////////double price = 10.2;
////////////////string sar = "Franks";


////////////////Console.Write("The number is {0} and the price is {1}, the name is {2} ", num, price, sar);


////////////////string sars = " THis is the hugest \" string\" ever used with \\ slash / and a colon ";

////////////////Console.WriteLine(sars);


////////////////// Variuants
////////////////// true || true => true oone must be true then it is true
////////////////// true && false => false
////////////////// !true => false

////////////////bool x = true;
////////////////bool y = false;
////////////////if (x||  y  == false)
////////////////{
////////////////    Console.WriteLine("Bring umbrella");


////////////////}

////////////////else
////////////////{
////////////////    Console.WriteLine("Dont");
////////////////}


////////////////Console.WriteLine("Whats your age");

////////////////int age = Convert.ToInt32(Console.ReadLine());


////////////////if(age < 18)
////////////////{
////////////////    Console.WriteLine("you cant enter the bar");
////////////////}

////////////////else if ( age >= 18 && age <= 70)
////////////////{
////////////////    Console.WriteLine("Should i  call a taxi");
////////////////}
////////////////else
////////////////{
////////////////    Console.WriteLine("You dont enter the bar");
////////////////}



//////////////int num = 0;
//////////////int num2 = 0;


//////////////bool isEqual = num == num2;

//////////////bool isNotequal = num != num2;

//////////////Console.WriteLine("What is your number");


//////////////if (num == int.Parse(Console.ReadLine()))
//////////////{
//////////////    Console.WriteLine("Num");

//////////////    Console.WriteLine("Enter your age");

//////////////    int age = Convert.ToInt32(Console.ReadLine());
//////////////    if (age >= 18)
//////////////    {
//////////////        Console.WriteLine("Please enter your address");
//////////////        string address = Console.ReadLine();
//////////////    }

//////////////    else
//////////////    {
//////////////        Console.WriteLine("Sorry you cant get your pprice to due to age");
//////////////    }
//////////////}

//////////////else
//////////////{
//////////////    Console.WriteLine("What");
//////////////}

////////////Console.WriteLine("ENter your age");
////////////int age = int.Parse(Console.ReadLine());

////////////bool isparentsthere = false;

////////////if (age >= 18)
////////////{
////////////    Console.WriteLine("Enter your party");
////////////}

////////////else if (age >= 13)
////////////{
////////////    Console.WriteLine("Are your parents here answer with yes or no");
////////////    string iswithparents = Console.ReadLine();
////////////    if (iswithparents == "yes")
////////////    {
////////////        Console.WriteLine("You can go to party");
////////////    }
////////////    else
////////////    {
////////////        Console.WriteLine("Go home");
////////////    }
////////////}


////////////else
////////////{
////////////    Console.WriteLine("go home kid");
////////////}

//////////string months;
//////////int month = 1;

//////////switch (month)
//////////{

//////////    case 1:
//////////        months = "January";
//////////        break;
//////////    case 2:
//////////        months = "Febuary";
//////////        break;
//////////    default:
//////////        months = "Unknown";
//////////        break;

//////////}




////////string question1 = "What is the capital of nepal";
////////string answer1 = "Kathmandu";


////////string question2 = "What is 2 + 2";
////////string answer2 = "4";


////////int score = 0;

////////Console.WriteLine(question1);
////////string useranswer = Console.ReadLine();


////////if (useranswer.Trim().ToLower() == answer1)
////////{
////////    Console.WriteLine("Correct");
////////    score++;
////////}

////////else
////////{
////////    score--;

////////    Console.WriteLine("The correct answer is"+ answer1);
////////}


////////Console.WriteLine(question2);
////////string useranswer2 = Console.ReadLine();


////////if (useranswer2 == answer2)
////////{
////////    Console.WriteLine("Correct");
////////    score++;
////////}

////////else
////////{
////////    Console.WriteLine("The correct answer is", answer2);
////////    score--;
////////}


////////Console.WriteLine("QUiz compelted" + score);



////////Console.ReadKey();





//////// Incremental or decremental


//////int num = 0;

//////Console.WriteLine($"Num is {num}");
//////num--;
//////Console.WriteLine($"Num is {num}");

//////Console.WriteLine("Num is {0}", --num);
//////Console.WriteLine("Num is {0}" , num--);

//////Console.WriteLine("Num is {0}", num);

//////Console.ReadLine();



////Random random = new Random();
////int randomNumber = random.Next(1, 11);


////Console.WriteLine("enter a number");

////string inputstring = Console.ReadLine();


////int num1 = 0;
////bool ifnum = int.TryParse(inputstring, out num1);

////if (ifnum)


////{

////    if(num1 == randomNumber)
////    {
////        Console.WriteLine("You guessed it ");
////    }
////    else
////    {
////        Console.WriteLine("Wrong");
////    }
////        Console.WriteLine("Num ");
////}
////else
////{
////    Console.WriteLine("Not nmum");
////}


////    num1++;

////Console.WriteLine("User enter number + ", num1);

////Console.ReadKey();











//using System;

//namespace Coding.Exercise
//{
//    public class Exercise
//    {
//        public void SimpleCalculator()
//        {

//            Console.WriteLine("Enter your 1st number");

//            int num1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the second number");
//            int num2 = int.Parse(Console.ReadLine());

//            int result = 0;
//            Console.WriteLine("Enter your operation");
//            string op = Console.ReadLine();

//            switch (op)
//            {

//                case "+":
//                    result = num1 + num2;

//                    Console.WriteLine("Result : ", result);
//                    break;

//                case "-":
//                    result = num1 - num2;
//                    Console.WriteLine("Result : ", result);

//                    break;
//                case "*":
//                    result = num1 * num2; Console.WriteLine("Result : ", result);
//                    break;
//                case "/":
//                    if (num2 == 0)
//                    {
//                        Console.WriteLine("It is not possible by zero");
//                        return;
//                    }

//                        result = num1 / num2;

//                    Console.WriteLine("Result : ", result);

//                    break;
//                default:
//                    Console.WriteLine("Choose an operation carefully");
//                    return;
//            }




//        }
//    }
//}





















// Calculator

//Console.WriteLine("Enter a first number");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter a Second number");
//double b = Convert.ToDouble(Console.ReadLine());

//double c;
//Console.WriteLine("Choose a character +-/*");
//string chars = Console.ReadLine();

//// We can either go if or else or switch statement


//switch (chars)
//{
//    case "+":
//        c = a + b;
//        Console.WriteLine(c);
//        break;
//    case "*":
//        c = a * b;
//        Console.WriteLine(c);
//        break;
//    case "-":
//        c = a - b;
//        Console.WriteLine(c);
//        break;
//    case "/":
//        if (b == 0)
//        {
//            Console.WriteLine("nUM CANT BE DIVIDED BY ZERO");
//            break;


//        }
//        else
//        {
//            c = a / b;
//            Console.WriteLine(c);
//            break;
//        }

//    default:
//        Console.WriteLine("Choose a right operation");
//        return;



//}


// Fizz buzz


//Console.WriteLine("Write a number to check is it fizz or buzz");

//int num;

//bool success = int.TryParse(Console.ReadLine(), out num);


//if (!success)
//{
//    Console.WriteLine("Invalid number");

//}

//else if (num % 5 == 0 && num % 3 == 0)
//{
//    Console.WriteLine("Fizz buzz");
//}
//else if (num % 5 == 0)
//{
//    Console.WriteLine("Fizz");
//}
//else if(num % 3 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else
//{
//    Console.WriteLine(num);
//}

// Average calculator


double totalsubjects = 5.0;
Console.WriteLine("Enter your grades");

Console.WriteLine("Enter your first subject");


double subject1score =  double.Parse(Console.ReadLine());



Console.WriteLine("Enter your second subject");


double subject2score = double.Parse(Console.ReadLine());




Console.WriteLine("Enter your first subject");


double subject3score = double.Parse(Console.ReadLine());




Console.WriteLine("Enter your first subject");



double subject4score = double.Parse(Console.ReadLine());



Console.WriteLine("Enter your first subject");



double subject5score = double.Parse(Console.ReadLine());





double average = ((subject1score + subject2score + subject3score + subject4score + subject5score) / totalsubjects);


Console.WriteLine($"Your average is {average}");






















// For loop

//string mystring = "Hello \r hi";
//for(int counter =  10; counter > 0 ; counter--)
//{
//    Console.WriteLine(counter);
//    Console.WriteLine(mystring);
//    Thread.Sleep(1000);

//    // playing for or freezing console
//}


// Rocket takeoff

//string mystring = "Rocket \n taking off";



//for(int counter = 10; counter > 0; counter--)
//{

//    Console.Clear();
//    Console.WriteLine(counter);

//    Console.WriteLine(mystring);
//    Thread.Sleep(1000);



//}
//Console.WriteLine("Blastoff");

//Console.ReadKey();

int i = 0;
while(i < 5){

    Console.WriteLine(i);

    Console.ReadKey(); 
}