// See https://aka.ms/new-console-template for more information

using Lab2_25;

internal class Program
{
    public static void Main(string[] args)
    {
        double[,] coefficients2x2 = new double[,] { { 2, 3 }, { 4, 5 } };
        double[] freeTerms2x2 = new double[] { 7, 11 };

     
        double[,] coefficients3x3 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[] freeTerms3x3 = new double[] { 6, 15, 24 };


        double[] x2x2 = new double[] { 1, 2 };
        double[] x3x3 = new double[] { 1, 2, 3 };

 
        SystemOfEquations system2x2 = new SystemOfEquations(coefficients2x2, freeTerms2x2);
        LinearEquation system3x3 = new LinearEquation(coefficients3x3, freeTerms3x3);


        Console.WriteLine("Система рівнянь 2х2:");
        system2x2.PrintEquationSystem();

        Console.WriteLine("СЛАР 3х3:");
        system3x3.PrintEquationSystem();
       

        Console.WriteLine($"Вектор x = ({x2x2[0]}, {x2x2[1]}) {(system2x2.CheckVectorSatisfies(x2x2) ? "задовольняє" : "не задовольняє")} системі рівнянь 2х2.");
        Console.WriteLine($"Вектор x = ({x3x3[0]}, {x3x3[1]}, {x3x3[2]}) {(system3x3.CheckVectorSatisfies(x3x3) ? "задовольняє" : "не задовольняє")} СЛАР 3х3.");
    }
}