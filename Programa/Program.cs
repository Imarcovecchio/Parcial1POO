using Biblioteca;

Inmobiliaria inmobiliaria = new Inmobiliaria();
Casa casa1 = new Casa(100,Ubicacion.Suburbano,true,true);
Casa casa2 = new Casa(200,Ubicacion.Urbano,false,true);
LocalComercial local1 = new LocalComercial(100,Ubicacion.Suburbano,true);
LocalComercial local2 = new LocalComercial(100,Ubicacion.Urbano,false);

inmobiliaria.Agregar(casa1);
inmobiliaria.Agregar(casa2);
inmobiliaria.Agregar(local1);
inmobiliaria.Agregar(local2);

inmobiliaria.Imprimir();