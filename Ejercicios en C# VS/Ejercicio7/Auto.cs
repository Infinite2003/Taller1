using System;

namespace Ejercicio7{

    class Auto{

        private string _Fabricante = "";
        private string _Modelo = "";
        private int _Anio;
        private double _PorVelocidad;
        private double _PorManiobravilidad;

        public string fabricante{

            get{return this._Fabricante;}
            set{this._Fabricante = value;}
        }

        public string modelo{

            get{return this._Modelo;}
            set{this._Modelo = value;}
        }

        public int anio{

            get{return this._Anio;}
            set{this._Anio = value;}
        }

        public double porvelocidad{

            get{return this._PorVelocidad;}
            set{this._PorVelocidad = value;}
        }

        public double pormaniobravilidad{

            get{return this._PorManiobravilidad;}
            set{this._PorManiobravilidad = value;}
        }

        public Auto (string fabricante="", string modelo="", int anio=0, double porvelocidad=0, double pormaniobravilidad=0){

            this._Fabricante = fabricante;
            this._Modelo = modelo;
            this._Anio = anio; 
            this._PorVelocidad = porvelocidad;
            this._PorManiobravilidad = pormaniobravilidad;
        }

        public string MostrarAuto(){

            return $"Fabricante: {this._Fabricante} - Modelo: {this._Modelo} - Anio: {this._Anio} - Porcentaje Velocidad: {this._PorVelocidad} - Porcentaje Maniobravilidad: {this._PorManiobravilidad}";
        }
    }
}