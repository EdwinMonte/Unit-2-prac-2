using System;

public class Converter
{
    private const double MilesToKmRatio = 1.60934;

    public double ConvertMilesToKm(double miles)
    {
        return miles * MilesToKmRatio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter();
        double miles = 10;
        double km = converter.ConvertMilesToKm(miles);
        Console.WriteLine("{0} miles is equal to {1} kilometers", miles, km);
    }
}
