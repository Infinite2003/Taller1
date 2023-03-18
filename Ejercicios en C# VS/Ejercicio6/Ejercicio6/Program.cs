using System;

namespace Ejercicio6{

    class Program{

        public static void Main(string[] args){

            Console.Clear();

            int op1, op2, con=0, t1, t2, vida1=0, vida2=0, poder1=0, poder2=0, velocidad1=0, velocidad2=0;
            string nombre1="", nombre2="", tipo1="", tipo2="";

            Console.WriteLine("Elija su personaje: 1-Mago, 2-Barbaro, 3-Caballero, 4-Asesino");
            op1= Convert.ToInt32(Console.ReadLine());

            if(op1 == 1){

               Console.WriteLine("Ingrese su nombre");
               nombre1 = Convert.ToString(Console.ReadLine());
                tipo1 = "Mago";
                vida1 = 25;
                poder1 = 10;
                velocidad1 = 25;
            }

            else if(op1 == 2){

               Console.WriteLine("Ingrese su nombre");
               nombre1 = Convert.ToString(Console.ReadLine());
                tipo1 = "Barbaro";
                vida1 = 30;
                poder1 = 15;
                velocidad1 = 8;
            }

            else if(op1 == 3){

               Console.WriteLine("Ingrese su nombre");
               nombre1 = Convert.ToString(Console.ReadLine());
                tipo1 = "Caballero";
                vida1 = 35;
                poder1 = 10;
                velocidad1 = 16;
            }

            else if(op1 == 4){

               Console.WriteLine("Ingrese su nombre");
               nombre1 = Convert.ToString(Console.ReadLine());
                tipo1 = "Asesino";
                vida1 = 28;
                poder1 = 5;
                velocidad1 = 50;
            }

            Console.WriteLine("Elija su personaje: 1-Mago, 2-Barbaro, 3-Caballero, 4-Asesino");
            op2 = Convert.ToInt32(Console.ReadLine());

            if(op2 == 1){

               Console.WriteLine("Ingrese su nombre");
               nombre2 = Convert.ToString(Console.ReadLine());
                tipo2 = "Mago";
                vida2 = 25;
                poder2 = 10;
                velocidad2 = 25;
            }

            else if(op2 == 2){

               Console.WriteLine("Ingrese su nombre");
               nombre2 = Convert.ToString(Console.ReadLine());

               tipo2 = "Barbaro";
                vida2 = 30;
                poder2 = 15;
                velocidad2 = 8;
            }

            else if(op2 == 3){

               Console.WriteLine("Ingrese su nombre");
               nombre2 = Convert.ToString(Console.ReadLine());

               tipo2 = "Caballero";
                vida2 = 35;
                poder2 = 10;
                velocidad2 = 16;
            }

            else if(op2 == 4){

               Console.WriteLine("Ingrese su nombre");
               nombre2 = Convert.ToString(Console.ReadLine());

               tipo2 = "Asesino";
                vida2 = 28;
                poder2 = 5;
                velocidad2 = 50;


            }

            Personajes p1 = new Personajes(tipo1, nombre1, poder1, vida1, velocidad1);
            Personajes p2 = new Personajes(tipo2, nombre2, poder2, vida2, velocidad2);
            



            while(con!=1){


                Console.WriteLine(p1.ToString());
                Console.WriteLine(p2.ToString());

                

                if(velocidad1 > velocidad2){
                    
                    Console.WriteLine("Jugador 1: Elija su accion: 1.- Atacar, 2.- Cargar, 3.- Descansar");
                    t1 = Convert.ToInt32(Console.ReadLine());
                    
                    if(t1 == 1){

                        p1.atacar();

                        p2.vida = p2.vida - p1.poder;
                    }

                    else if(t1 == 2){

                        p1.cargar();
                    }

                    else if(t1==3){

                        p1.descansar();
                    }

                    Console.WriteLine("Jugador 2: Elija su accion: 1.- Atacar, 2.- Cargar, 3.- Descansar");

                    t2 = Convert.ToInt32(Console.ReadLine());

                    if(t2 == 1){

                        p2.atacar();

                        p1.vida = p1.vida - p2.poder;
                    }

                    else if(t2 == 2){

                        p2.cargar();
                    }

                    else if(t2==3){

                        p2.descansar();
                    }

                }

                else if(velocidad2>velocidad1){

                    Console.WriteLine("Jugador 2: Elija su accion: 1.- Atacar, 2.- Cargar, 3.- Descansar");
                    
                    t2 = Convert.ToInt32(Console.ReadLine());
                    
                    if(t2 == 1){

                        p2.atacar();

                        p1.vida = p1.vida - p2.poder;
                    }

                    else if(t2 == 2){

                        p2.cargar();
                    }

                    else if(t2==3){

                        p2.descansar();
                    }

                    Console.WriteLine("Jugador 1: Elija su accion: 1.- Atacar, 2.- Cargar, 3.- Descansar");

                    t1 = Convert.ToInt32(Console.ReadLine());

                    if(t1 == 1){

                        p1.atacar();

                        p2.vida = p2.vida - p1.poder;
                    }

                    else if(t1 == 2){

                        p1.cargar();
                    }

                    else if(t1==3){

                        p1.descansar();
                    }
                }
                

                if( p1.vida <= 0){

                    Console.WriteLine("Gana el jugador 2");
                    con = 1;
                }

                else if( p2.vida <= 0){

                    Console.WriteLine("Gana el jugador 1");
                    con = 1;
                }

                else {

                    con = 0;
                }

            }

        }
    }
}

