using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper; 

namespace TP08_Finkel_Rozen
{
    public static class BD
    {
        
        private static string _connectionString = @"Server=A-PHZ2-CIDI-012;DataBase=BDSeries;Trusted_Connection=True;";

        public static List<Serie> ListarSerie()
        {
           List<Serie> ListaSeries  = new List<Serie>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarSeries";
                ListaSeries = db.Query<Serie>(sp, new {}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaSeries;
        }

        public static List<Serie> ListarSeriePorId(int _IdS)
        {
           List<Serie> ListaSeries  = new List<Serie>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarSeriesXId";
                ListaSeries = db.Query<Serie>(sp, new {IdS = _IdS}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaSeries;
        }

         public static List<Actor> ListarActoresPorSerie(int _IdS)
        {
           List<Actor> ListaActor  = new List<Actor>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarActores";
                ListaActor = db.Query<Actor>(sp, new {IdS = _IdS}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaActor;
        }
        public static List<Temporadas> ListarTemporadasPorSerie(int _IdS)
        {
           List<Temporadas> ListaTemporada  = new List<Temporadas>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarTemporadas";
                ListaTemporada = db.Query<Temporadas>(sp, new {IdS = _IdS}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaTemporada;
       
        }      
    }
}