//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    internal class Todolist
//    {

//        static List<string> todoList = new List<string>();
        


//        static string addList(string text)
//        {
//            todoList.Add(text);
//            return "Successfully added";
//        }


//        static int removelist(int index)
//        {
//            todoList.RemoveAt(index);
//            return 1;
//        }

//      static  string updateList(string text, int indexes)
//        {
//            todoList[indexes] = text;
//            return "Updated";

//        }


//        static string displaylist()
//        {
//            foreach (string item in todoList)
//            {
//                Console.WriteLine(item);
//            }
//            return "List displayed";
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to do list app do you want to add or remove or read or update the list");
           

//            bool running = true;
//            while (running)
//            {
//                Console.WriteLine("1. for adding");
//                Console.WriteLine("2. Removing");
//                Console.WriteLine("3. Updating");
//                Console.WriteLine("4. Reading");
//                Console.WriteLine("5. Exit");


//                string inputed = Console.ReadLine();


//                switch(inputed) {



//                    case "1":
//                        Console.WriteLine("Input");

//                        string x = Console.ReadLine();
//                        addList(x);
//                        break;
                     

//                    case "2":
//                    Console.WriteLine("Input");
//                     int cx = int.Parse(Console.ReadLine());
//                        removelist(cx);
//                     break;

//                    case "3":
//                        Console.WriteLine("update list");

//                        displaylist();

//                        Console.WriteLine("Update at which number ");
//                        int z = int.Parse(Console.ReadLine());
//                        string xy = Console.ReadLine();
//                        updateList(xy, z);
//                        break;


//                    case "4":
//                        displaylist();
//                        break;

//                    case "5":
//                        running = false;
//                        break;

//                    default:
//                        Console.WriteLine("please try again");
//                        break;

//                }







//            }
//    }
//}
