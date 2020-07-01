using System;
using System.IO;
using Helper;
using System.Collections.Generic;

namespace TP10
{
    class Principal
    {
        static void Main(string[] args)
        {
            string NombreArchivo = "Ventas.txt";
            float[] tama = {28.9F , 50.3F, 90.8F };
            int[] Banios = { 1, 2, 3, 4 };
            int[] Dormitorios = { 1, 2, 3, 4 };
            string[] Domicilio = { "Bº Sur", "Bº Norte", "Bº Centro" };
            int[] Precio = { 1000000, 150000, 2000000, 2500000, 300000 };
            bool Estado = false;

            int CantidadDClientes = 2; ///new Random().Next(11);

            List<Inmobiliaira> ListaVentas = new List<Inmobiliaira>();

            Inmobiliaira propieda;

            for (int i = 0; i < CantidadDClientes ; i++)
            {
                propieda = new Inmobiliaira();
                if(i % 2 == 0) { Estado = true; };
                propieda.CargarDatos(i, tama[new Random().Next(tama.Length)], Banios[new Random().Next(Banios.Length)], Dormitorios[new Random().Next(Dormitorios.Length)], Domicilio[new Random().Next(Domicilio.Length)], Precio[new Random().Next(Precio.Length)], Estado, new Random().Next(2));
                Console.WriteLine(propieda.Id + propieda.Tamanio);
                ListaVentas.Add(propieda);
            }

            using (StreamWriter StrW = new StreamWriter(NombreArchivo))
            {


                foreach (Inmobiliaira Venta in ListaVentas)
                {
                    string articulo = Convert.ToString(Venta.Id) + ";" + Convert.ToString(Venta.Tamanio) + ";" + Convert.ToString(Venta.CantidadDeBanios) + ";" + Convert.ToString(Venta.CantidadDeCuartos) + ";" + Venta.Domicilio + ";" + Convert.ToString(Venta.Precio) + ";" + Convert.ToString(Venta.ValorMueble) + "\n";
                    //Console.WriteLine(articulo);
                    StrW.WriteLine(articulo);
                }

            }
        }
    }
}
