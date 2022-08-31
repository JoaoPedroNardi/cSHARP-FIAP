namespace MultiplosDe3

{

    public class Program

    {

        static void Main(string[] args)

        {

            int soma = 0;


            for(int i = 1; i <= 100; i++)

            {

                if(i % 3 == 0)

                {

                    continue;

                }

                else

                {

                    soma += i;

                }

            }


            Console.WriteLine("O resultado é: " + soma);

        }

    }

}