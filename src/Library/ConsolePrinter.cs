using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            // tipo de IRecipeContent modificado por DIP
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}