using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class AttivitaBL
    {
        // Andrea Giorgini - AttivitaBL

        #region DML
        internal static long Create(ref MySqlConnection conn, Attivita clsAttivita, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO attivita (titolo, testo, ordine, dalle, alle, eventoID) VALUES (@titolo, @testo, @ordine, @dalle, @alle, @eventoID)";

                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@titolo", clsAttivita.Titolo);
                _cmd.Parameters.AddWithValue("@testo", clsAttivita.Testo);
                _cmd.Parameters.AddWithValue("@ordine", clsAttivita.Ordine);
                _cmd.Parameters.AddWithValue("@dalle", clsAttivita.Dalle);
                _cmd.Parameters.AddWithValue("@alle", clsAttivita.Alle);
                _cmd.Parameters.AddWithValue("@eventoID", clsAttivita.EventoID);

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

        internal static void Edit(ref MySqlConnection conn, Attivita attivitaNuova, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE attivita SET titolo=@titolo, testo=@testo, ordine=@ordine, dalle=@dalle, alle=@alle, eventoID=@eventoID WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@titolo", attivitaNuova.Titolo);
                _cmd.Parameters.AddWithValue("@testo", attivitaNuova.Testo);
                _cmd.Parameters.AddWithValue("@ordine", attivitaNuova.Ordine);
                _cmd.Parameters.AddWithValue("@dalle", attivitaNuova.Dalle);
                _cmd.Parameters.AddWithValue("@alle", attivitaNuova.Alle);
                _cmd.Parameters.AddWithValue("@eventoID", attivitaNuova.EventoID);
                _cmd.Parameters.AddWithValue("@ID", ID);

                _cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }

        internal static void Delete(ref MySqlConnection conn, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "DELETE FROM attivita WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@ID", ID);

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

        internal static Attivita GetOne(ref MySqlConnection conn, long ID, out string errore)
        {
            DataTable _dt = null;
            Attivita _attivita = null;
            errore = string.Empty;

            if (ID <= 0)
                errore = "ID non valido";
            else
            {
                try
                {
                    string _query = "SELECT * FROM attivita WHERE ID=@ID";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _attivita = new Attivita();
                        var r = _dt.Rows[0];
                        _attivita.ID = Convert.ToInt32(r["ID"]);
                        _attivita.Titolo = r["titolo"].ToString();
                        _attivita.Testo = r["testo"].ToString();
                        _attivita.Ordine = Convert.ToByte(r["ordine"]);
                        _attivita.Dalle = Convert.ToDateTime(r["dalle"]);
                        _attivita.Alle = Convert.ToDateTime(r["alle"]);
                        _attivita.EventoID = Convert.ToInt32(r["eventoID"]);
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _attivita;
        }

        internal static List<Attivita> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Attivita> _attivitaList = new List<Attivita>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM attivita";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Attivita a = new Attivita();
                    a.ID = Convert.ToInt32(r["ID"]);
                    a.Titolo = r["titolo"].ToString();
                    a.Testo = r["testo"].ToString();
                    a.Ordine = Convert.ToByte(r["ordine"]);
                    a.Dalle = Convert.ToDateTime(r["dalle"]);
                    a.Alle = Convert.ToDateTime(r["alle"]);
                    a.EventoID = Convert.ToInt32(r["eventoID"]);

                    _attivitaList.Add(a);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _attivitaList;
        }

        internal static List<Attivita> GetAllByEvento(ref MySqlConnection conn, long eventoID, out string errore)
        {
            DataTable _dt = null;
            List<Attivita> _attivitaList = new List<Attivita>();
            errore = string.Empty;
            try
            {
                conn.Open();
                string _query = "SELECT * FROM attivita WHERE eventoID=@eventoID";
                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                _da.SelectCommand.Parameters.AddWithValue("@eventoID", eventoID);
                _dt = new DataTable();
                _da.Fill(_dt);
                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Attivita a = new Attivita();
                    a.ID = Convert.ToInt32(r["ID"]);
                    a.Titolo = r["titolo"].ToString();
                    a.Testo = r["testo"].ToString();
                    a.Ordine = Convert.ToByte(r["ordine"]);
                    a.Dalle = Convert.ToDateTime(r["dalle"]);
                    a.Alle = Convert.ToDateTime(r["alle"]);
                    a.EventoID = Convert.ToInt32(r["eventoID"]);
                    _attivitaList.Add(a);
                }
                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }
            return _attivitaList;
        } 

        internal static int CountAttivita(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(ID) FROM attivita;";

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
