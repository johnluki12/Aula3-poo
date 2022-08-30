using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração e instanciação dos objetos
            Aluno al = new Aluno();
            Mensalidade men = new Mensalidade();
            // chamada dos metodos
            Console.WriteLine("Digite o nome:");
            al.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o endereço :");
            al.SetEndereco(Console.ReadLine());
            Console.WriteLine("Digite o CPF: ");
            al.SetCpf(Console.ReadLine());
            Console.WriteLine("Digite o RA: ");
            al.SetRa(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Digite o curso: ");
            men.SetCurso(Console.ReadLine());
            Console.WriteLine("Digite o valor: ");
            men.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o dia do pagamento: ");
            men.SetDia(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\nDados do alunos");
            Console.WriteLine("RA: " + al.Getra() + "\nAluno: " + al.GetNome());
            Console.WriteLine("Endereço: " + al.GetEndereco() + "\nCPF: " + al.GetCpf());
            Console.WriteLine("Curso: " + men.GetCurso() + "\nValor da mensalidade: " + men.GetValor().ToString("C") + "\nValor a pagar: " + men.Calcular().ToString("C"));
            Console.ReadKey();
        }   
    }
}
