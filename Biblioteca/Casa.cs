namespace Biblioteca;

public class Casa:Inmueble{
    public bool tienePileta;
    public bool tieneCochera;

    public Casa(double metros, Ubicacion barrio,bool tienePileta,bool tieneCochera) : base(metros,barrio){
        this.tienePileta=tienePileta;
        this.tieneCochera=tieneCochera;
    }
    public override double Cotizacion {
        get {
            double cotizacion = base.Cotizacion;
            if (tienePileta) {
                cotizacion += 200;
            }
            if (tieneCochera) {
                cotizacion += 50;
            }
            return cotizacion;
        }
    }
}