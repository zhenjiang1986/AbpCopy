using System;
using System.Reflection;

namespace Volo.MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var fields = typeof(People).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);


            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("----------");
            var stuendtFields = typeof(Student).GetFields(BindingFlags.Public | BindingFlags.Static| BindingFlags.FlattenHierarchy);


            foreach (var field in stuendtFields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("----------");
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }



    public class People
    {

        public const string PeopleConst = "PeopleConst";

        public static string PeopleStatic = "PeopleStatic";

    }

    public class Student : People
    {
        public const string StudentConst = "StudentConst";

        public static string StudentStatic = "StudentStatic";

    }




}
