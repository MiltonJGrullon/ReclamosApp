using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Reclamos
{
    static class Ctool
    {
        public static bool OcError = false;
        public static string StrRutal = @"C:\Log";
        public static string sistema = "Sistema de Reclamos ReclaApp";
        public static string cia = "1";
        public static string usuario = "Prueba";
        public static string vretorno = "";
        
        public static string StrRuta(string Crp = "")
        {
            string r = StrRutal;

            if (!string.IsNullOrEmpty(Crp))
            {
                r = Path.Combine(StrRutal, Crp);
                if (!Directory.Exists(r))
                    Directory.CreateDirectory(r);
            }
            return r;
        }

        public static void LogError(string Error)
        {
            OcError = true;
            TextWriter Tw = new StreamWriter(StrRuta("Log") + @"\logErro.txt", true);
            Tw.WriteLine(DateTime.Now.ToString() + Error);
            Tw.Close();
        }



        public static DataTable ExcSqlDT(string Intrusion)
        {
            DataTable DT = new DataTable();
            try
            {
                C_Conex_Sql.Conex(1);
                SqlDataAdapter Adaptador = new SqlDataAdapter(Intrusion, C_Conex_Sql.SqlCon());
                Adaptador.Fill(DT);
                OcError = false;
            }
            catch (Exception E)
            {
                OcError = true;
                LogError("ExcSqlDT " + E.ToString() + Intrusion);
            }
            finally
            {
                C_Conex_Sql.Conex(2);

            }
            return DT;
        }
         

        public static void ExcSql(string Intrusion)
        {
            try
            {
                C_Conex_Sql.Conex(1); //esto es para validar que la conexion no se abra si ya lo estas
                SqlCommand ComandoSQL = new SqlCommand
                {
                    Connection = C_Conex_Sql.SqlCon(),
                    CommandType = CommandType.Text,
                    Transaction = C_Conex_Sql.TransSql,
                    CommandText = Intrusion
                };
                ComandoSQL.ExecuteNonQuery();

                OcError = false;
            }
            catch (Exception E)
            {
                OcError = true;
                LogError("ExcSql " + E.ToString());
            }
            finally
            {
                C_Conex_Sql.Conex(2);
            }
        }

        public static bool valexitbl(string vtbl, string vwhere)
        {
            return Ctool.ExcSqlDT($"Select * from {vtbl} where {vwhere}").Rows.Count > 0;
        }

        public static string nomdir(string vtbl, string vwhere)
        {
            DataTable dtdir = Ctool.ExcSqlDT($"Select nombre from {vtbl} where  {vwhere}");
            if(dtdir.Rows.Count > 0)
                return dtdir.Rows[0][0].ToString().Trim();
            else
                return  "Error. No existe.";

        }

        public static string nomentidades(string vtbl, string vwhere)
        {
            DataTable dtent = Ctool.ExcSqlDT($"Select nombre+' '+apellidos from {vtbl} where  {vwhere}");
            if (dtent.Rows.Count > 0)
                return dtent.Rows[0][0].ToString().Trim();
            else
                return "Error. No existe.";

        }

        public static string desdep(string vtbl, string vwhere)
        {
            DataTable dtdes = Ctool.ExcSqlDT($"Select Descripcion from {vtbl} where  {vwhere}");
            if (dtdes.Rows.Count > 0)
                return dtdes.Rows[0][0].ToString().Trim();
            else
                return "Error. No existe.";

        }

       
    }
}
