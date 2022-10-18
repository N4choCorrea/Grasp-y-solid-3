using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
  public class Imprimirenconsola : IDestinoimperison
  {
    public void Imprimir(Recipe recipe)
    {
      Console.WriteLine(recipe.GetTextToPrint());
    }
  }
}