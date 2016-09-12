﻿/*
 * Creado por SharpDevelop.
 * Usuario: casa
 * Fecha: 9/9/2016
 * Hora: 11:12 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace CodigoActividad3
{
	//creo esta clase porque necesito manejar la lista de clientes fuera del programa pricipal
	public class ManejaCliente
	 {
        private List<cliente> clientes;
        
        public ManejaCliente()
        {
            clientes = new List<cliente>();
        }
        public void AgregarCliente(cliente c)
        {
            clientes.Add(c);
        }
        public void MuestraClientes()
        {
            if(clientes.Count>0)
            {
                for (int i=0; i<clientes.Count;i++)
                {
                    muestra_cliente(i);
                }
            }
            else
            {
                Console.WriteLine("No hay clientes cargados");
            }
        }
        
        public cliente buscarCliente(string d)
        {
            for(int i=0; i< clientes.Count;i++)
            {
                if (clientes[i].Dni == d)
                {
                    return clientes[i];
                }
            }
            return null;
        }
        public void muestra_cliente(int i)
        {
            Console.WriteLine("Cliente "+i);
            Console.WriteLine("Nombre: "+clientes[i].Nombre);
            Console.WriteLine("Telefono: "+clientes[i].Telefono);
            Console.WriteLine("Dni: "+clientes[i].Dni);
            Console.WriteLine();
        }
    }
}