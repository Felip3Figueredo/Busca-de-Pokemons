using Busca_de_Pokemons.Controller;
using Busca_de_Pokemons.Model;
using Busca_de_Pokemons.View;
using Nancy.ErrorHandling;
using Newtonsoft.Json;
using RestSharp;
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Busca_de_Pokemons
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            Inicio telas = new Inicio();
            TamagotchiController controlador = new TamagotchiController();

            telas.BoasVindas();
            controlador.Jogar();

        }
    }
}