namespace Program
{
    class number
    {
        public double value;
        public string unit;

        // Temperature
        public void ConvertCelsiusToFarh(double n)
        {
            value = (n * 9 / 5) + 32; // (0°C × 9/5) + 32 = F
            unit = "fahrenheit";
        }
        public void ConvertFarhToCelsius(double n)
        {
            value = (n - 32) * 5 / 9; // (32°F − 32) × 5/9 = 0°C
            unit = "fahrenheit";
        }
        // Currency
        public void ConvertPoundsToDollars(double n)
        {
            value = n * 1.22;
            unit = "dollars";
        }
        public void ConvertDollarsToPounds(double n)
        {
            value = n * 0.82;
            unit = "pounds";
        }
        // Volume
        public void ConvertCubicMetreToCubicCentimetre(double n)
        {
            value = n * 1000000;
            unit = "cm3";
        }
        public void ConvertCubicCentimetreToCubicMetre(double n)
        {
            value = n / 1000000;
            unit = "m3";
        }
    }
}