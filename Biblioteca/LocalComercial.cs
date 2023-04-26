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
                cotizacion *= 0.9;
            }
            return cotizacion;
        }
    }
    public override string Caracteristicas()
    {
        string caracter = base.Caracteristicas();
        if(sinImpuestos){
            caracter += ", Sin impuestos";
        }
        return caracter;
    }
}