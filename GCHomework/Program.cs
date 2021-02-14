using System;

namespace GCHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------1-----------------------
            var consoleType = typeof(Console);
            foreach (var method in consoleType.GetMethods())
            {
                Console.Write($"{method.Name}");

                Console.Write("(");
                foreach (var parameter in method.GetParameters())
                {
                    Console.Write($" {parameter.ParameterType}->{parameter.Name} ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();

            //-----------------------2-----------------------
            var student = new Student()
            {
                Id = 1,
                Name = "Andrey",
                Group = "SEP-201",
                AverageMark = 11.2
            };

            foreach (var property in typeof(Student).GetProperties())
            {
                Console.WriteLine($"{property.Name} = {property.GetValue(student)}");
            }
        }
    }
}
