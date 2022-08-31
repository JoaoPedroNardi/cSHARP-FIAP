namespace Eleicao

{

    public class Program

    {

        static void Main(string[] args)

        {

            int idade;

            bool brasileira = true;



            Console.WriteLine("Informe a sua idade: ");

            idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Você é brasileiro? (true/false)");

            brasileira = Convert.ToBoolean(Console.ReadLine());

            if (idade >= 16 && brasileira == true)

            {

                Console.WriteLine("Você está apto a votar");

            }

            else

            {

                Console.WriteLine("Você não está apto a votar");    

            }

        }

    }



}