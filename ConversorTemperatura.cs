public static class ConversorTemperatura
{
    public static double CelciusToFahrenheit(double num)
    {
        return (num * 9/5) + 32;
    }

    public static double FahrenheitToCelcius(double num)
    {
        return (num-32) * 5/9;
    }

}