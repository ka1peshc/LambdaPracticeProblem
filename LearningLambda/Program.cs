using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Person> listPersonInCity = new List<Person>();
            AddRecord(listPersonInCity);
            Retrieving_top_two_Record(listPersonInCity);
            CheckIfAnyRecordInBetween(listPersonInCity);
            AverageAge(listPersonInCity);
            skipAge(listPersonInCity);
        }

        private static void AddRecord(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("230219971", "Luffy", "Goa Kingdom, East blue", 67));
            listPersonInCity.Add(new Person("230219972", "Zoro", "Shimotsuki, East blue", 20));
            listPersonInCity.Add(new Person("230219973", "Nami", "Cocoyasi, East blue", 18));
            listPersonInCity.Add(new Person("230219974", "Usopp", "Syrup , East blue", 17));
            listPersonInCity.Add(new Person("230219975", "Chopper", "Drum Island,Grand line", 12));
            listPersonInCity.Add(new Person("230219976", "Sanji", "Germa66,North Island", 63));
            listPersonInCity.Add(new Person("230219977", "Yamato", "Wano, New world", 18));
        }

        private static void Retrieving_top_two_Record(List<Person> listPersonInCity)
        {
            foreach (Person p in listPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: {0} Age: {1}", p.Name, p.Age);
            }
        }

        private static void CheckIfAnyRecordInBetween(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age > 12 && e.Age <= 18)))
            {
                Console.WriteLine("There exists records");
            }
            else
            {
                Console.WriteLine("No records found");
            }
        }

        private static void AverageAge(List<Person> listPersonInCity)
        {
            Console.WriteLine("Average age is {0}", listPersonInCity.Average(e => e.Age));
        }

        private static void skipAge(List<Person> listPersonInCity)
        {
            var resultlist = listPersonInCity.SkipWhile(e => (e.Age < 60));
            foreach (Person p in resultlist)
            {
                Console.WriteLine("Name: {0} Age: {1}", p.Name, p.Age);
            }
        }
    }
}
