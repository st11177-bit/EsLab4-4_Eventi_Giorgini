using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class AderireBL
    {
        // Andrea Giorgini - AderireBL

        #region DML
        internal static long Create(ref MySqlConnection conn, Aderire clsAderire, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO aderire (iscritto, autorizzato, pagato, partecipato, attivitaID, classeID, studenteID) VALUES (@iscritto, @autorizzato, @pagato, @partecipato, @attivitaID, @classeID, @studenteID)";

                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@iscritto", clsAderire.Iscritto);
                _cmd.Parameters.AddWithValue("@autorizzato", clsAderire.Autorizzato);
                _cmd.Parameters.AddWithValue("@pagato", clsAderire.Pagato);
                _cmd.Parameters.AddWithValue("@partecipato", clsAderire.Partecipato);
                _cmd.Parameters.AddWithValue("@attivitaID", clsAderire.AttivitaID);
                _cmd.Parameters.AddWithValue("@classeID", clsAderire.ClasseID ?? string.Empty);
                _cmd.Parameters.AddWithValue("@studenteID", clsAderire.StudenteID);

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

        internal static void Edit(ref MySqlConnection conn, Aderire aderireNuovo, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE aderire SET iscritto=@iscritto, autorizzato=@autorizzato, pagato=@pagato, partecipato=@partecipato, attivitaID=@attivitaID, classeID=@classeID, studenteID=@studenteID WHERE IDaderire=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@iscritto", aderireNuovo.Iscritto);
                _cmd.Parameters.AddWithValue("@autorizzato", aderireNuovo.Autorizzato);
                _cmd.Parameters.AddWithValue("@pagato", aderireNuovo.Pagato);
                _cmd.Parameters.AddWithValue("@partecipato", aderireNuovo.Partecipato);
                _cmd.Parameters.AddWithValue("@attivitaID", aderireNuovo.AttivitaID);
                _cmd.Parameters.AddWithValue("@classeID", aderireNuovo.ClasseID ?? string.Empty);
                _cmd.Parameters.AddWithValue("@studenteID", aderireNuovo.StudenteID);
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
                string _sql = "DELETE FROM aderire WHERE IDaderire=@ID";
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

        internal static Aderire GetOne(ref MySqlConnection conn, long ID, out string errore)
        {
            DataTable _dt = null;
            Aderire _aderire = null;
            errore = string.Empty;

            if (ID <= 0)
                errore = "ID non valido";
            else
            {
                try
                {
                    string _query = "SELECT * FROM aderire WHERE IDaderire=@ID";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _aderire = new Aderire();
                        var r = _dt.Rows[0];
                        _aderire.IDAderire = Convert.ToInt32(r["IDaderire"]);
                        _aderire.Iscritto = Convert.ToBoolean(r["iscritto"]);
                        _aderire.Autorizzato = Convert.ToBoolean(r["autorizzato"]);
                        _aderire.Pagato = Convert.ToBoolean(r["pagato"]);
                        _aderire.Partecipato = Convert.ToBoolean(r["partecipato"]);
                        _aderire.AttivitaID = Convert.ToInt32(r["attivitaID"]);
                        _aderire.ClasseID = r["classeID"].ToString();
                        _aderire.StudenteID = Convert.ToInt32(r["studenteID"]);
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _aderire;
        }

        internal static List<Aderire> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Aderire> _aderires = new List<Aderire>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM aderire";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Aderire a = new Aderire();
                    a.IDAderire = Convert.ToInt32(r["IDaderire"]);
                    a.Iscritto = Convert.ToBoolean(r["iscritto"]);
                    a.Autorizzato = Convert.ToBoolean(r["autorizzato"]);
                    a.Pagato = Convert.ToBoolean(r["pagato"]);
                    a.Partecipato = Convert.ToBoolean(r["partecipato"]);
                    a.AttivitaID = Convert.ToInt32(r["attivitaID"]);
                    a.ClasseID = r["classeID"].ToString();
                    a.StudenteID = Convert.ToInt32(r["studenteID"]);

                    _aderires.Add(a);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _aderires;
        }

        internal static List<Aderire> GetAllByAttivitaID(ref MySqlConnection conn, int attivitaID, out string errore)
        {
            DataTable _dt = null;
            List<Aderire> _aderires = new List<Aderire>();
            errore = string.Empty;
            try
            {
                conn.Open();
                string _query = "SELECT * FROM aderire WHERE attivitaID=@attivitaID";
                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                _da.SelectCommand.Parameters.AddWithValue("@attivitaID", attivitaID);
                _dt = new DataTable();
                _da.Fill(_dt);
                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Aderire a = new Aderire();
                    a.IDAderire = Convert.ToInt32(r["IDaderire"]);
                    a.Iscritto = Convert.ToBoolean(r["iscritto"]);
                    a.Autorizzato = Convert.ToBoolean(r["autorizzato"]);
                    a.Pagato = Convert.ToBoolean(r["pagato"]);
                    a.Partecipato = Convert.ToBoolean(r["partecipato"]);
                    a.AttivitaID = Convert.ToInt32(r["attivitaID"]);
                    a.ClasseID = r["classeID"].ToString();
                    a.StudenteID = Convert.ToInt32(r["studenteID"]);
                    _aderires.Add(a);
                }
                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }
            return _aderires;
        }

        internal static List<Aderire> GetAllByAttivitaIDStudenti(ref MySqlConnection conn, int attivitaID, out string errore)
        {
            DataTable _dt = null;
            List<Aderire> _aderires = new List<Aderire>();
            errore = string.Empty;
            try
            {
                conn.Open();
                string _query = "SELECT * FROM aderire WHERE (studenteID IS NULL OR studenteID=-1) AND attivitaID=@attivitaID";
                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                _da.SelectCommand.Parameters.AddWithValue("@attivitaID", attivitaID);
                _dt = new DataTable();
                _da.Fill(_dt);
                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Aderire a = new Aderire();
                    a.IDAderire = Convert.ToInt32(r["IDaderire"]);
                    a.Iscritto = Convert.ToBoolean(r["iscritto"]);
                    a.Autorizzato = Convert.ToBoolean(r["autorizzato"]);
                    a.Pagato = Convert.ToBoolean(r["pagato"]);
                    a.Partecipato = Convert.ToBoolean(r["partecipato"]);
                    a.AttivitaID = Convert.ToInt32(r["attivitaID"]);
                    a.ClasseID = r["classeID"].ToString();
                    a.StudenteID = Convert.ToInt32(r["studenteID"]);
                    _aderires.Add(a);
                }
                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }
            return _aderires;
        }

        internal static List<Aderire> GetAllByAttivitaIDClasse(ref MySqlConnection conn, int attivitaID, out string errore)
        {
            DataTable _dt = null;
            List<Aderire> _aderires = new List<Aderire>();
            errore = string.Empty;
            try
            {
                conn.Open();
                string _query = "SELECT * FROM aderire WHERE classeID IS NULL AND attivitaID=@attivitaID";
                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                _da.SelectCommand.Parameters.AddWithValue("@attivitaID", attivitaID);
                _dt = new DataTable();
                _da.Fill(_dt);
                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Aderire a = new Aderire();
                    a.IDAderire = Convert.ToInt32(r["IDaderire"]);
                    a.Iscritto = Convert.ToBoolean(r["iscritto"]);
                    a.Autorizzato = Convert.ToBoolean(r["autorizzato"]);
                    a.Pagato = Convert.ToBoolean(r["pagato"]);
                    a.Partecipato = Convert.ToBoolean(r["partecipato"]);
                    a.AttivitaID = Convert.ToInt32(r["attivitaID"]);
                    a.ClasseID = r["classeID"].ToString();
                    a.StudenteID = Convert.ToInt32(r["studenteID"]);
                    _aderires.Add(a);
                }
                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }
            return _aderires;
        }
        internal static int CountAderire(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(IDaderire) FROM aderire;";

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
