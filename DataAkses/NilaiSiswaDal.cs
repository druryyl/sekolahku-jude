using Dapper;
using Nuna.Lib.DataAccessHelper;
using sekolahku_jude.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace sekolahku_jude.DataAkses
{
    public class NilaiSiswaDal
    {
        private string _connString;

        public NilaiSiswaDal()
        {
            _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void Insert(NilaiSiswaModel model)
        {
            //  QUERY
            const string sql = @"
                INSERT INTO NilaiSiswa(SiswaId, KelasId, MapelId, Nilai)
                VALUES (@SiswaId, @KelasId, @MapelId, @Nilai)";

            //  PARAM
            var dp = new DynamicParameters();

            dp.AddParam("@SiswaId", model.SiswaId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@KelasId", model.KelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@MapelId", model.MapelId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@Nilai", model.Nilai, System.Data.SqlDbType.Decimal);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public void Delete(string kelasId, string siswaId)
        {
            //  QUERY
            const string sql = @"
                DELETE FROM
                    NilaiSiswa
                WHERE
                    KelasId = @KelasId 
                    AND SiswaId = @SiswaId ";

            //  PARAM
            var dp = new DynamicParameters();
            dp.AddParam("@KelasId", kelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("@SiswaId", siswaId, System.Data.SqlDbType.VarChar);

            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                conn.Execute(sql, dp);
            }
        }

        public IEnumerable<NilaiSiswaModel> ListData(string kelasId, string siswaId)
        {
            //  QUERY
            const string sql = @"
                SELECT  
                    aa.SiswaId, aa.KelasId, aa.MapelId, aa.Nilai
                    ISNULL(bb.KelasName, '') KelasName,
                    ISNULL(cc.MapelName, '') MapelName,
                    ISNULL(dd.SiswaName, '') SiswaName
                FROM    
                    NilaiSiswa aa
                    LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                    LEFT JOIN Mapel cc ON aa.MapelId = cc.MapelId 
                    LEFT JOIN Siswa dd ON aa.SiswaId = dd.SiswaId
                WHERE
                    aa.KelasId = @KelasId 
                    AND aa.Siswa = @SiswaId";

            var dp = new DynamicParameters();
            dp.AddParam("KelasId", kelasId, System.Data.SqlDbType.VarChar);
            dp.AddParam("SiswaId", siswaId, System.Data.SqlDbType.VarChar);


            //  EXECUTE
            using (var conn = new SqlConnection(_connString))
            {
                return conn.Read<NilaiSiswaModel>(sql, dp);
            }
        }
    }
}
