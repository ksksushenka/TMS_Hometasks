using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Hometasks.Hometask_Lesson6.Task1;
using TMS_Hometasks.Hometask_Lesson6.Task2;

namespace TMS_Hometasks.Hometask_Lesson6
{
    internal class Lesson6
    {
        public static void Lesson6_task1()
        {
            Figure figure1 = new FigureBuilder().CreateTriangle(3, 4, 5);
            Figure figure2 = new FigureBuilder().CreateTriangle(4, 4, 5);
            Figure figure3 = new FigureBuilder().CreateTriangle(5, 5, 5);
            Figure figure4 = new FigureBuilder().CreateTriangle(4, 2, 3);
            Figure figure5 = new FigureBuilder().CreateRectangle(2, 3);
            Figure figure6 = new FigureBuilder().CreateRectangle(3, 3);

            Console.WriteLine(figure1.GetSquare());
            Console.WriteLine(figure2.GetSquare());
            Console.WriteLine(figure3.GetSquare());
            Console.WriteLine(figure4.GetSquare());
            Console.WriteLine(figure5.GetSquare());
            Console.WriteLine(figure6.GetSquare());
            Console.WriteLine("\n");

            var figures = new Figure[] { figure1, figure2, figure3, figure4, figure5, figure6 };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetSquare());
            }
        }

        public static void Lesson6_task2()
        {
            Person patient = new Patient("Alex", "Ivanov", "patient");
            Person doctor = new TreatmentPlan().GetTreatmentPlan("Ivan", "Petrov", "surgeon", 1);

            Console.WriteLine($"{patient.firstName} {patient.lastName} your doctor is {doctor.post} {doctor.firstName} {doctor.lastName}. {doctor.Treatment()}");
        }
    }
}
