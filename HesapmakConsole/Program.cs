namespace HesapmakConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac;
            string isim;
            sayac = 1;
            isim = "sena";


            while (@sayac <= 10)
            {
                Console.WriteLine(isim);
                sayac = sayac + 1;
            }
        }
    }
}