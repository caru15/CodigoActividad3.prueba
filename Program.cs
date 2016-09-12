/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 1/9/2016
 * Time: 6:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace CodigoActividad3
{
	class Program
	{
		public static void Main(string[] args)
		{ {
            cliente cli;
            mascota masco;
            int opcion=0;
            int cod=-1;
            ListaClientes ListaC = new ListaClientes();
            
            Console.WriteLine();            
            Console.WriteLine("CLÍNICA VETERINARIA: SUPER ANIMALS");
            //Agregar Datos para correr la aplicación y hacer que funcione correctamente
            //Considerar Casos de Prueba para el problema.
            do
            {
                Console.WriteLine();
                Console.WriteLine("************MENU*************");
                Console.WriteLine();
                Console.WriteLine("Elija la opcion que desee: ");
                Console.WriteLine();
                Console.WriteLine("1.Cargar Cliente y mascotas");
                Console.WriteLine("2.Buscar Mascota");
                Console.WriteLine("3.Informar datos de mascotas");
                Console.WriteLine("4._");
                Console.WriteLine("5._");
                Console.WriteLine("6.Salir del sistema");
                Console.WriteLine();
                opcion=Int32.Parse(Console.ReadLine());
                switch (opcion)
                {                
                    case 1:
                    {
                        Console.WriteLine("----------Ingrese datos de cliente----------");
                        Console.Write("Ingrese Nombre: ");
                        String n =(Console.ReadLine());
                        Console.Write("Ingrese telefono: ");
                        String t=(Console.ReadLine());
                        Console.Write("Ingrese Dni: ");
                        String d=(Console.ReadLine());
                        Console.WriteLine();
                        cli = new cliente(n,t,d);
                        String resp="SI";
                        Console.WriteLine("----------Ingrese datos de mascota ----------");
                        while (resp != "NO")
                        {
                            Console.Write("Ingrese Especie del Animal (Gato,Perro,Conejo,Roedor, Etc): ");
                            String e=(Console.ReadLine());
                            Console.Write("Ingrese Nombre: ");
                            String no=(Console.ReadLine());
                            Console.Write("Ingrese Raza: ");
                            String r=(Console.ReadLine());
                            Console.Write("Ingrese Fecha de Nacimiento: ");
                            DateTime fn=DateTime.Parse(Console.ReadLine());
                            Console.WriteLine();
                            masco=new mascota(no,e,r,cod++,fn);
                            Console.Write("Desea agregar otra mascota? Resp: SI/NO: ");
                            resp=(Console.ReadLine());
                            Console.WriteLine();
                            //masco.Nombre();
                            Console.WriteLine("------------------------------------------------------");
                            cli.agregarMascota(masco);
                            //cli.debeVolver;
                                                    
                        }
                            
                        ListaC.AgregarCliente(cli);
                        ListaC.MuestraClientes(); //ESTO HICE PARA VER SI M LOS GUARDABA A LOS CLIENTES
                        break;
                    }
                    case 2:
                    {
                        
                            
                        break;    
                    }
                    case 3: 
                    case 4:
                    case 5:
                            break;
                    default: 
                        Console.Write("La opcion elejida no es valida");
                        break;
                }
                    
            }while (opcion != 6);
            
            //Console.ReadKey(true);
        }
		}}}