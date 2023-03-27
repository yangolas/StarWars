namespace StarWars.Domain;

public static class ValidateInput
{
    public static void Validate(IReadOnlyList<uint> list) 
    {
        if (
            list == null 
            || list.Count() == 0
        ) 
        { 
             throw new ArgumentNullException("Sorry, input value is incorrect");
        }
    }
}
