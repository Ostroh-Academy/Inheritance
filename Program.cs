using static Practice_2.Program;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinearSystem2D equation1 = new LinearSystem2D([2, 7], [-2, 3], [20, 0]);
            Console.WriteLine(equation1);
            double[] vector = {3, 2};
            equation1.IsSatisfiedByVector(vector);

            double[] linearVector = {3, -2, 1};
            LinearSystem3D linearSystem = new LinearSystem3D([0,0,0], [6, -4, 5], [5, 2, 2],[2, 31, 13]);
            Console.WriteLine(linearSystem);
            linearSystem.IsSatisfiedByVector(linearVector);


        }
        public class LinearSystem2D
        {
            public List<double> Coefficients1 { get; set; }
            public List<double> Coefficients2 { get; set; }
            public List<double> ConstantTerms { get; set; }
            public LinearSystem2D(List<double> coef1, List<double> coef2, List<double> constantTerms)
            {
                Coefficients1 = coef1;
                Coefficients2 = coef2;
                ConstantTerms = constantTerms;
            }
            public override string ToString()
            {
                string equationString1 = "";
                for (int i = 0; i < Coefficients1.Count; i++)
                {
                    if (Coefficients1[i] != 0)
                    {
                        if (i < Coefficients1.Count - 1 && Coefficients1[i + 1] < 0)
                        {
                            equationString1 += $"{Coefficients1[i]}x{i + 1} ";
                        }
                        else if (i < Coefficients1.Count - 1)
                        {
                            equationString1 += $"{Coefficients1[i]}x{i + 1} + ";
                        }
                        else
                        {
                            equationString1 += $"{Coefficients1[i]}x{i + 1} ";
                        }
                    }
                    else
                    {
                        if (i < Coefficients1.Count - 1)
                        {
                            equationString1 += $"x{i + 1} + ";
                        }
                        else
                        {
                            equationString1 += $"x{i + 1} ";
                        }
                    }
                }
                equationString1 += $"= {ConstantTerms[0]}";
                string equationString2 = "";
                for (int i = 0; i < Coefficients2.Count; i++)
                {
                    if (Coefficients2[i] != 0)
                    {
                        if (i < Coefficients2.Count - 1 && Coefficients2[i + 1] < 0)
                        {
                            equationString2 += $"{Coefficients2[i]}x{i + 1} ";
                        }
                        else if (i < Coefficients2.Count - 1)
                        {
                            equationString2 += $"{Coefficients2[i]}x{i + 1} + ";
                        }
                        else
                        {
                            equationString2 += $"{Coefficients2[i]}x{i + 1} ";
                        }
                    }
                    else
                    {
                        if (i < Coefficients2.Count - 1)
                        {
                            equationString2 += $"x{i + 1} + ";
                        }
                        else
                        {
                            equationString2 += $"x{i + 1} ";
                        }
                    }
                }
                equationString2 += $"= {ConstantTerms[1]}";
                string totalEquations = $"{equationString1 + '\n' + equationString2}";
                return totalEquations;
            }
            public virtual bool IsSatisfiedByVector(double[] vector)
            {
                if (vector.Count() == 0)
                {
                    Console.WriteLine("Type vector coordinates");
                    Console.WriteLine("Enter x1 coordinate:");
                    vector[0] = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter x2 coordinate:");
                    vector[1] = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"x1 coordinate: {vector[0]}, x2 coordinate: {vector[1]}");

                }
                if (vector == null || vector.Length != 2)
                {
                    throw new ArgumentException("Vector size must match the number of variables in the equation");
                }

                double result1 = 0;
                double result2 = 0;
                int index = 0;
                for (int i = 0; i < Coefficients1.Count; i++)
                {
                    result1 += Coefficients1[i] * vector[index];
                    index++;
                }
                index = 0;
                for (int i = 0; i < Coefficients2.Count; i++)
                {
                    result2 += Coefficients2[i] * vector[index];
                    index++;
                }
                if (result1 == ConstantTerms[0] && result2 == ConstantTerms[1])
                {
                    Console.WriteLine("True"+'\n');
                    return true;
                }
                Console.WriteLine("False" + '\n');
                return false;
            }
        }
        public class LinearSystem3D : LinearSystem2D
        {
            public double Coefficient1{get;set;}
            public double Coefficient2{get;set;}
            public List<double> Coefficients3 { get; set; }
            public double ConstantTerm3 { get; set; }

            public LinearSystem3D(List<double> coef1, List<double> coef2, List<double> coef3,
                                  List<double> constantTerms) : base(coef1, coef2, constantTerms)
            {
                Coefficient1 = coef1[2];
                Coefficient2 = coef2[2];
                Coefficients3 = coef3;
                ConstantTerm3 = constantTerms[2];
            }

            public override string ToString()
            {
                string equationString1 = base.ToString().Split('\n')[0];
                string equationString2 = base.ToString().Split('\n')[1];

                string equationString3 = "";
                for (int i = 0; i < Coefficients3.Count; i++)
                {
                    if (Coefficients3[i] != 0)
                    {
                        if (i < Coefficients3.Count - 1 && Coefficients3[i + 1] < 0)
                        {
                            equationString3 += $"{Coefficients3[i]}x{i + 1} ";
                        }
                        else if (i < Coefficients3.Count - 1)
                        {
                            equationString3 += $"{Coefficients3[i]}x{i + 1} + ";
                        }
                        else
                        {
                            equationString3 += $"{Coefficients3[i]}x{i + 1} ";
                        }
                    }
                    else
                    {
                        if (i < Coefficients3.Count - 1)
                        {
                            equationString3 += $"x{i + 1} + ";
                        }
                        else
                        {
                            equationString3 += $"x{i + 1} ";
                        }
                    }
                }
                equationString3 += $"= {ConstantTerm3}";

                string totalEquations = $"{equationString1}\n{equationString2}\n{equationString3}";
                return totalEquations;
            }

            public virtual bool IsSatisfiedByVector(double[] vector)
            {
                if(vector.Count() == 0)
                {
                    Console.WriteLine("Type vector coordinates");
                    Console.WriteLine("Enter x1 coordinate:");
                    vector[0] = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter x2 coordinate:");
                    vector[1] = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter x3 coordinate:");
                    vector[2] = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"x1 coordinate: {vector[0]}, x2 coordinate: {vector[1]}, x3 coordinate: {vector[2]}");
                }
                if (vector == null || vector.Length != 3)
                {
                    throw new ArgumentException("Vector size must match the number of variables in the equation");
                }

                double result1 = 0;
                double result2 = 0;
                double result3 = 0;
                int index = 0;
                for (int i = 0; i < Coefficients1.Count; i++)
                {
                    if (Coefficients1[i] == 0)
                    {
                        result1 += vector[index];
                    }
                    else
                    {
                        result1 += Coefficients1[i] * vector[index];
                    }
                    index++;
                }
                index = 0;
                for (int i = 0; i < Coefficients2.Count; i++)
                {
                    if (Coefficients2[i] == 0)
                    {
                        result1 += vector[index];
                    }
                    else
                    {
                        result2 += Coefficients2[i] * vector[index];
                    }
                    index++;
                }
                index = 0;
                for (int i = 0; i < Coefficients3.Count; i++)
                {
                    if(Coefficients3[i] == 0)
                    {  
                        result3 += vector[index]; 
                    }
                    else
                    {
                        result3 += Coefficients3[i] * vector[index];
                    }
                    index++;
                }
                if (result1 == ConstantTerms[0] && result2 == ConstantTerms[1] && result3 == ConstantTerms[2])
                {
                    Console.WriteLine("True" + '\n');
                    return true;
                }
                Console.WriteLine("False" + '\n');
                return false;
            }

        }
    }
}
