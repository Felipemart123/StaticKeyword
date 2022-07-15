

namespace StaticKeyword
{
    class program
    {
        static void Main(String[] args)
        {
            var celsius = TempConerter.FarenheightTocelsius(10);
            var Farenheight = TempConerter.celsiusToFarenheight(100);

            Console.WriteLine( celsius);
            Console.WriteLine(Farenheight);
        }


    }

}
