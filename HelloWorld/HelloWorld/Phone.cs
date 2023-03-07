using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    //<summary>
    //1. Класс Phone.
    //Создайте класс Phone, который содержит переменные number, model и  weight.
    //Создайте три экземпляра этого класса.
    //Выведите на консоль значения их переменных.  
    //Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит { name}”. getNumber –  возвращает номер телефона.Вызвать эти методы для каждого из  объектов.
    //Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и  weight.
    //Добавить конструктор, который принимает на вход два параметра для  инициализации переменных класса - number, model.
    //Добавить конструктор без параметров.
    //Вызвать из конструктора с тремя параметрами конструктор с двумя.  Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.
    //Создать метод sendMessage с аргументами переменной длины.Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.
    //</summary>
    internal class Phone
    {
        public string number;
        public string model;
        public double weigh;

        public void GetInfo()
        {
            Console.WriteLine($"Number is {number}, model is {model}, weigh is {weigh}.");
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }

        public void ReceiveCall(string name, string number)
        {
            Console.WriteLine($"Call from {name}, number is {number}");
        }

        public static void SendMessage(params string[] numbers)
        {
            foreach (string i in numbers)
            {
                Console.WriteLine($"Number is {i}.");
            }
        }

        public string GetNumber(string number)
        {
            return number;
        }

        public Phone(string number, string model, double weigh) : this(number, model)
        {
            this.weigh = weigh;
        }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone()
        {
        }
    }
}
