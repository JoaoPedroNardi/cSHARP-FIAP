namespace ForEncadeado

{

    public class Program

    {

        static void Main(string[] args)

        {

            var linha = 4;



            var coluna = 1;



            var trianguloNumerico = string.Empty;





            for (int i = 1; i <= linha; i++){



                coluna = i;



                Console.Write(i + " ");



                for (int j = 2; j <= coluna; j++)



            {



                Console.Write(i * j + " " );



            }



                Console.WriteLine();



            }

        }

    }



}