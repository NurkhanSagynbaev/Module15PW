using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Module15PW
{
    class MyClass
    {
        public int PublicProperty { get; set; }
        private string PrivateField;

        public MyClass() { }
        public MyClass(int value) { }
        private MyClass(string value) { }

        public void PublicMethod() { }
        private void PrivateMethod() { }
    }

    class Program
    {
        static void Main()
        {
            Type myClassType = typeof(MyClass);

            Console.WriteLine($"Имя класса: {myClassType.Name}");

            Console.WriteLine("\nКонструкторы:");
            foreach (var constructor in myClassType.GetConstructors())
            {
                Console.WriteLine(constructor);
            }

            Console.WriteLine("\nПоля и свойства:");
            foreach (var field in myClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine($"Имя: {field.Name}, Тип: {field.FieldType}, Модификатор доступа: {field.Attributes}");
            }

            foreach (var property in myClassType.GetProperties())
            {
                Console.WriteLine($"Имя: {property.Name}, Тип: {property.PropertyType}, Модификатор доступа: {property.Attributes}");
            }

            Console.WriteLine("\nМетоды:");
            foreach (var method in myClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine($"Имя: {method.Name}, Возвращаемый тип: {method.ReturnType}, Модификатор доступа: {method.Attributes}");
            }
        }
    }
}
