namespace VinosBlancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our variables with the values
            int[] vinos = new int[11] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            const int max = 175388;
            const byte maxStar = 100;

            //Adds 35432 to 2014
            vinos[5] = vinos[5] + 35432;

            //Sorts the numbers
            Array.Sort(vinos);

            //Writes the signs in console
            for (int i = 0; i < vinos.GetLength(0); i++)
            {
                int star = maxStar * vinos[i] / max;
                for (int j = 0; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\r\n");
            }
        }
    }
}