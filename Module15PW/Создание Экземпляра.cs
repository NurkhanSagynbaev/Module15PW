using System;

class MyClass
{
    public int PublicProperty { get; set; }
}

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);
        object myObject = Activator.CreateInstance(myClassType);

        // Проверка созданного экземпляра
        if (myObject is MyClass instance)
        {
            Console.WriteLine($"Создан экземпляр MyClass с PublicProperty = {instance.PublicProperty}");
        }
    }
}
