using System;
using System.Reflection;

namespace Module15PW
{
    internal class MyClass
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Вызван приватный метод!");
        }
    }

    class Program
    {
        static void Main()
        {
            Type myClassType = typeof(MyClass);
            object myObject = Activator.CreateInstance(myClassType);

            // Вызов приватного метода
            myClassType.GetMethod("PrivateMethod", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(myObject, null);
        }
    }
}