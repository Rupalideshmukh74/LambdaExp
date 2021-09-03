using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticingLamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LamdaExpression!");
            List<Person> ListPersonsInCity = new List<Person>();

            AddRecords(ListPersonsInCity);
            Retriving_TopTwoRecords_ForAgeIs_LessThanSixty(ListPersonsInCity);
            checkingForTeenagerPerson(ListPersonsInCity);

        }
        private static void AddRecords(List<Person> ListPersonsInCity)
        {
            ListPersonsInCity.Add(new Person("243856769", "John", "12 Main Street", 25));
            ListPersonsInCity.Add(new Person("243856745", "Sam", "13 Main Street", 26));
            ListPersonsInCity.Add(new Person("243856756", "Rose", "15 Main Street", 14));
            ListPersonsInCity.Add(new Person("243856777", "Urvashi", "11 Main Street", 26));
            ListPersonsInCity.Add(new Person("243856733", "Pankaj", "15 Main Street", 28));
            ListPersonsInCity.Add(new Person("243856722", "Rupali", "22 Main Street", 29));
           // Console.WriteLine(ListPersonsInCity.ToString());
        }
        private static void Retriving_TopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach(Person person in listPersonInCity.FindAll(e =>(e.Age<60)).Take(2).ToList())
            Console.WriteLine("Name : " + person.Name + "\t\tAge: " + person.Age);
        }
        private static void checkingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age == 13 && e.Age < 19)))
                {
                Console.WriteLine("Yes, We have teen-ager in the list");
            }
            else
            {
                Console.WriteLine("no we dont have teen-ager in the list");
            }

        }
    }
}
