using System;

public class MayanCalendarConverter
{
    public static void Main()
    {
        // Example usage:
        DateTime gregorianDate = new DateTime(2023, 4, 28);
        string tzolkinDate = ConvertToTzolkin(gregorianDate);
        Console.WriteLine("Mayan Tzolk'in date: " + tzolkinDate);
    }

    public static string ConvertToTzolkin(DateTime gregorianDate)
    {
        DateTime startDate = new DateTime(2023, 04, 28); // Gregorian date corresponding to Tzolk'in 1 Imix
        
        int totalDays = (gregorianDate - startDate).Days;
        int tzolkinNumber = (totalDays % 13) + 1;
        int tzolkinIndex = (totalDays % 20);

        string[] daySigns = { "Imix", "Ik'", "Ak'b'al", "K'an", "Chikchan", "Kimi", "Manik'", "Lamat", "Muluk", "Ok", "Chuwen", "Eb'", "B'en", "Ix", "Men", "K'ib'", "Kab'an", "Etz'nab'", "Kawak", "Ajaw" };

        string tzolkinDate = tzolkinNumber + " " + daySigns[tzolkinIndex];
        return tzolkinDate;
    }
}
