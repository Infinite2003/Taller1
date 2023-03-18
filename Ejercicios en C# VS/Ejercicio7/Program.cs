using System;


namespace Ejercicio7{

    class Program{

        public static void Main(string[] args){
         
            
            Console.Clear();
            int op=0, co=0, ci =0, opc=0;
            List<Auto> auto = new List<Auto>(){};
            Lista l = new Lista("Autos Seleccionados", auto);
            
            

            Auto a = new Auto("Ferrari","LaFerrari", 2010, 70, 85);
            Auto b = new Auto("McLaren", "F1 GTR", 1995, 80, 68);
            Auto c = new Auto("Lancia", "Stratos", 1974, 70, 75);
            Auto d = new Auto("Dodge", "Charger", 1966, 80, 60);
            Auto e = new Auto("Bugatti", "Bolide", 2020, 85, 70);

            Console.WriteLine("Bienvenido, tenemos los siguientes vehiculos disponibles. Seleccione un maximo de 3. Puede seleccionar un modelo mas de una ves");
            

            Console.WriteLine(a.MostrarAuto());
            Console.WriteLine(b.MostrarAuto());
            Console.WriteLine(c.MostrarAuto());
            Console.WriteLine(d.MostrarAuto());
            Console.WriteLine(e.MostrarAuto());

            while(co<3){

                Console.WriteLine("Para seleccionar, escriba un numero del 1 hasta el 5");
                op = Convert.ToInt32(Console.ReadLine());

                if(op == 1){

                    l.agregarAuto(a);
                    co++;
                }

                else if(op == 2){

                    l.agregarAuto(b);
                    co++;
                }

                else if(op == 3){

                    l.agregarAuto(c);
                    co++;
                }

                else if(op == 4){

                    l.agregarAuto(d);
                    co++;
                }

                else if(op == 5){

                    l.agregarAuto(e);
                    co++;
                }
            }

            while(ci == 0){

                Console.WriteLine("¿Que desea realizar?");
                Console.WriteLine("1: Mirar autos seleccionados");
                Console.WriteLine("2: Eliminar auto seleccionado");
                Console.WriteLine("3: Agregar un auto");
                Console.WriteLine("4: Cerrar el programa");

                op = Convert.ToInt32(Console.ReadLine());

                if(op == 1){

                    l.verAutos();
                }

                else if(op == 2){

                    Console.WriteLine("Indique el auto a eliminar");
                    int posi;
                    posi = Convert.ToInt32(Console.ReadLine());
                    

                    l.eliminarAuto(posi);
                    co--; 
                }

                else if(op == 3){

                    if(co == 3){

                        Console.WriteLine("Ya posee la capacidad maxima de autos, no puede seleccionar mas de 3");
                    }

                    else{

                        Console.WriteLine("Seleccione un auto");
                        Console.WriteLine(a.MostrarAuto());
                        Console.WriteLine(b.MostrarAuto());
                        Console.WriteLine(c.MostrarAuto());
                        Console.WriteLine(d.MostrarAuto());
                        Console.WriteLine(e.MostrarAuto());

                        opc = Convert.ToInt32(Console.ReadLine());

                        if(opc == 1){

                            l.agregarAuto(a);
                            co++;
                        }

                        else if(opc == 2){

                            l.agregarAuto(b);
                            co++;
                        }

                        else if(opc == 3){

                            l.agregarAuto(c);
                            co++;
                        }

                        else if(opc == 4){

                            l.agregarAuto(d);
                            co++;
                        }

                        else if(opc == 5){

                            l.agregarAuto(e);
                            co++;
                        }
                    }
                }

                else if(op == 4){

                    ci = 1;
                }
            } 
        }
    }
}
