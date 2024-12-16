namespace Set3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vector nr: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '), int.Parse);

            int pozMax = 0;
            int pozMin = 0;
            int valMax = v[0];
            int valMin = v[0];

            for (int i = 1; i < v.Length; i++)
            {

                if (v[i] > valMax)
                {
                    valMax = v[i];
                    pozMax = i;
                }
                if (v[i] < valMin)
                {
                    valMin = v[i];
                    pozMin = i;
                }

            }

            Console.WriteLine($"Pozitie maxim: {pozMax} ; Pozitie minim: {pozMin}");

        }
    }


}
