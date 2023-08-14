using Dapper;
using Nuna.Lib.DataAccessHelper;
using sekolahku_jude.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sekolahku_jude.DataAkses
{
    public class KelasDal
    {
        private string _connString;
        public KelasDal()
        {
            _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Insert(KelasModel model)
        {
            //  QUERY
            const string sql = @"
                INSERT INTO Kelas(KelasId, KelasName, WaliKelasId)
                VALUES (@KelasId, @KelasName, @WaliKelasId)";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", model.KelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@KelasName", model.KelasName, System.Data.SqlDbType.VarChar);
            dp.AddParam("@WaliKelasId", model.WaliKelasId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Update(KelasModel model)
        {
            //  QUERY
            const string sql = @"
                UPDATE
                    Kelas
                SET
                    KelasName = @KelasName,
                    WaliKelasId = @WaliKelasId
                WHERE
                    KelasId = @KelasId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", model.KelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@KelasName", model.KelasName, System.Data.SqlDbType.VarChar);
            dp.AddParam("@WaliKelasId", model.WaliKelasId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }
        public void Delete(string KelasId)
        {
            //  QUERY
            const string sql = @"
                DELETE FROM
                    Kelas
                WHERE
                    KelasId = @KelasId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", KelasId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }
        public KelasModel GetData(string KelasId)
        {
            //  QUERY
            const string sql = @"
                SELECT  aa.KelasId, aa.KelasName, aa.WaliKelasId,
                        ISNULL(bb.GuruName, '') AS WaliKelasName
                FROM    Kelas aa
                LEFT JOIN Guru bb ON aa.WaliKelasId = bb.GuruId
                WHERE   KelasId = @KelasId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", KelasId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                return conn.ReadSingle<KelasModel>(sql, dp);
            }
        }

        public IEnumerable<KelasModel> ListData()
        {
            //  QUERY
            const string sql = @"
                SELECT  aa.KelasId, aa.KelasName, aa.WaliKelasId,
                        ISNULL(bb.GuruName, '') AS WaliKelasName
                FROM    Kelas aa
                LEFT JOIN Guru bb ON aa.WaliKelasId = bb.GuruId";

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Read<KelasModel>(sql);
            }
        }
    }
}
