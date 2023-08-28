using Busca_de_Pokemons.Controller;
using Busca_de_Pokemons.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busca_de_Pokemons.View
{
    
    public class Inicio
    {
        public static string nomeJogador;
        
        public void BoasVindas()
        {
            Console.WriteLine("\r\n██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗\r\n██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║\r\n██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║\r\n██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║\r\n██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║\r\n╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
            Console.WriteLine("\n\nQual é o seu nome?");
            nomeJogador = Console.ReadLine().ToUpper();
        }

        public void MenuIncial()
        {
            Console.WriteLine("\n\n---------------------------------------- MENU ----------------------------------------");
            Console.WriteLine($"{nomeJogador} O que voce deseja:" +
                $"\n1 - Adotar um pokemon" +
                $"\n2 - Ver mascotes" +
                $"\n3 - Interação com mascote" +
                $"\n4 - Sair\n");
        }
        public string MenuAdocao()
        {
            Console.WriteLine("\n\n---------------------------------------- ADOTAR UM MASCOTE ----------------------------------------");
            Console.WriteLine($"{nomeJogador} Escolha uma espécie: ");
            string especie = Console.ReadLine();
            return especie;
        }
        public MenuInteracao()
        {
            Console.WriteLine("\n\n------------------------------------- INTERAGIR COM O MASCOTE --------------------------------------");
            Console.WriteLine("Escolha o mascote: ");
            string mascote = Console.ReadLine();

            

            Console.WriteLine($"{nomeJogador} O que voce deseja" +
                $"\n1 - Checar status mascote" +
                $"\n2 - Alimentar mascote" +
                $"\n3 - Brincar com o mascote");
            string escolha = Console.ReadLine();
            return (escolha, mascote);
        }

        
    }
}
