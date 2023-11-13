using Questão_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace caRoboMontador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pilha pilha = new Pilha();

            

            

            Console.WriteLine("Digite as peças a serem inseridas separadas por 'ENTER'");
           
            string peça1 = Console.ReadLine();
            pilha.inserir(peça1);
            string peça2 = Console.ReadLine();
            pilha.inserir(peça2);
            string peça3 = Console.ReadLine();
            pilha.inserir(peça3);
            string peça4 = Console.ReadLine();
            pilha.inserir(peça4);

            
            


            void trocaPeças(string peçaDefeituosa, string peçaNova)
            {
                if (pilha.codigoExiste(peçaDefeituosa))
                            {
                                Console.WriteLine("Peça existe, a troca será feita!");
                            }
                else 
                   Console.WriteLine("Peça não Existe");
                   Console.ReadLine();
                


                Pilha pilhaAux = new Pilha();


                while (pilha != null) 
                { 
                        if (pilha.Topo.Equals(peçaDefeituosa))
                        {
                                    pilha.remover();
                                    pilha.inserir(peçaNova);
                        while (pilhaAux != null)
                        {
                            string aux2 = pilhaAux.remover();
                            pilha.inserir(aux2);
                        }
                        }

                    string aux = pilha.remover();
                    pilhaAux.inserir(aux);

                }


            }


            Console.WriteLine("Digite a peça velha a ser trocada e a peça nova a ser colocada separadas por 'ENTER'");


            string peçaVelha = Console.ReadLine();
            string peçaSubst = Console.ReadLine();

            trocaPeças(peçaVelha, peçaSubst);


            Console.WriteLine("Troca efetuada com sucesso!");



            















        }
    }
}
