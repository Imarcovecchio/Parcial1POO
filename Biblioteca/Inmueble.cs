namespace Biblioteca;

public class Inmueble{
    private double metros;
    private Ubicacion barrio;
    public Inmueble(double metros,Ubicacion barrio){
        this.metros=metros;
        this.barrio=barrio;
    } 
    public virtual double Cotizacion{
        get{
            double cotizacion;
            if(barrio == Ubicacion.Urbano){
                cotizacion = metros *2000;
            }
            else{
                cotizacion = metros*3000;
            }
            return cotizacion;
            }
    }
     
    
    

}