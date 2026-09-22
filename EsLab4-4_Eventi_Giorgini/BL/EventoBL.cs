using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class EventoBL
    {
        // Andrea Giorgini - EventoBL

        #region DML
        internal static long Create(ref MySqlConnection conn, Evento clsEvento, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO eventi (nome, descrizione, dal, al, adminID) VALUES (@nome, @descrizione, @dal, @al, @adminID)";

                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", clsEvento.Nome);
                _cmd.Parameters.AddWithValue("@descrizione", clsEvento.Descrizione ?? string.Empty);
                _cmd.Parameters.AddWithValue("@dal", clsEvento.Dal);
                _cmd.Parameters.AddWithValue("@al", clsEvento.Al);
                _cmd.Parameters.AddWithValue("@adminID", clsEvento.AdminID);

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

        internal static void Edit(ref MySqlConnection conn, Evento eventoNuovo, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE eventi SET nome=@nome, descrizione=@descrizione, dal=@dal, al=@al, adminID=@adminID WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", eventoNuovo.Nome);
                _cmd.Parameters.AddWithValue("@descrizione", eventoNuovo.Descrizione ?? string.Empty);
                _cmd.Parameters.AddWithValue("@dal", eventoNuovo.Dal);
                _cmd.Parameters.AddWithValue("@al", eventoNuovo.Al);
                _cmd.Parameters.AddWithValue("@adminID", eventoNuovo.AdminID);
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
                string _sql = "DELETE FROM eventi WHERE ID=@ID";
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

        internal static Evento GetOne(ref MySqlConnection conn, long ID, out string errore)
        {
            DataTable _dt = null;
            Evento _evento = null;
            errore = string.Empty;

            if (ID <= 0)
                errore = "ID non valido";
            else
            {
                try
                {
                    string _query = "SELECT * FROM eventi WHERE ID=@ID";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _evento = new Evento();
                        var r = _dt.Rows[0];
                        _evento.ID = Convert.ToInt32(r["ID"]);
                        _evento.Nome = r["nome"].ToString();
                        _evento.Descrizione = r["descrizione"].ToString();
                        _evento.Dal = Convert.ToDateTime(r["dal"]);
                        _evento.Al = Convert.ToDateTime(r["al"]);
                        _evento.AdminID = Convert.ToInt32(r["adminID"]);
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _evento;
        }

        internal static List<Evento> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Evento> _eventi = new List<Evento>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM eventi";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Evento e = new Evento();
                    e.ID = Convert.ToInt32(r["ID"]);
                    e.Nome = r["nome"].ToString();
                    e.Descrizione = r["descrizione"].ToString();
                    e.Dal = Convert.ToDateTime(r["dal"]);
                    e.Al = Convert.ToDateTime(r["al"]);
                    e.AdminID = Convert.ToInt32(r["adminID"]);

                    _eventi.Add(e);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _eventi;
        }



        internal static int CountEventi(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(ID) FROM eventi;";

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
