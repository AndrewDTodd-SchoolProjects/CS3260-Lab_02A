namespace MinMaxValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integer numeric types

            //signed byte min max
            Console.WriteLine($"signed byte minimum value: {sbyte.MinValue}, signed byte maximum value: {sbyte.MaxValue}\n");
            //unsigned byte min max
            Console.WriteLine($"byte minimum value: {byte.MinValue}, byte maximum value: {byte.MaxValue}\n");
            //signed short min max
            Console.WriteLine($"signed short minimum value: {short.MinValue}, signed short maximum value: {short.MaxValue}\n");
            //unsigned short min max
            Console.WriteLine($"unsigned short minimum value: {ushort.MinValue}, usigned short maximum value: {ushort.MaxValue}\n");
            //signed int min max
            Console.WriteLine($"signed integer minimum value: {int.MinValue}, signed integer maximum value: {int.MaxValue}\n");
            //unsigned int min max
            Console.WriteLine($"unsigned integer minimum value: {uint.MinValue}, usigned integer maximum value: {uint.MaxValue}\n");
            //signed long min max
            Console.WriteLine($"signed long minimum value: {long.MinValue}, signed long maximum value: {long.MaxValue}\n");
            //unsigned long min max
            Console.WriteLine($"unsigned long minimum value: {ulong.MinValue}, usigned long maximum value: {ulong.MaxValue}\n");

            //floating point numeric types

            //float min max
            Console.WriteLine($"float minimum value: {float.MinValue}, float maximum value: {float.MaxValue}\n");
            //double min max
            Console.WriteLine($"double minimum value: {double.MinValue}, double maximum value: {double.MaxValue}\n");

            //char type

            //char min and max values as unicode
            Console.WriteLine($"char type minimum unicode character: {char.MinValue}, char type maximum unicode character: {char.MaxValue}\n");
            //char min and max values as numeric
            Console.WriteLine($"char type minimum numeric value: {(int)char.MinValue}, char type maximum numeric value: {(int)char.MaxValue}\n");

            //bool type

            //bool min and max values
            Console.WriteLine($"bool type minimum value: {bool.FalseString}, bool type maximum value: {bool.TrueString}\n");
            //bool min and max values as numeric
            Console.WriteLine($"bool type minimum numeric value: {Convert.ToByte(false)}, bool type maximum numeric value: {Convert.ToByte(true)}\n");
        }
    }
}