using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace TP08_Finkel_Rozen
{
    public static class BD
    {
        
        private static string _connectionString = @"Server=A-PHZ2-CIDI-042;DataBase=BDSeries;Trusted_Connection=True;";

        public static List<Serie> ListarSerie()
        {
           List<Serie> ListaSeries  = new List<Serie>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarSeries";
                ListaSeries = db.Query<Serie>(sp, new {}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaSeries;
        }

         public static List<Actor> ListarActores()
        {
           List<Actor> ListaActor  = new List<Actor>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarActores";
                ListaActor = db.Query<Actor>(sp, new {}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaActor;
        }
        public static List<Temporadas> ListarTemporadas()
        {
           List<Temporadas> ListaTemporada  = new List<Temporadas>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sp = "ListarTemporadas";
                ListaTemporada = db.Query<Temporadas>(sp, new {}, commandType: CommandType.StoredProcedure).ToList();
            }
            return ListaTemporada;
       
        }      
    }
}