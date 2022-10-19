namespace Full_GRASP_And_SOLID.Library
{
    public interface IDestinoimperison
    {
        void Imprimir(Recipe recipe);
    }
}//Lo que hicimos en este ejercicio fue quitarle la responsabilidad de imprimir a la clase AllInOnePrinter y crear una interfaz IDestinoimperison que se encargue de imprimir,
// y luego crear dos clases que implementen esta interfaz, 
//una para imprimir en consola y otra para imprimir en un archivo. 
//De esta manera, la clase AllInOnePrinter no tiene que preocuparse por como se va a imprimir, 
//sino que solo se encarga de imprimir, 
//y las clases que implementan la interfaz IDestinoimperison se encargan de como se va a imprimir.
//Por esto se aplica el principio polimorfismo, ya que lo que hacia una clase ahora lo hacen dos clases diferentes.
