using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ellipsoid: Ball
    {
        public Ellipsoid(double[] coefficients, double radius) : base(coefficients, radius)
        {
            // Конструктор класу Ellipsoid викликає конструктор базового класу Ball
        }

        // Перевантажуємо метод задання відповідних коефіцієнтів
        public new void SetCoefficients(double[] coefficients)
        {
            // Ми використовуємо ключове слово "new", щоб вказати, що перевизначаємо метод базового класу
            base.SetCoefficients(coefficients); // Викликаємо метод базового класу для встановлення коефіцієнтів
        }

        // Перевантажуємо метод виведення відповідних коефіцієнтів на екран
        public new void DisplayCoefficients()
        {
            // Ми використовуємо ключове слово "new", щоб вказати, що перевизначаємо метод базового класу
            base.DisplayCoefficients(); // Викликаємо метод базового класу для виведення коефіцієнтів
        }

        // Метод для обчислення об'єму еліпсоїда
        public double CalculateVolume()
        {
            // Тут ви можете реалізувати формулу для обчислення об'єму еліпсоїда
            // Наприклад, формула для об'єму еліпсоїда може бути складнішою і залежати від його параметрів
            double volume = 0.0; // Реалізуйте розрахунок об'єму за вашою формулою
            return volume;
        }
    }
}
