using Dapper;
using Nuna.Lib.DataAccessHelper;
using sekolahku_jude.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace sekolahku_jude.DataAkses
{
    public class JadwalDal
    {
        private string _connString;
        public JadwalDal()
        {
            _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Insert(JadwalModel model)
        {
            //  QUERY
            const string sql = @"
                INSERT INTO Jadwal(KelasId, Hari, JamMulai, JamSelesai, MapelId)
                VALUES (@KelasId, @Hari, @JamMulai, @JamSelesai, @MapelId)";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", model.KelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@Hari", model.Hari, System.Data.SqlDbType.VarChar);
            dp.AddParam("@JamMulai", model.JamMulai, System.Data.SqlDbType.VarChar);
            dp.AddParam("@JamSelesai", model.JamSelesai, System.Data.SqlDbType.VarChar);
            dp.AddParam("@MapelId", model.MapelId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Delete(string kelasId, string hari)
        {
            //  QUERY
            const string sql = @"
                DELETE FROM
                    Jadwal
                WHERE
                    KelasId = @KelasId 
                    AND Hari = @Hari ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", kelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@Hari", hari, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public IEnumerable<JadwalModel> ListData(string kelasId, string hari)
        {
            //  QUERY
            const string sql = @"
                SELECT  
                    aa.KelasId, aa.Hari, aa.JamMulai, aa.JamSelesai, aa.MapelId,
                    ISNULL(bb.KelasName, '') KelasName,
                    ISNULL(cc.MapelName, '') MapelName
                FROM    
                    Jadwal aa
                    LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                    LEFT JOIN Mapel cc ON aa.MapelId = cc.MapelId 
                WHERE
                    aa.KelasId = @KelasId 
                    AND aa.Hari = @Hari ";

            var dp = new DynamicParameters();
            dp.AddParam("KelasId", kelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("Hari", hari, System.Data.SqlDbType.VarChar);


            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Read<JadwalModel>(sql, dp);
            }
        }
    }
}
