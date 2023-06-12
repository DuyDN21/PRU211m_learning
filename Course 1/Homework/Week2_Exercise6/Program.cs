namespace Week2_Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an angle(in degree): ");
            float angle = float.Parse(Console.ReadLine());

            Console.WriteLine("Sin: " + Math.Sin(angle * (float)Math.PI / 180));
            Console.WriteLine("Cos: " + Math.Cos(angle * (float)Math.PI / 180));
        }
    }
}