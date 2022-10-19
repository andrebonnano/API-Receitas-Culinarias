using Domain.Entities.Recipes;
using Infra.Repositories;
using MongoDB.Driver;

namespace Infra
{
    public class Start
    {
        static void Main(string[] args)
        {
            Task T = MainAsync(args);
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {

            //////////// INSERIR /////////////
            //Recipe receita = new();
            //Recipe receita2 = new();
            //Recipe receita3 = new();

            //receita.Title = receita2.Title = receita3.Title = "andre";

            //IList<Recipe> receitas = new List<Recipe>();
            //receitas.Add(receita);
            //receitas.Add(receita2);
            //receitas.Add(receita3);

            //InsertRecipes novo = new(receitas);
            //await novo.SaveMany();




            //////////// LISTAR /////////////
            //GetRecipes receitas = new GetRecipes();
            //await receitas.GetByUser("95b25fdf-b85c-4026-9b2d-f0c747b97b7e");
            //await receitas.GetById("4873f18b-88d0-4cf6-a785-15f5d630af38");
            //await receitas.GetByClassTitle("andre");
            //await receitas.GetAll();



            //////////// UPDATE ////////////
            //UpdateRecipe update = new UpdateRecipe("57a9edce-4690-4651-88d2-e9872f03720a");
            //await update.UpdateTitle("Outra alteração de teste de update titulo!");




            //////////// REMOVE ////////////
            RemoveRecipe remover = new RemoveRecipe("210b30f0-d543-4221-83f0-0b3ec9178144");
            await remover.Execute();

        }
    }
}