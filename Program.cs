using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new record();
            Class1 cc = new Class1();
            
            a.addRecord(new Class1() { Name = "Khubaib", nbr=13245});
            a.addRecord(new Class1() { Name = "Khalid", nbr = 13245 });
            a.addRecord(new Class1() { Name = "Ali", nbr = 7894651 });
            a.addRecord(new Class1() { Name = "Bashir", nbr = 13245 });
            a.addRecord(new Class1() { Name = "Usama", nbr = 13245 });
            a.showRecord();
            
            //a.updateRecord("Khalid", new Class1 {Name= "xyz"});
            //a.searchRecord("Ali");

            Console.WriteLine();
            Console.WriteLine("After removing a record");
            a.removeRecord("Khubaib");
            a.showRecord();

            Console.WriteLine();
            Console.WriteLine("Updating a record and showing it in sorted form");
            a.updateRecord("Khalid", new Class1 { Name = "xyz" });
            a.showRecord();
            
            Console.WriteLine();
            Console.WriteLine("Searching a record");
            a.searchRecord("Ali");


        }
    }
    
}
