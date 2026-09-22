using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class AdminBL
    {
        // Andrea Giorgini - AdminBL

        #region DML
        internal static long Create(ref MySqlConnection conn, Admin clsAdmin, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO utenti (nome, cognome, username, password, ruolo, classeID) VALUES (@nome, @cognome, @username, @password, @ruolo, @classeID)";

                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", clsAdmin.Nome);
                _cmd.Parameters.AddWithValue("@cognome", clsAdmin.Cognome);
                _cmd.Parameters.AddWithValue("@username", clsAdmin.Username);
                _cmd.Parameters.AddWithValue("@password", clsAdmin.Password);
                _cmd.Parameters.AddWithValue("@ruolo", "A");
                _cmd.Parameters.AddWithValue("@classeID", string.Empty);

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

        internal static void Edit(ref MySqlConnection conn, Admin adminNuovo, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE utenti SET nome=@nome, cognome=@cognome, username=@username, password=@password, classeID=@classeID WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", adminNuovo.Nome);
                _cmd.Parameters.AddWithValue("@cognome", adminNuovo.Cognome);
                _cmd.Parameters.AddWithValue("@username", adminNuovo.Username);
                _cmd.Parameters.AddWithValue("@password", adminNuovo.Password);
                _cmd.Parameters.AddWithValue("@classeID", string.Empty);
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
                string _sql = "DELETE FROM utenti WHERE ID=@ID";
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

        internal static Admin GetOne(ref MySqlConnection conn, long ID, out string errore)
        {
            DataTable _dt = null;
            Admin _admin = null;
            errore = string.Empty;

            if (ID <= 0)
                errore = "ID non valido";
            else
            {
                try
                {
                    string _query = "SELECT * FROM utenti WHERE ID=@ID AND ruolo='A'";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _admin = new Admin();
                        var r = _dt.Rows[0];
                        _admin.ID = Convert.ToInt32(r["ID"]);
                        _admin.Nome = r["nome"].ToString();
                        _admin.Cognome = r["cognome"].ToString();
                        _admin.Username = r["username"].ToString();
                        _admin.Password = r["password"].ToString();
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _admin;
        }

        internal static Admin GetOneByEmail(ref MySqlConnection conn, string email, out string errore)
        {
            DataTable _dt = null;
            Admin _admin = null;
            errore = string.Empty;
            if (string.IsNullOrEmpty(email))
                errore = "Email non valida";
            else
            {
                try
                {
                    string _query = "SELECT * FROM utenti WHERE username=@username AND ruolo='A'";
                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@username", email);
                    _dt = new DataTable();
                    _da.Fill(_dt);
                    if (_dt.Rows.Count == 1)
                    {
                        _admin = new Admin();
                        var r = _dt.Rows[0];
                        _admin.ID = Convert.ToInt32(r["ID"]);
                        _admin.Nome = r["nome"].ToString();
                        _admin.Cognome = r["cognome"].ToString();
                        _admin.Username = r["username"].ToString();
                        _admin.Password = r["password"].ToString();
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }
            return _admin;
        }

        internal static List<Admin> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Admin> _admins = new List<Admin>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM utenti WHERE ruolo='A'";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Admin a = new Admin();
                    a.ID = Convert.ToInt32(r["ID"]);
                    a.Nome = r["nome"].ToString();
                    a.Cognome = r["cognome"].ToString();
                    a.Username = r["username"].ToString();
                    a.Password = r["password"].ToString();

                    _admins.Add(a);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _admins;
        }

        internal static int CountAdmini(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(ID) FROM utenti WHERE ruolo='A';";

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

        internal static bool Accedi(ref MySqlConnection conn, string email, string password)
        {
            Admin admin = GetOneByEmail(ref conn, email, out string errore);
            if(admin.Password== password)
            {
                Program._admin = admin;
                Program._studente = null;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

