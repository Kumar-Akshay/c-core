using System;

namespace ParseText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "John.Davidson/Berlin Michael.Barton/Lisbon Ivan.Perkinson/Moscow";
            string[] words=text.Split(' ');

            Person[] persons=new Person[words.Length];
            
            for(int i=0;i<words.Length;i++)
            {
                string[] personAndCity=words[i].Split('/');
                string[] nameAndSurName=personAndCity[0].Split('.');    
                Person person=new Person
                {
                    Name=nameAndSurName[0],
                    SurName=nameAndSurName[1],
                    City=personAndCity[1]
                };
                persons[i]=person;
            }
            
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} {item.SurName} {item.City}");
            }
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
    }
}
