using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace VetorEClasse {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos produtos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            Product[] product = new Product[n];

            Console.WriteLine("====================================");
            Console.WriteLine("         CADASTRO DE PRODUTOS");
            Console.WriteLine("====================================");

            for (int i = 0; i < n; i++) {

                Console.WriteLine("---------------------------------");
                Console.WriteLine("PRODUTO " + i);
                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Digite 'S' ou 's' para dar entrada em estoque \nOu qualquer outra para seguir: ");
                char estoque = char.Parse(Console.ReadLine());
                if (estoque == 's' || estoque == 'S') {
                    Console.Write("Quantidade: ");
                    int qnt = int.Parse(Console.ReadLine());
                    product[i] = new Product(descricao, preco, qnt);
                }
                else {
                    product[i] = new Product(descricao, preco);
                }
            }

            Console.WriteLine();
            Console.WriteLine("===============================================================");
            Console.WriteLine("                         LISTA DE PRODUTOS");
            Console.WriteLine("===============================================================");
            Console.WriteLine();
            
            for (int i = 0; i < n; i++) {
                Console.WriteLine(i + "   |   " + product[i]);
            }

            char menu = '0';

            while (menu != '3') {

                Console.WriteLine("\n===============================================================");
                Console.WriteLine("         ATUALIZAR ESTOQUE");
                Console.WriteLine("===============================================================");
                Console.WriteLine("1. ENTRADA");
                Console.WriteLine("2. SAIDA");
                Console.WriteLine("3.SAIR");
                Console.Write("Escolha uma das opções: ");
                menu = char.Parse(Console.ReadLine());

                if (menu == '1') {
                    Console.Write("Indice do produto: ");
                    int indice = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n"+product[indice]+"\n");

                    Console.Write("Quantidade para Entrada: ");
                    int entrada = int.Parse(Console.ReadLine());
                    product[indice].EntradaNoEstoque(entrada);

                    Console.WriteLine("\n------ PRODUTO ATUALIZADO ------");
                    Console.WriteLine(product[indice]);
                }
                else {
                    if (menu == '2') {
                        Console.Write("Indice do produto: ");
                        int indice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n"+product[indice]+"\n");

                        Console.Write("Quantidade para Saída: ");
                        int saida = int.Parse(Console.ReadLine());
                        product[indice].SaidaNoEstoque(saida);

                        Console.WriteLine("\n------ PRODUTO ATUALIZADO ------");
                        Console.WriteLine(product[indice]);
                    }
                    else {
                        if(menu != '3') {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine(" ---     OPÇÃO INVALIDA!!!   ---");
                            Console.WriteLine("--------------------------------");
                        }
                    }
                }
                
                Console.WriteLine();
                Console.WriteLine("===============================================================");
                Console.WriteLine("                         LISTA DE PRODUTOS");
                Console.WriteLine("===============================================================");
                Console.WriteLine();
                for (int i = 0; i < n; i++) {
                    Console.WriteLine(i + "   |   " + product[i]);
                }
            }
        }

    }
}
