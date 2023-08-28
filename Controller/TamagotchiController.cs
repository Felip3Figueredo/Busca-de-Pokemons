using Busca_de_Pokemons.Model;
using Busca_de_Pokemons.View;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busca_de_Pokemons.Controller
{
    public class TamagotchiController
    {
        Inicio Mensagens = new Inicio();
        List<Mascote> mascotesAdotados = new List<Mascote>();

        public void Jogar()
        {
            string opcaoUsuario;
            bool jogar = true;

            while (jogar)
            {
                Mensagens.MenuIncial();
                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1":
                        string especie = Mensagens.MenuAdocao();
                        mascotesAdotados.Add(AdicionarMascote(especie));
                        break;
                    case "2":
                        Console.WriteLine("-------------------------- LISTAR MASCOTES --------------------------");
                        foreach (var pokemon in mascotesAdotados)
                        {
                            showDetails(pokemon);
                            Console.WriteLine("-----------------------");
                        }
                        break;
                    case "3":
                        string escolha = Mensagens.MenuInteracao();

                        switch (escolha)
                        {
                            case "1":
                                Console.WriteLine("-------------------------- LISTAR SAUDE --------------------------");
                                foreach (var pokemon in mascotesAdotados)
                                {
                                    showDetails(pokemon);
                                    Console.WriteLine("-----------------------");
                                }
                                break;
                            case "2":
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("ANIMAL ALIMENTADO");
                                Console.WriteLine("--------------------------------");
                        }
                        break;
                    case "4":
                        jogar = false;
                        break;

                }
            }
        }

        public Mascote AdicionarMascote(string especie)
        {
            TamagotchiController pokemonController = new TamagotchiController();
            

            string resposta = string.Empty;
            var url = "https://pokeapi.co/api/v2/pokemon/";
            Mascote mascote = new Mascote();
            

            do
            {   
                especie = pokemonController.getPokemon(url, especie);
                mascote = JsonConvert.DeserializeObject<Mascote>(especie);

                pokemonController.showDetails(mascote);
                Console.WriteLine("Deseja adotar esse pokemon: \n1 - Sim\n2 - Não");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("---------- Mascote adicionado ----------");
                    break;
                }
                else
                {
                    especie = Mensagens.MenuAdocao();
                    Console.WriteLine("-----------------------------------------");
                    continue;
                }
            } while (resposta != "1");
            
            return mascote;
        }

        public string getPokemon(string url, string pokemon)
        {
            var client = new RestClient($"{url}\\{pokemon}");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (response.Content == null) { return "Response nulo"; }
                else { return response.Content; }
            }
            else
            {
                return response.StatusCode.ToString();
            }
        }

        public void showDetails(Mascote mascote)
        {
            Console.WriteLine($"----------- {mascote.Name} ----------- ");
            Console.WriteLine($"Altura: {mascote.Height}");
            Console.WriteLine($"Peso: {mascote.Weight}");
            Console.WriteLine("Habilidades:");
            foreach (var infoAbilities in mascote.Abilities)
            {
                Console.WriteLine(infoAbilities.Ability.Name);
            }
            Console.WriteLine("---- STATUS ----");
            Console.WriteLine($"Fome: {mascote.Fome}");
            Console.WriteLine($"Diversão: {mascote.Felicidade}");
        }
    }
}
