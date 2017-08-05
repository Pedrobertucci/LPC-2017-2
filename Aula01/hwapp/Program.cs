using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {

           int  op = 0;

		do
		{   
			Console.WriteLine("\nEscolha uma opcao de calculo: ");  
			Console.WriteLine("\n1 - op1 \n2 - op1\n3 - op3\n4 - op4 \n5 - Sair\n");
			do
			{
				op = int.Parse(Console.ReadLine());
				
				if ((op < 1) || (op>5))
					Console.WriteLine("\nOpcao invalida!!");
				
			}while ((op < 1) || (op>5));
			
			if (op != 5)
			{
					Console.WriteLine("\nPede as entradas do programa.....");

			}
			
			switch (op)
			{
				case 1: 
					Console.WriteLine("\nselecionou 1.....");
					break;
				case 2: 
					Console.WriteLine("\nselecionou 2.....");
					break;      
			}
			
			if (op==5)			
				Console.WriteLine("\nPrograma encerrado.....");
			else   
				Console.WriteLine("\nColoca os Resultados.....");
			
		}while (op !=5);
        }

        private static decimal somar(decimal N1, decimal N2)
        {
            return N1 + N2;

        }
    }
}
