using System;
using System.Collections.Generic;

namespace BLL_Automoviles
{
    public class Concesionaria
    {
        private List<Vehiculo> _automovil = new(); //utilizo dos listas, por que uso dos combobox
        private List<Vehiculo> _camioneta = new();


        public List<Vehiculo> Automoviles
        {
            get { return _automovil; }
            set { _automovil = value; }
        }
        public List<Vehiculo> AutomovilesDisponibles()
        {
            Automovil catAuto = new(); //HARDCODE instancio dos autos
            Vehiculo objauto1 = new()
            {
                Modelo = "Ford Focus",
                Categoria = catAuto,
                VelMax = 218,
                KmRecorridos = 0,
                Tanque = 43.2f
            };
            Vehiculo objauto2 = new()
            {
                Modelo = "Audi A3",
                Categoria = catAuto,
                VelMax = 202,
                KmRecorridos = 6450,
                Tanque = 34.8f
            };

            this.Automoviles.Add(objauto1);
            this.Automoviles.Add(objauto2);

            return this.Automoviles;
        }
        public List<Vehiculo> Camionetas
        {
            get { return _camioneta; }
            set { _camioneta = value; }
        }
        public List<Vehiculo> CamionetasDisponibles()
        {
            Camioneta catCam = new(); //HARDCODE instancio una camioneta
            Vehiculo objCamioneta = new()
            {
                Modelo = "Ford Ranger",
                Categoria = catCam,
                VelMax = 170,
                KmRecorridos = 12000,
                Tanque = 55
            };

            this.Camionetas.Add(objCamioneta);

            return this.Camionetas;
        }
        
        public static string CalcularPrecio(Compra objCompra, float cotizacion) //Recive vehiculo, mejoras y la cotizacion de la moneda. Retorna un string para el mensaje
        {
            float precioFinal;
            float precioMejoras = 0;
            string precio = string.Empty; //concatena los valores que se mostraran en el mensaje
            precioFinal = objCompra.Vehiculos.Categoria.DevolverPrecio(cotizacion); //devuelve el valor del vehiculo en la cotizacion ingresada
            precio = "PRECIO FINAL\n\nValor vehiculo: $" + objCompra.Vehiculos.Categoria.DevolverPrecio(cotizacion);

            if (objCompra.Soft != null) //si el checkbox no estaba habilitado devolvia null, si esta habilitado procedo a acumular las mejoras
            {
                precioMejoras += objCompra.Soft.DevolverCosto(cotizacion);
                precio += "\n\n   Cargo por Software: $" + objCompra.Soft.DevolverCosto(cotizacion);
            }
            if (objCompra.Alarmas != null)
            {
                precioMejoras += objCompra.Alarmas.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Alarmas: $" + objCompra.Alarmas.DevolverCosto(cotizacion);
            }
            if (objCompra.Vidrio != null)
            {
                precioMejoras += objCompra.Vidrio.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Vidrio Polarizado: $" + objCompra.Vidrio.DevolverCosto(cotizacion);
            }
            if (objCompra.Balizas != null)
            {
                precioMejoras += objCompra.Balizas.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Balizas: $" + objCompra.Balizas.DevolverCosto(cotizacion);
            }
            if (objCompra.Luces != null)
            {
                precioMejoras += objCompra.Luces.DevolverCosto(cotizacion);
                precio += "\n   Cargo por Luces de Neon: $" + objCompra.Luces.DevolverCosto(cotizacion);
            }
            precio += "\nPrecio de mejoras: $" + precioMejoras;
            precioFinal += precioMejoras;
            precio += "\n\nPrecio Final: $" + precioFinal;
            return precio;
        }
    }
}
