using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class ClasseBL
    {
        // Andrea Giorgini - ClasseBL

        #region DML
        internal static long Create(ref MySqlConnection conn, Classe clsClasse, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO classi (sigla, aula, anno, sezione, indirizzoID) VALUES (@sigla, @aula, @anno, @sezione, @indirizzoID)";

                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@sigla", clsClasse.Sigla);
                _cmd.Parameters.AddWithValue("@aula", clsClasse.Aula);
                _cmd.Parameters.AddWithValue("@anno", clsClasse.Anno);
                _cmd.Parameters.AddWithValue("@sezione", clsClasse.Sezione);
                _cmd.Parameters.AddWithValue("@indirizzoID", clsClasse.IndirizzoID);

                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1)
                    _ID = _cmd.LastInsertedId;

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }

            return _ID;
        }

        internal static void Edit(ref MySqlConnection conn, Classe classeNuova, string SIGLA, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE classi SET aula=@aula, anno=@anno, sezione=@sezione, indirizzoID=@indirizzoID WHERE sigla=@sigla";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@aula", classeNuova.Aula);
                _cmd.Parameters.AddWithValue("@anno", classeNuova.Anno);
                _cmd.Parameters.AddWithValue("@sezione", classeNuova.Sezione);
                _cmd.Parameters.AddWithValue("@indirizzoID", classeNuova.IndirizzoID);
                _cmd.Parameters.AddWithValue("@sigla", SIGLA);

                _cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }

        internal static void Delete(ref MySqlConnection conn, string SIGLA, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "DELETE FROM classi WHERE sigla=@sigla";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@sigla", SIGLA);

                _cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }
        #endregion

        #region QL

        internal static Classe GetOne(ref MySqlConnection conn, string SIGLA, out string errore)
        {
            DataTable _dt = null;
            Classe _classe = null;
            errore = string.Empty;

            if (string.IsNullOrEmpty(SIGLA))
                errore = "Sigla non valida";
            else
            {
                try
                {
                    string _query = "SELECT * FROM classi WHERE sigla=@sigla";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@sigla", SIGLA);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _classe = new Classe();
                        var r = _dt.Rows[0];
                        _classe.Sigla = r["sigla"].ToString();
                        _classe.Aula = r["aula"].ToString();
                        _classe.Anno = Convert.ToByte(r["anno"]);
                        _classe.Sezione = r["sezione"].ToString();
                        _classe.IndirizzoID = Convert.ToInt32(r["indirizzoID"]);
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _classe;
        }

        internal static List<Classe> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Classe> _classi = new List<Classe>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM classi";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Classe c = new Classe();
                    c.Sigla = r["sigla"].ToString();
                    c.Aula = r["aula"].ToString();
                    c.Anno = Convert.ToByte(r["anno"]);
                    c.Sezione = r["sezione"].ToString();
                    c.IndirizzoID = Convert.ToInt32(r["indirizzoID"]);

                    _classi.Add(c);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _classi;
        }

        internal static int CountClassi(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(sigla) FROM classi;";

                conn.Open();

                MySqlCommand _cmd = new MySqlCommand(_query, conn);
                object _obj = _cmd.ExecuteScalar();

                if (_obj != null)
                {
                    _count = Convert.ToInt32(_obj.ToString());
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _count;
        }

        #endregion
    }
}
