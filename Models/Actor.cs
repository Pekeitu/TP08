using System;

namespace TP08_Finkel_Rozen
{
    public class Actor
    {
        private int _IdActor;
        private int _IdSerie;
        private string _Nombre;
        
        public Actor(int IdActor, int IdSerie, string Nombre)
        {  
            _IdActor = IdActor;
            _IdSerie = IdSerie;
            _Nombre = Nombre;
        }
        public Actor(){}
         public int IdActor
        {
            get {return _IdActor;}
             set {_IdActor = value; }
        }
        public int IdSerie
        {
            get {return _IdSerie;}
            set {_IdSerie = value; }
        }
        public string Nombre
        {
            get {return _Nombre;}
            set {_Nombre = value; }
        }
    }
}