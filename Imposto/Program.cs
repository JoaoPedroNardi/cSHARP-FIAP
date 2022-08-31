namespace Imposto

{

    public class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Informe o valor da nota fiscal:");

            double valorDaNotaFiscal = Convert.ToDouble(Console.ReadLine());



             if (valorDaNotaFiscal <= 999){

                    double valorImposto = valorDaNotaFiscal * 0.02;

                    Console.WriteLine("Valor do imposto será: " + valorImposto);

             }

             else if(1000 <= valorDaNotaFiscal && valorDaNotaFiscal <= 2999){

                    double valorImposto = valorDaNotaFiscal * 0.025;

                    Console.WriteLine("Valor do imposto será: " + valorImposto);

             }

             else if(3000 <= valorDaNotaFiscal && valorDaNotaFiscal <= 6999){

                    double valorImposto = valorDaNotaFiscal * 0.028;

                    Console.WriteLine("Valor do imposto será: " + valorImposto);

             }

             else{

                    double valorImposto = valorDaNotaFiscal * 0.03;

                    Console.WriteLine("Valor do imposto será: " + valorImposto);

             }



                       

        }

    }

}