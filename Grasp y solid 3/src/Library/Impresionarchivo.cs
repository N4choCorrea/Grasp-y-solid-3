using System;
using System.IO;
namespace Full_GRASP_And_SOLID.Library
{
  public class Impresionarchivo : IDestinoimperison
  {
    public void Imprimir(Recipe recipe)
    {
      File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
  }
}