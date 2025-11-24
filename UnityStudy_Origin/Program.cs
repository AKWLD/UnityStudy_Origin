namespace UnityStudy_Origin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 1;

            //while (num <= 10)
            //{
            //    Console.WriteLine(num);

            //    num++;

            {
                for (int z = 2; z <= 9; z++)
                {
                    Console.WriteLine($"{z}단");  

                    for (int x = 1; x <= 9; x++)
                       
                        Console.WriteLine($" {z}X{x} = {x*z}");
                    Console.WriteLine();
                }
            }
        }
    }
}
