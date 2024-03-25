namespace ConsoleApp2;

internal class Student(string firstName, string middleName, string lastName, DateOnly birthDate, int entryYear)
    : Human(firstName, middleName, lastName, birthDate)
{
    public int EntryDate { get; private init; } = entryYear;
}