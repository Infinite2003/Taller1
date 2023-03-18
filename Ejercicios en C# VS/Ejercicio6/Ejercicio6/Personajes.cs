using System;


namespace Ejercicio6
{
    class Personajes {
    
        private string _Tipo="";
        private string _Nombre="";
        private int _Vida;
        private int _Poder;
        private int _Velocidad;

        public string tipo {

            get{return this._Tipo;}
            set{this._Tipo = value;}
        }

        public string nombre{
            get{return this._Nombre;}
            set{this._Nombre = value;}
        }

        public int vida{
            get{return this._Vida;}
            set{this._Vida = value;}
        }

        public int poder{
            get{return this._Poder;}
            set{this._Poder = value;}
        }



        public int velocidad{
            get{return this._Velocidad;}
            set{this._Velocidad = value;}
        }

        public void descansar(){

            this._Vida = this._Vida + 15;            
        }

        public void atacar(){

            Console.WriteLine("Usted a atacado");
        }

        public void cargar(){

            Console.WriteLine("Se esta cargando energia");
            this._Poder = this._Poder * 2;
        }

        public Personajes(string tipo, string nombre, int poder, int vida, int velocidad){ 
            
            this._Tipo = tipo;
            this._Nombre = nombre;
            this._Poder = poder;
            this._Vida = vida;
            this._Velocidad = velocidad;
        }

        public string ToString(){

            return $"Tipo: {this._Tipo}-Nombre: {this._Nombre}-Vida: {this._Vida}-Poder: {this._Poder}-Velocidad: {this._Velocidad}";
        }

    }
}


