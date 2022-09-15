using System;

namespace TP08_Finkel_Rozen
{
    public class Temporadas
    {
        private int _IdTemporada;
        private int _IdSerie;
        private int _NumeroTemporada;
        private string _TituloTemporada;
        
        public Temporadas(int IdTemporada, int IdSerie, int NumeroTemporada,string TituloTemporada)
        {  
            _IdTemporada = IdTemporada;
            _IdSerie = IdSerie;
            _NumeroTemporada = NumeroTemporada;
            _TituloTemporada = TituloTemporada;
        }
        public Temporadas(){}
         public int IdAcIdTemporadator
        {
            get {return _IdTemporada;}
            set {_IdTemporada = value; }
        }
        public int IdSerie
        {
            get {return _IdSerie;}
            set {_IdSerie = value; }
        }
        public int NumeroTemporada
        {
            get {return _NumeroTemporada;}
            set {_NumeroTemporada = value; }
        }
        public string TituloTemporada
        {
            get {return _TituloTemporada;}
            set {_TituloTemporada = value; }
        }
    }
}