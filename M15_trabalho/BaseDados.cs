using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace M15_trabalho
{
    class BaseDados
    {
        private static BaseDados instance;
        public static BaseDados Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseDados();
                }
                return instance;
            }
        }
        public int id_logado;
        private string strLigacao;
        private SqlConnection ligacaoBD;
        public int vida;
        public int localizacao_x;
        public int localizacao_y;
        public int localizacao_z;
        public int nivel;
        public int arma;
        public int balas;
        public int recargas;
        public string username;
        public string password;
        public string email;

        public BaseDados()
        {
            strLigacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            ligacaoBD = new SqlConnection(strLigacao);
            ligacaoBD.Open();
        }

        ~BaseDados()
        {
            try
            {
                ligacaoBD.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void criarBD(string nome)
        {
            string nomeBD = System.IO.Path.GetFileNameWithoutExtension(nome);
            var ligacaoServidor = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30");
            ligacaoServidor.Open();
            string strSQL = $"CREATE DATABASE {nomeBD} ON PRIMARY (NAME={nomeBD}, FILENAME='{nome}')";
            var comando = new SqlCommand(strSQL, ligacaoServidor);
            comando.ExecuteNonQuery();
            ligacaoServidor = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={nome};Integrated Security=True;Connect Timeout=30");
            ligacaoServidor.Open();
            strSQL = @"Create table /*/*Utilizador*/*/es(
	                    id_utilzador int Identity primary key,
	                    username varchar(20),
	                    password varchar(100),
	                    email varchar(100) CHECK (email LIKE '%@%.%'),
	                    data_registo date default getdate()
                    )

                    Create table Saves(
	                    id_save int Identity primary key,
	                    vida tinyint CHECK(vida BETWEEN 0 AND 999),
	                    localizacao_x int,
	                    localizacao_y int,
	                    localizacao_z int,
	                    nivel tinyint CHECK(nivel BETWEEN 1 and 5),
	                    arma tinyint CHECK(arma BETWEEN 1 and 5),
	                    balas tinyint,
	                    recargas tinyint
                    )

                    Create table Utilizadores_Saves(
	                    id_utilisave int Identity primary key,
	                    id_save int references Saves(id_save),
	                    id_utilzador int references Utilizadores(id_utilzador)
                    )

                    Create table Leaderboard(
	                    id_leaderboard int Identity primary key,
	                    score int,
	                    nivel tinyint,
	                    id_utilzador int references Utilizadores(id_utilzador)
                    )";
            comando = new SqlCommand(strSQL, ligacaoServidor);
            comando.ExecuteNonQuery();
        }

        public void RegistarUtilizador(string username, string password, string email)
        {
            string sql = @"INSERT INTO Utilizadores(username,password,email)
                VALUES (@username,@password,@email);";
            SqlCommand comando = new SqlCommand(sql, ligacaoBD);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@email", email);
            comando.ExecuteNonQuery();
        }

        public void PreencherCBSaves(ComboBox cbSaves)
        {
            string sql = "SELECT id_save FROM Utilizadores_Saves WHERE id_utilzador = @userLogado";
            DataTable dados = BaseDados.Instance.DevolveConsulta(sql);
            cbSaves.Items.Clear();
            foreach (DataRow item in dados.Rows)
            {
                cbSaves.Text = item["id_save"].ToString();
                cbSaves.Items.Add(new Elementos() { id = int.Parse(item["id_save"].ToString()) });
            }
        }

        public bool VerificarExistenciaEmail(string email)
        {
            SqlCommand com = new SqlCommand(@"SELECT username FROM Utilizadores WHERE email = @email", ligacaoBD);
            com.Parameters.AddWithValue("@email", email);
            var res = com.ExecuteScalar();

            if (res != null)
            {
                return true;
            }
            return false;
        }

        public bool VerificarExistenciaNome(string username)
        {
            SqlCommand com = new SqlCommand(@"SELECT email FROM Utilizadores WHERE username = @username", ligacaoBD);
            com.Parameters.AddWithValue("@username", username);
            var res = com.ExecuteScalar();

            if (res != null)
            {
                return true;
            }
            return false;
        }

        public void LoginUtilizador(string username, string password)
        {
            string str = @"SELECT id_utilzador FROM Utilizadores WHERE username = @username and password = @password";
            SqlCommand com = new SqlCommand(str, ligacaoBD);
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@password", password);

            ligacaoBD.Close();
            ligacaoBD.Open();

            SqlDataReader resultado = com.ExecuteReader();
            if (resultado != null && resultado.HasRows)
            {
                while (resultado.Read())
                {
                    id_logado = resultado.GetInt32(resultado.GetOrdinal("id_utilzador"));
                }
                Form1.ActiveForm.Hide();
                fr_painel painelControlo = new fr_painel();
                painelControlo.Show();
            }
            else
            {
                MessageBox.Show("Username ou Password errados!");
            }
        }

        /* public int MostrarIdSaves(int userLogado)
         {
             string sql = "SELECT id_save AS 'SAVE Nº' FROM Utilizadores_Saves WHERE id_utilzador = @userLogado";
             ligacaoBD.Close();
             ligacaoBD.Open();
             SqlCommand com = new SqlCommand(sql, ligacaoBD);
             com.Parameters.AddWithValue("@userLogado", userLogado);
             var resultado = com.ExecuteReader();
             while(resultado.Read())
             {
                 return resultado.GetInt32(resultado.GetOrdinal("SAVE Nº"));
             }
             return 0;
         }*/

        public DataTable DevolveConsulta(string sql)
        {
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@userLogado", id_logado);
            DataTable registos = new DataTable();
            SqlDataReader table = com.ExecuteReader();
            registos.Load(table);
            return registos;

        }

        public void MostrarSaves(int id_save)
        {
            string sql = "SELECT vida,localizacao_x,localizacao_y,localizacao_z,nivel,arma,balas,recargas FROM Saves WHERE id_save = @id_save";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@id_save", id_save);
            SqlDataReader saveData = com.ExecuteReader();
            while (saveData.Read())
            {
                vida = saveData.GetByte(saveData.GetOrdinal("vida"));
                localizacao_x = saveData.GetInt32(saveData.GetOrdinal("localizacao_x"));
                localizacao_y = saveData.GetInt32(saveData.GetOrdinal("localizacao_y"));
                localizacao_z = saveData.GetInt32(saveData.GetOrdinal("localizacao_z"));
                nivel = saveData.GetByte(saveData.GetOrdinal("nivel"));
                arma = saveData.GetByte(saveData.GetOrdinal("arma"));
                balas = saveData.GetByte(saveData.GetOrdinal("balas"));
                recargas = saveData.GetByte(saveData.GetOrdinal("recargas"));
            }
        }

        public DataTable LeaderBoard()
        {
            string sql = "SELECT Utilizadores_Saves.id_save AS 'SAVE Nº',Utilizadores.username AS NOME, Saves.score AS SCORE FROM Utilizadores_Saves INNER JOIN Utilizadores ON (Utilizadores_Saves.id_utilzador = Utilizadores.id_utilzador) INNER JOIN Saves ON (Utilizadores_Saves.id_save = Saves.id_save) ORDER BY SCORE DESC";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            DataTable registos = new DataTable();
            SqlDataReader leaderboard = com.ExecuteReader();
            registos.Load(leaderboard);
            return registos;
        }

        public void MostrarDadosEditar(int userLogado)
        {
            string sql = "SELECT username,password,email FROM Utilizadores WHERE id_utilzador = @userLogado";
            ligacaoBD.Close();
            ligacaoBD.Open();

            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@userLogado", userLogado);
            SqlDataReader resultado = com.ExecuteReader();

            if (resultado != null && resultado.HasRows)
            {
                while (resultado.Read())
                {
                    username = resultado.GetString(resultado.GetOrdinal("username"));
                    password = resultado.GetString(resultado.GetOrdinal("password"));
                    email = resultado.GetString(resultado.GetOrdinal("email"));
                }
            }
        }

        public DataTable PesquisarRegistos(string username)
        {
            string sql = "SELECT Utilizadores_Saves.id_save AS 'SAVE Nº',Utilizadores.username AS NOME, Saves.score AS SCORE FROM Utilizadores_Saves INNER JOIN Utilizadores ON (Utilizadores_Saves.id_utilzador = Utilizadores.id_utilzador) INNER JOIN Saves ON (Utilizadores_Saves.id_save = Saves.id_save) WHERE Utilizadores.username LIKE @username ORDER BY SCORE DESC";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@username", '%'+username+'%');
            DataTable registos = new DataTable();
            SqlDataReader resultados = com.ExecuteReader();
            registos.Load(resultados);
            return registos;
        }

        public void EditarRegisto(int userLogado, string username, string password, string email)
        {
            string sql = "UPDATE Utilizadores SET username = @username, password = @password, email = @email WHERE id_utilzador = @userLogado";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@userLogado", userLogado);
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@password", password);
            com.Parameters.AddWithValue("@email", email);
            com.ExecuteNonQuery();
        }

        public DataTable SomarLeaderboard()
        {
            string sql = "SELECT Utilizadores.username AS NOME, SUM(score) AS 'SCORE TOTAL' FROM Utilizadores_Saves INNER JOIN Utilizadores ON (Utilizadores_Saves.id_utilzador = Utilizadores.id_utilzador) INNER JOIN Saves ON (Utilizadores_Saves.id_save = Saves.id_save) GROUP BY username ORDER BY 'SCORE TOTAL' DESC";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            DataTable registos = new DataTable();
            SqlDataReader resultados = com.ExecuteReader();
            registos.Load(resultados);
            return registos;
        }

        public void EliminarSave(int id_save)
        {
            string sql = "DELETE FROM Utilizadores_Saves WHERE id_save = @id_save; DELETE FROM Saves WHERE id_save = @id_save";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@id_save", id_save);
            SqlDataReader resultado = com.ExecuteReader();
        }

        public void AdicionarSave(string vida, string x, string y, string z, int nivel, int armas, string balas, string recargas, string score)
        {
            string sql = "INSERT INTO Saves(vida, localizacao_x,localizacao_y,localizacao_z,nivel, arma,balas, recargas, score) VALUES(@vida, @localizacao_x, @localizacao_y,@localizacao_z,@nivel, @armas, @balas, @recargas, @score)";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@vida", vida);
            com.Parameters.AddWithValue("@localizacao_x", x);
            com.Parameters.AddWithValue("@localizacao_y", y);
            com.Parameters.AddWithValue("@localizacao_z", z);
            com.Parameters.AddWithValue("@nivel",nivel);
            com.Parameters.AddWithValue("@armas",armas);
            com.Parameters.AddWithValue("@balas",balas);
            com.Parameters.AddWithValue("@recargas",recargas);
            com.Parameters.AddWithValue("@score",score);
            SqlDataReader resultado = com.ExecuteReader();
        }

        public void LinkUserSave(int userLogado)
        {
            string sql = "INSERT INTO Utilizadores_Saves(id_save,id_utilzador) VALUES(IDENT_CURRENT('Saves'), @userLogado)";
            ligacaoBD.Close();
            ligacaoBD.Open();
            SqlCommand com = new SqlCommand(sql, ligacaoBD);
            com.Parameters.AddWithValue("@userLogado", userLogado);
            SqlDataReader resultado = com.ExecuteReader();
        }
    }
}
