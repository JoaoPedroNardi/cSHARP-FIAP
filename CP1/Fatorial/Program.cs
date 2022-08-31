namespace Fatorial

{

    public class Program

    {

        static void Main(string[] args)

        {

            int fatorial = 1;

            for (int n = 1; n <= 10; n++)

            {        

                fatorial*=n;

                Console.WriteLine("O fatorial de "+ n +" é: "+fatorial);

            }



        }

    }

}