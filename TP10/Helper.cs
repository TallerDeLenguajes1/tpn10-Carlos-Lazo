using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    class Helpers
    {

    }
    public class Inmobiliaira {
        enum TipoDeOperacion
        {
            Venta= 0,
            Alquiler=1,
        }
        enum TipoDePropiedad
        {
            Depto = 0,
            Casa = 1,
            Duplex=2,
            PenthHouse=3,
            Terreno=4,

        }

        int id;
        float tamanio;
        int cantidadDeBanios;
        int cantidadDeCuartos;
        string domicilio;
        int precio;
        bool estado;
        double valorMueble;

        public int Id { get => id; set => id = value; }
        public float Tamanio { get => tamanio; set => tamanio = value; }
        public int CantidadDeBanios { get => cantidadDeBanios; set => cantidadDeBanios = value; }
        public int CantidadDeCuartos { get => cantidadDeCuartos; set => cantidadDeCuartos = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Precio { get => precio; set => precio = value; }
        public bool Estado { get => estado; set => estado = value; }
        public double ValorMueble { get => valorMueble; set => valorMueble = value; }

        public double ValorDelInmueble(int Operacion, int precio)
        {
            double valor = 0;
            if (Operacion == 0)
            {
                valor = (precio * 1.31) ;
                valor += 10000; 
            }else if(Operacion == 1)
            {
                valor = (precio * 1.025) ;

            }
            else
            {
                valor = -9999;
            }

            return  valor;
        }

        public void CargarDatos(int _id, float _tama, int _cantBanios, int _cantCuartos, string _Domicilio, int _Precio, bool _Estado, int _Operacion)
        {
            Id = _id;
            Tamanio = _tama;
            CantidadDeBanios = _cantBanios;
            CantidadDeCuartos = _cantBanios;
            Domicilio = _Domicilio;
            Precio = _Precio;
            ValorMueble = ValorDelInmueble(_Operacion,_Precio);

        } 
    
    }


}
