using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneBook
{
    class record
    {
        public List<Class1> _class1 { get; set; }
        public record()
        {
            _class1 = new List<Class1>();
        }

        public void addRecord(Class1 c1)
        {
            _class1.Add(c1);

        }

        public void removeRecord(string name)
        {
            var record = _class1.FirstOrDefault(x=>x.Name == name);
            _class1.Remove(record);
        }
        public void updateRecord(string name, Class1 c1)
        {
            var record = _class1.FirstOrDefault(x => x.Name == name);
            record.Name = c1.Name;

        }
        public void searchRecord(string name)
        {
            var record = _class1.FirstOrDefault(x => x.Name == name);
            Console.WriteLine(record.Name+" "+record.nbr);
        }
        public void showRecord()
        {
            //_class1.Sort();
            List<Class1> SortedList = _class1.OrderBy(x => x.Name).ToList();
            foreach (var c1 in SortedList)
            {
                Console.WriteLine(c1.Name+" "+c1.nbr);
            }
        }

    }
}
