using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EsLab4_4_Eventi_Giorgini
{
    internal static class StudenteBL
    {
        // Andrea Giorgini - StudenteBL

        #region DML
        internal static long Create(ref MySqlConnection conn, Studente clsStudente, out string errore)
        {
            long _ID = 0;
            errore = string.Empty;

            try
            {
                conn.Open();

                string _sql = "INSERT INTO utenti (nome, cognome, username, password, matricola, rappresentanteClasse, rappresentanteIstituto, ruolo, classeID) VALUES (@nome, @cognome, @username, @password, @matricola, @rappresentanteClasse, @rappresentanteIstituto, @ruolo, @classeID)";

                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", clsStudente.Nome);
                _cmd.Parameters.AddWithValue("@cognome", clsStudente.Cognome);
                _cmd.Parameters.AddWithValue("@username", clsStudente.Username);
                _cmd.Parameters.AddWithValue("@password", clsStudente.Password);
                _cmd.Parameters.AddWithValue("@matricola", string.IsNullOrEmpty(clsStudente.Matricola) ? (object)DBNull.Value : clsStudente.Matricola);
                _cmd.Parameters.AddWithValue("@rappresentanteClasse", clsStudente.RappresentanteClasse);
                _cmd.Parameters.AddWithValue("@rappresentanteIstituto", clsStudente.RappresentanteIstituto);
                _cmd.Parameters.AddWithValue("@ruolo", "S");
                _cmd.Parameters.AddWithValue("@classeID", clsStudente.ClasseID ?? string.Empty);

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

        internal static void Edit(ref MySqlConnection conn, Studente studenteNuovo, long ID, out string errore)
        {
            errore = string.Empty;
            try
            {
                conn.Open();
                string _sql = "UPDATE utenti SET nome=@nome, cognome=@cognome, username=@username, password=@password, matricola=@matricola, rappresentanteClasse=@rappresentanteClasse, rappresentanteIstituto=@rappresentanteIstituto, classeID=@classeID WHERE ID=@ID";
                MySqlCommand _cmd = new MySqlCommand(_sql, conn);

                _cmd.Parameters.AddWithValue("@nome", studenteNuovo.Nome);
                _cmd.Parameters.AddWithValue("@cognome", studenteNuovo.Cognome);
                _cmd.Parameters.AddWithValue("@username", studenteNuovo.Username);
                _cmd.Parameters.AddWithValue("@password", studenteNuovo.Password);
                _cmd.Parameters.AddWithValue("@matricola", string.IsNullOrEmpty(studenteNuovo.Matricola) ? (object)DBNull.Value : studenteNuovo.Matricola);
                _cmd.Parameters.AddWithValue("@rappresentanteClasse", studenteNuovo.RappresentanteClasse);
                _cmd.Parameters.AddWithValue("@rappresentanteIstituto", studenteNuovo.RappresentanteIstituto);
                _cmd.Parameters.AddWithValue("@classeID", studenteNuovo.ClasseID ?? string.Empty);
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

        internal static Studente GetOne(ref MySqlConnection conn, long ID, out string errore)
        {
            DataTable _dt = null;
            Studente _studente = null;
            errore = string.Empty;

            if (ID <= 0)
                errore = "ID non valido";
            else
            {
                try
                {
                    string _query = "SELECT * FROM utenti WHERE ID=@ID AND ruolo='S'";

                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@ID", ID);

                    _dt = new DataTable();
                    _da.Fill(_dt);

                    if (_dt.Rows.Count == 1)
                    {
                        _studente = new Studente();
                        var r = _dt.Rows[0];
                        _studente.ID = Convert.ToInt32(r["ID"]);
                        _studente.Nome = r["nome"].ToString();
                        _studente.Cognome = r["cognome"].ToString();
                        _studente.Username = r["username"].ToString();
                        _studente.Password = r["password"].ToString();
                        _studente.Matricola = r["matricola"] == DBNull.Value ? null : r["matricola"].ToString();
                        _studente.RappresentanteClasse = Convert.ToBoolean(r["rappresentanteClasse"]);
                        _studente.RappresentanteIstituto = Convert.ToBoolean(r["rappresentanteIstituto"]);
                        _studente.ClasseID = r["classeID"].ToString();
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }

            return _studente;
        }

        internal static Studente GetOneByEmail(ref MySqlConnection conn, string email, out string errore)
        {
            DataTable _dt = null;
            Studente _studente = null;
            errore = string.Empty;
            if (string.IsNullOrEmpty(email))
                errore = "Email non valida";
            else
            {
                try
                {
                    string _query = "SELECT * FROM utenti WHERE username=@email AND ruolo='S'";
                    MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);
                    _da.SelectCommand.Parameters.AddWithValue("@email", email);
                    _dt = new DataTable();
                    _da.Fill(_dt);
                    if (_dt.Rows.Count == 1)
                    {
                        _studente = new Studente();
                        var r = _dt.Rows[0];
                        _studente.ID = Convert.ToInt32(r["ID"]);
                        _studente.Nome = r["nome"].ToString();
                        _studente.Cognome = r["cognome"].ToString();
                        _studente.Username = r["username"].ToString();
                        _studente.Password = r["password"].ToString();
                        _studente.Matricola = r["matricola"] == DBNull.Value ? null : r["matricola"].ToString();
                        _studente.RappresentanteClasse = Convert.ToBoolean(r["rappresentanteClasse"]);
                        _studente.RappresentanteIstituto = Convert.ToBoolean(r["rappresentanteIstituto"]);
                        _studente.ClasseID = r["classeID"].ToString();
                    }
                }
                catch (Exception _ex)
                {
                    errore = _ex.Message;
                }
            }
            return _studente;
        }

        internal static List<Studente> GetAll(ref MySqlConnection conn, out string errore)
        {
            DataTable _dt = null;
            List<Studente> _studenti = new List<Studente>();
            errore = string.Empty;

            try
            {
                conn.Open();

                string _query = "SELECT * FROM utenti WHERE ruolo='S'";

                MySqlDataAdapter _da = new MySqlDataAdapter(_query, conn);

                _dt = new DataTable();
                _da.Fill(_dt);

                for (int _i = 0; _i < _dt.Rows.Count; _i++)
                {
                    var r = _dt.Rows[_i];
                    Studente s = new Studente();
                    s.ID = Convert.ToInt32(r["ID"]);
                    s.Nome = r["nome"].ToString();
                    s.Cognome = r["cognome"].ToString();
                    s.Username = r["username"].ToString();
                    s.Password = r["password"].ToString();
                    s.Matricola = r["matricola"] == DBNull.Value ? null : r["matricola"].ToString();
                    s.RappresentanteClasse = Convert.ToBoolean(r["rappresentanteClasse"]);
                    s.RappresentanteIstituto = Convert.ToBoolean(r["rappresentanteIstituto"]);
                    s.ClasseID = r["classeID"].ToString();

                    _studenti.Add(s);
                }

                conn.Close();
            }
            catch (Exception _ex)
            {
                errore = _ex.Message;
            }

            return _studenti;
        }

        internal static int CountStudenti(ref MySqlConnection conn, out string errore)
        {
            int _count = 0;
            errore = string.Empty;

            try
            {
                string _query = "SELECT COUNT(ID) FROM utenti WHERE ruolo='S';";

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
            Studente studente = GetOneByEmail(ref conn, email, out string errore);
            if (studente.Password == password)
            {
                Program._studente = studente;
                Program._admin = null;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
