using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Chiefvilla", "Abidjan", "52345");
        Address receptionAddress = new Address("456 Elm St", "Leggon", "Kumasi", "67890");
        Address outdoorAddress = new Address("1045 Arugungu Riverside", "Arugungu", "Sokoto", "611006");

        Lecture lecture = new Lecture("C# Programming", "A comprehensive lecture on C#.", DateTime.Now.AddDays(10), "10:00 AM", lectureAddress, "Benjamin Kofo", 100);
        Reception reception = new Reception("ALX Networking Event", "An event to network with professionals.", DateTime.Now.AddDays(15), "6:00 PM", receptionAddress, "rsvp@techhub.com");
        OutdoorGathering outdoor = new OutdoorGathering("Arugungu Fishing Festival", "An annual open water fishing festival with huge numbers of participants.", DateTime.Now.AddDays(20), "1:00 PM", outdoorAddress, "Sunny");

        Console.WriteLine("Lecture Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nLecture Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nLecture Short Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nReception Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nReception Short Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Standard Details:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("\nOutdoor Gathering Full Details:");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering Short Description:");
        Console.WriteLine(outdoor.GetShortDescription());
    }
}