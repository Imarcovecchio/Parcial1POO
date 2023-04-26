namespace Biblioteca;

public class LocalComercial:Inmueble{
    public bool sinImpuestos;

    public LocalComercial(double metros,Ubicacion barrio,bool sinImpuestos ): base(metros,barrio){
        this.sinImpuestos=sinImpuestos;
    }
    public override double Cotizacion{
        get{
            double cotizacion = base.Cotizacion;
            if(sinImpuestos){
                cotizacion = (cotizacion * 10 /100) - cotizacion;
            }
            return cotizacion;
        }
    }
}