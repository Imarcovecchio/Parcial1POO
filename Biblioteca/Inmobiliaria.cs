namespace Biblioteca;
public class Inmobiliaria
{
    public List<Inmueble> inmuebles;

    public Inmobiliaria(){
        inmuebles = new List<Inmueble>();
    }
    public void Agregar(Inmueble inmueble){
        inmuebles.Add(inmueble);
    }
    public void Imprimir(){
        foreach(Inmueble inmueble in inmuebles){
            Console.WriteLine(inmueble.GetType().Name + ": "+ inmueble.Caracteristicas()+", Cotizacion:" + inmueble.Cotizacion);
        }
    }

}
