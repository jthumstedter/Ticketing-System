﻿using System.Data.Common;

namespace Ticketing_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "tickets.csv";
            string choice;
            do
            {
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Input new data into file.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    OutputFileInformation(file);
                }
                else if (choice == "2")
                {
                    InputNewFileInfomation(file);
                }

            } while (choice == "1" || choice == "2");
        }

        private static void InputNewFileInfomation(string file)
        {
            StreamWriter sw = new StreamWriter(file, true);
            while (true)
            {
                Console.WriteLine("Enter a new ticket (Y/N)?");
                var response = Console.ReadLine().ToUpper();

                if (response != "Y")
                {
                    break;
                }

                Ticket newTicket = new Ticket();

                sw.WriteLine(newTicket.GenerateTicketLine());
            }
            sw.Close();
        }

        private static void OutputFileInformation(string file)
        {
            Console.WriteLine();
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    
                    var row = sr.ReadLine();
                    string[] columns = row.Split(',');
                    for (int i = 0; i < columns.Length; i++)
                    {
                        Console.Write($"{columns[i]} ");
                    }
                    Console.WriteLine();
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            Console.WriteLine();
        }
    }
}