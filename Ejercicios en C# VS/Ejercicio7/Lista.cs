using System;


namespace Ejercicio7{

    class Lista{
        
        private string _Nombre="";
        private List<Auto> _autos;

        public string nombre{

            get{return this._Nombre;}
            set{this._Nombre = value;}
        }

        public List<Auto> autos{

            get{return this._autos;}
            set{this._autos = value;}
        }

        public void verAutos(){

            foreach (Auto aux in this._autos){

                Console.WriteLine(aux.MostrarAuto());
            }             
        }

        public void agregarAuto(Auto auto){

               this._autos.Add(auto);
               Console.WriteLine("Auto agregado correctamente a la automotora"); 
        }

        public void eliminarAuto(int pos){
            
            for(int x = 0; x < _autos.Count; x++){


                if(pos == x){

                    this._autos.Remove(this._autos[pos]);
                    Console.WriteLine("El nivel se a eliminado correctamente"); 
                }

                else{

                    Console.WriteLine("A ocurrido un error al intentar eliminar el nivel. Posiblemente no existe");
                }
            }  
        }

        public Lista(string nombre, List<Auto> autos){

            this._Nombre = nombre;
            this._autos = new List<Auto>(){};
        }

        public override string ToString(){

            return $" {this._Nombre} ";
        }
    }
}