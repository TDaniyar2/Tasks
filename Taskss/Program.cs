/*using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор");

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оператор (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':

                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль!");
                        return;
                    }
                    break;
            }

            Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
        }
    }
}*/



/*using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Вывести список задач");
            Console.WriteLine("5. Выйти");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    RemoveTask();
                    break;
                case 3:
                    CompleteTask();
                    break;
                case 4:
                    PrintTasks();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите от 1 до 5.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Введите новую задачу:");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("Задача добавлена успешно.");
    }

    static void RemoveTask()
    {
        Console.WriteLine("Введите номер задачи для удаления:");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;
        if (taskNumber >= 0 && taskNumber < tasks.Count)
        {
            tasks.RemoveAt(taskNumber);
            Console.WriteLine("Задача удалена успешно.");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    static void CompleteTask()
    {
        Console.WriteLine("Введите номер выполненной задачи:");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;
        if (taskNumber >= 0 && taskNumber < tasks.Count)
        {
            Console.WriteLine($"Задача \"{tasks[taskNumber]}\" выполнена.");
            tasks.RemoveAt(taskNumber);
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    static void PrintTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}*/


/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите температуру:");
        double temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите единицы измерения:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Фаренгейт");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            double fahrenheit = CelsiusToFahrenheit(temperature);
            Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}°F");
        }
        else if (choice == 2)
        {
            double celsius = FahrenheitToCelsius(temperature);
            Console.WriteLine($"Температура в Цельсиях: {celsius}°C");
        }
        else
        {
            Console.WriteLine("Неверный выбор единиц измерения.");
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}*/


/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();


        int characterCount = inputString.Length;
        Console.WriteLine($"Количество символов: {characterCount}");


        Console.WriteLine("Введите подстроку для замены:");
        string oldSubstring = Console.ReadLine();
        Console.WriteLine("Введите новую подстроку:");
        string newSubstring = Console.ReadLine();
        string replacedString = inputString.Replace(oldSubstring, newSubstring);
        Console.WriteLine($"Строка после замены: {replacedString}");


        string[] words = inputString.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Слова в строке:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


    }
}
*/



/*using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Book book1 = new Book("Война и мир", "Лев Толстой", 1869);
        Book book2 = new Book("Преступление и наказание", "Федор Достоевский", 1866);
        Book book3 = new Book("1984", "Джордж Оруэлл", 1949);


        Console.WriteLine($"Название: {book1.Title}, Автор: {book1.Author}, Год выпуска: {book1.Year}");
        Console.WriteLine($"Название: {book2.Title}, Автор: {book2.Author}, Год выпуска: {book2.Year}");
        Console.WriteLine($"Название: {book3.Title}, Автор: {book3.Author}, Год выпуска: {book3.Year}");
    }
}*/


/*using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        Thread thread1 = new Thread(DoWork);
        Thread thread2 = new Thread(DoWork);

        thread1.Start("Поток 1");
        thread2.Start("Поток 2");

        Console.ReadLine();
    }

    static void DoWork(object data)
    {
        string threadName = (string)data;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{threadName} выполняет работу {i}");
            Thread.Sleep(1000);
        }
    }
}*/


/*using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        var evenNumbers = numbers.Where(n => n % 2 == 0); 
        var sortedNumbers = numbers.OrderBy(n => n); 
        var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Четные" : "Нечетные");


        Console.WriteLine("Четные числа:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nЧисла, отсортированные по возрастанию:");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nГруппировка чисел по четности:");
        foreach (var group in groupedNumbers)
        {
            Console.WriteLine(group.Key);
            foreach (var number in group)
            {
                Console.WriteLine(number);
            }
        }
    }
}*/