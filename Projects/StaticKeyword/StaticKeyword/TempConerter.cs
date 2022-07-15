using System;
namespace StaticKeyword
{
    public static class TempConerter
    {
        public static double FarenheightTocelsius(double Farenheight)
        {
            return (Farenheight - 32 / 1.8);
        }

        public static double celsiusToFarenheight (double celsius)
        {
            return (celsius * 9 / 37);
        }

    }
}

