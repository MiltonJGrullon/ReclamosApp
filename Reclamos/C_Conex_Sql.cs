using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Reclamos
{
    public class C_Conex_Sql
    {
        public static SqlConnection ConxSql;
        public static SqlTransaction TransSql;
        public static bool EstTrans = false;
        public C_Conex_Sql()
        {
            if (!EstTrans)
                MetConx(1);
        }

        public static void MetConx(int Tip, bool BiginTrnas = false)
        {
            if (EstTrans && Tip == 1)
            {

            }
            else if (Tip == 0)// Rollback y Finalizar C_Conex_Sql
            {
                if (EstTrans) TransSql.Rollback();
                if (ConxSql.State == ConnectionState.Open) ConxSql.Close();
                EstTrans = false;
            }
            else if (Tip == 1) // Nueva C_Conex_Sql con o sin BeginTransaction
            {
                ConxSql = new SqlConnection(CadeSql);
                if (ConxSql.State == ConnectionState.Closed) ConxSql.Open();
                if (!EstTrans && BiginTrnas)
                {
                    EstTrans = true;
                    TransSql = ConxSql.BeginTransaction();
                }

            }
            else if (Tip == 2) //Finalizar C_Conex_Sql con o sin BeginTransaction Commit
            {
                if (ConxSql.State == ConnectionState.Open)
                {
                    if (EstTrans)
                    {
                        EstTrans = false;
                        TransSql.Commit();
                    }
                    if (ConxSql.State == ConnectionState.Open) ConxSql.Close();
                }
            }
        }

        public static string CadeSql
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Reclamos.Properties.Settings.Cadenasql"].ToString();
            }
        }

        public static SqlConnection SqlCon()
        {
            return ConxSql;
        }

        public static void Conex(int p)
        {
            if (p == 1)
                MetConx(1);
            else if (p == 2 && !EstTrans)
                MetConx(0);
            else if (p == 3 && EstTrans)
                MetConx(0);
        }


    }
}
