using System;
using System.Collections.Generic;
using System.Globalization;

namespace RegistroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.Write("How Many emplyoee will be register?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Emplyoee " + "#" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }
            Console.Write("Enter the id that will have salary increase: ");
            int aumento = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == aumento);
            
            if (emp != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Soma(porcentage);
            }
            else
            {
                Console.WriteLine("Não exite aumento!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualizar a lista de funcionários: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
