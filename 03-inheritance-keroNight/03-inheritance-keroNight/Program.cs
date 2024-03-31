using _03_inheritance_keroNight;

var linearFunc = new LinearFunction();
linearFunc.SetCoefficients(2, 3);
linearFunc.DisplayCoefficients();
Console.WriteLine("Value at x = 5: " + linearFunc.CalculateValue(5));

var poly = new Polynomial();
poly.SetCoefficients(1);
poly.DisplayCoefficients();
Console.WriteLine("Value at x = 5: " + poly.CalculateValue(5));