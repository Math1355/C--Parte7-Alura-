using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(15, 1, 78);


            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];

            }



            Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            Console.WriteLine(SomarVarios(1, 2, 45));

            

            Console.ReadLine();
        }

        static int SomarVarios(params int [] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaObject()
        {
            ListaDeObject listaDeIdade = new ListaDeObject();

            listaDeIdade.Adicionar(10);
            listaDeIdade.Adicionar(5);
            listaDeIdade.Adicionar(4);
            listaDeIdade.Adicionar("um texto qualquer");
            listaDeIdade.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdade.Tamanho; i++)
            {
                int idade = (int)listaDeIdade[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");

            }
        }

        static void TestaListaDeContaCorrete()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente ContaDoMath = new ContaCorrente(666, 666666);

            lista.Adicionar(ContaDoMath);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                ContaDoMath,
                new ContaCorrente(874, 4654894),
                new ContaCorrente(874, 3546848)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(ContaDoMath, new ContaCorrente(874, 4654894), new ContaCorrente(874, 3546848));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5468445),
                new ContaCorrente(874, 4451616),
                new ContaCorrente(874, 3348498)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de interios, com 5 posições

            int[] idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array no indice {indice}");
                Console.WriteLine($"Valor de idade [{indice}] = {idade}");
                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
