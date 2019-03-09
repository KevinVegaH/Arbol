using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int Opcion = 0;
            NodoT Raiz = null;
            int Dato;
            do
            {
                Opcion = Menu();
                switch (Opcion)
                {
                    case 1: 
                        
                        
                        Console.Write("Valor del Nuevo Nodo: ");
                        Dato = int.Parse(Console.ReadLine());
                        if (Raiz == null)
                        {
                            NodoT NuevoNodo = new NodoT();
                            NuevoNodo.Informacion = Dato;
                            Raiz = NuevoNodo;
                        }
                        else
                        {
                            Insertar(Raiz, Dato);
                        }
                        Console.Clear();
                        break;
                    
                    
                    //Recorrido en Pre Orden del Arbol
                    case 2: RecorridoPreorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Recorrido en Post Orden del Arbol
                    case 3: RecorridoPostorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Recorrido en In Orden del Arbol
                    case 4: RecorridoInorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                   
                }
            } while (Opcion != 5);

        }
        static int Menu()
        {
            
            int Resultado = 0;
            do
            {
                Console.WriteLine("MENU DE ARBOLES");
                Console.WriteLine("");
                Console.WriteLine("1.- Registrar un Nuevo Nodo");
                Console.WriteLine("2.- Recorrido en Pre-orden");
                Console.WriteLine("3.- Recorrido en Post-orden");
                Console.WriteLine("4.- Recorrido en In-orden");

                Console.WriteLine("");
                Console.Write("Teclee la Opcion Deseada: ");
                Resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (Resultado < 1 || Resultado > 7)
                {
                    Console.WriteLine("ERROR, Opcion Invalida....");
                    Console.ReadLine();
                    Console.WriteLine("");
                }
                Console.Clear();
            } while (Resultado < 1 || Resultado > 7);
            return Resultado;
        }

        //Insertar en un arbol binario
        static void Insertar(NodoT Raiz, int Dato)
        {
            if (Dato < Raiz.Informacion)
            {
                if (Raiz.NodoIzquierdo == null)
                {
                    NodoT NuevoNodo = new NodoT();
                    NuevoNodo.Informacion = Dato;
                    Raiz.NodoIzquierdo = NuevoNodo;
                }
                else
                {
                    //Llamada recursiva
                    Insertar(Raiz.NodoIzquierdo, Dato);
                }
            }
            else//Buscar por el lado derecho
            {
                if (Dato > Raiz.Informacion)
                {
                    if (Raiz.NodoDerecho == null)
                    {
                        NodoT NuevoNodo = new NodoT();
                        NuevoNodo.Informacion = Dato;
                        Raiz.NodoDerecho = NuevoNodo;
                    }
                    else
                    {
                        //Llamada recursiva por el lado derecho
                        Insertar(Raiz.NodoDerecho, Dato);
                    }
                }
                else
                {
                    //El Nodo existe en el Arbol
                    Console.WriteLine("Nodo Existente, Imposible Insertar...");
                    Console.ReadLine();
                }
            }
        }

        //Metodo de recorrido en Pre-Orden
        static void RecorridoPreorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                Console.Write("{0}, ", Raiz.Informacion);
                RecorridoPreorden(Raiz.NodoIzquierdo);
                RecorridoPreorden(Raiz.NodoDerecho);
            }
        }

        //Metodo de recorrido en In-Orden
        static void RecorridoInorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                RecorridoInorden(Raiz.NodoIzquierdo);
                Console.Write("{0}, ", Raiz.Informacion);
                RecorridoInorden(Raiz.NodoDerecho);
            }
        }

        //Metodo de recorrido en Post-Orden
        static void RecorridoPostorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                RecorridoPostorden(Raiz.NodoIzquierdo);
                RecorridoPostorden(Raiz.NodoDerecho);
                Console.Write("{0}, ", Raiz.Informacion);
            }
        }
       
        }
        
        
    
}
