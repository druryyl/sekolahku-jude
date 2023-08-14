using Dapper;
using Nuna.Lib.DataAccessHelper;
using sekolahku_jude.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace sekolahku_jude.DataAkses
{
    public class MapelDal
    {
        private string _connString;

        public MapelDal()
        {
            _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public void Insert(MapelModel model)
        {
            const string sql = @"
                INSERT INTO Mapel (MapelId, MapelName)
                VALUES (@MapelId, @MapelName)";

            var dp = new DynamicParameters();
            dp.AddParam("@MapelId", model.MapelId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@MapelName", model.MapelName, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Update(MapelModel model)
        {
            const string sql = @"
                UPDATE Mapel 
                SET MapelName = @MapelName
                WHERE MapelId = @MapelId";

            var dp = new DynamicParameters();
            dp.AddParam("@MapelId", model.MapelId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@MapelName", model.MapelName, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Delete(string mapelId)
        {
            const string sql = @"
                DELETE FROM Mapel 
                WHERE MapelId = @MapelId";

            var dp = new DynamicParameters();
            dp.AddParam("@MapelId", mapelId, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public MapelModel GetData(string mapelId)
        {
            const string sql = @"
                SELECT MapelId, MapelName
                FROM Mapel 
                WHERE MapelId = @MapelId";

            var dp = new DynamicParameters();
            dp.AddParam("@MapelId", mapelId, System.Data.SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                return conn.ReadSingle<MapelModel>(sql, dp);
            }
        }

        public IEnumerable<MapelModel> ListData()
        {
            const string sql = @"
                SELECT MapelId, MapelName
                FROM Mapel ";

            using (var conn = new SqlConnection(_connString))
            {
                return conn.Read<MapelModel>(sql);
            }
        }
    }
}
