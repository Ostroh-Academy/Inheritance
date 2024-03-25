namespace ConsoleApp2;

internal class Human(string firstName, string middleName, string lastName, DateOnly birthDate)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string FirstName { get; private set; } = firstName;
    public string MiddleName { get; private set; } = middleName;
    public string LastName { get; private set; } = lastName;
    public DateOnly BirthDate { get; private set; } = birthDate;

    public void UpdateData(string firstName, string middleName, string lastName, DateOnly birthDate)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        BirthDate = birthDate;
    }
    
    public int GetHumanAge()
    {
        var currentDate = DateTime.UtcNow.Date;
        return currentDate.Year - birthDate.Year;
    }

    public int GetLetterMatchesAmountFromLastName(char letter)
    {
        return LastName.Count(t => t == letter);
    }
        
}