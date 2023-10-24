using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            // tipo de IRecipeContent modificado por DIP
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}