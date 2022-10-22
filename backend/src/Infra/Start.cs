
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
            //RecipesGetRepo receitas = new RecipesGetRepo();
            //await receitas.GetByUserId("1a2f7842-d93c-4e3f-87ec-f9eef568c768");
            //await receitas.GetById("d9caf85b-31a3-466c-b2b9-77503ade0650");
            //await receitas.GetByClassTitle("andre");
            //await receitas.GetAll();alinAline, o pessoal 



            //////////// UPDATE ////////////
            //UpdateRecipe update = new UpdateRecipe("57a9edce-4690-4651-88d2-e9872f03720a");
            //await update.UpdateTitle("Outra alteração de teste de update titulo!");




            ////////////// REMOVE ////////////
            //RecipesRemoveRepo remover = new RecipesRemoveRepo();
            //await remover.Delete("2aaaf503-8cf2-4b4a-b5c8-ccb49d15f0b2");





            ///////////////////// Category /////////////////////
            //Category categoria = new("Tortas");
            //CategoriesInsertRepo repo = new CategoriesInsertRepo();
            //await repo.AddOne(categoria);

            //CategoriesGetRepo repo2 = new CategoriesGetRepo();
            //var result = await repo2.GetById("6b83b5e8-0365-48a9-b209-21f55ee13a81");
            //Console.WriteLine(result.Name);

            //var result2 = await repo2.GetByName("Tortas");
            //Console.WriteLine(result2.FirstOrDefault().Id);

            //var result3 = await repo2.GetAll();
            //Console.WriteLine(result3.ToList().Count);


            CategoriesRepo catRepo = new();
            //await catRepo.AddOne(new Category("Categoria Teste"));
            var result = await catRepo.GetAll();
            Console.WriteLine(result.ToJson());

        }
    }
}