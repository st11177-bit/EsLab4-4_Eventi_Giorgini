using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using MarconiPieralisi.DataLayer;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class IndirizzoBL
    {
        #region DML
        internal static long Create(ref MySqlConnection conn, Indirizzo clsIndirizzo, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO indirizzi (nome) VALUES (@nome)";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);
                _cmd.Parameters.AddWithValue("@nome", clsIndirizzo.Nome);

                int _numRec = _cmd.ExecuteNonQuery();
                if (_numRec == 1)
                    _ID = _cmd.LastInsertedId;

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return _ID;
        }

        internal static void Edit(ref MySqlConnection conn, Indirizzo indirizzoNuovo, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE indirizzi SET nome=@nome WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", indirizzoNuovo.Nome);
                _cmd.Parameters.AddWithValue("@ID", ID);

                _cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        internal static void Delete(ref MySqlConnection conn, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "DELETE FROM indirizzi WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@ID", ID);

                _cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        #endregion
        #region QL
        internal static Indirizzo GetOne(ref MySqlConnection conn, long ID, out string errore)
        {
            DataTable _dt = null;
            Indirizzo _indirizzo = null;
            errore = string.Empty;

            if (ID <= 0)
                errore = "ID non valido";
            else
            {
                try
                {
                    string _query = "SELECT * FROM indirizzi WHERE ID=@ID";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _indirizzo = new Indirizzo();
                        var r = _dt.Rows[0];
                        _indirizzo.ID = Convert.ToInt32(r["ID"]);
                        _indirizzo.Nome = r["nome"].ToString();
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _indirizzo;
        }

        internal static List<Indirizzo> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Indirizzo> _indirizzi = new List<Indirizzo>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM indirizzi";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Indirizzo ind = new Indirizzo();
                    ind.ID = Convert.ToInt32(r["ID"]);
                    ind.Nome = r["nome"].ToString();

                    _indirizzi.Add(ind);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _indirizzi;
        }

        internal static int CountIndirizzi(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(ID) FROM indirizzi;";

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
