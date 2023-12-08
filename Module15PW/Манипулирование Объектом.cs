using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15PW
{
    class MyClass
    {
        public int PublicProperty { get; set; }

        public void ModifyState()
        {
            PublicProperty = 42;
        }
    }

    class Program
    {
        static void Main()
        {
            Type myClassType = typeof(MyClass);
            object myObject = Activator.CreateInstance(myClassType);

            // Изменение значения свойства
            myClassType.GetProperty("PublicProperty")?.SetValue(myObject, 100);

            // Вызов метода
            myClassType.GetMethod("ModifyState")?.Invoke(myObject, null);

            // Проверка измененного состояния
            if (myObject is MyClass instance)
            {
                Console.WriteLine($"Свойство PublicProperty после манипуляций: {instance.PublicProperty}");
            }
        }
    }

}
