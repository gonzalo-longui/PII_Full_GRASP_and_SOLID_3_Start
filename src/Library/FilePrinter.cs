using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        /*
        Principio SRP: Esta clase tiene la única responsabilidad de imprimir la receta en un archivo
        Polymorphism: Esta clase y la clase ConsolePrinter implementan la interfaz IPrinter. Tienen el método PrintRecipe, que 
        se implementa de manera distinta dependiendo de la clase, pero que se invoca de la misma manera en el Program.
        */
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}