using ConsoleApp2;

var human = new Human("very", "funny", "guy", new DateOnly(1984, 10, 31));

var student = new Student("very", "funny", "guy", new DateOnly(1984, 10, 31), DateTime.Now.Year);

var humanAge = human.GetHumanAge();

var letterMatchesAmount = student.GetLetterMatchesAmountFromLastName('u');

Console.ReadKey();