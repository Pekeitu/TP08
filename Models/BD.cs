using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper; 

namespace TP08_Finkel_Rozen
{
    public static class BD
    {
        
        private static string _connectionString = @"Server=DESKTOP-ON8F0P6\SQLEXPRESS;DataBase=BDSeries;Trusted_Connection=True;";

        public static List<Serie> ListarSerie()
        {
           List<Serie> ListaSeries  = new List<Serie>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarSeries";
                ListaSeries = db.Query<Serie>(sp, new {}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaSeries;
        }

        public static Serie ListarSeriePorId(int _IdS)
        {
           Serie SerieDel;
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarSeriesXId";
                SerieDel = db.QueryFirstOrDefault<Serie>(sp, new {IdS = _IdS}, commandType: CommandType.StoredProcedure);
            }
            return SerieDel;
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