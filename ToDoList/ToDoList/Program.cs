using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        public string taskName;
        public string taskOption;

        static List<string> taskList = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your To-Do List!");
            Console.WriteLine("Please choose one of the options below:");
            Console.WriteLine("1: Add a Task");
            Console.WriteLine("2: View all Tasks");
            Console.WriteLine("3: Complete a task");
            Console.WriteLine("4: Delete a Task");
            Console.WriteLine("5: Exit");


                switch (Console.ReadLine())
                {
                    case "1":
                        AddTask();
                        break;

                    case "2":
                        ViewTask();
                        break;

                    case "3":
                        CompleteTask();
                        break;

                    case "4":
                        DeleteTask();
                        break;

                    case "5":
                        ExitProgram();
                        break;

                    default:
                        Console.WriteLine("Please choose the correct option.");
                       
                        break;
                }

        }

        static void AddTask()
        {
            Console.WriteLine("Please enter your task details.");
            taskList.Add(Console.ReadLine());
        }

        static void ViewTask()
        {
            Console.WriteLine("Viewing all tasks:");
        }

        static void CompleteTask()
        { 
            Console.WriteLine("Please select which task you want to complete.");
        }

        static void DeleteTask() 
        {
            Console.WriteLine("Please select which task you want to delete.");
            taskList.Remove(Console.ReadLine());
        }

        static void ExitProgram()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}