using System;
using System.Data;
using System.Data.SqlClient;
using SistemaHotel.DAL;

namespace SistemaHotel1.DAL {
    class loginDaoComando {

        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();  //using System.Data;
        User dadosUsers = new User();
        Func dadosFunc = new Func();
        Hosp dadosGosp = new Hosp();

        public static string Nome = "";
        //Inserir e Atualizar -- USUARIOS --
        #region USER
        public bool InserirUser(User dados)
        {
            String query = "INSERT INTO usuarios (nome, usuario,senha,status) VALUES (@nome,@usuario,@senha,@status)";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", dados.Nomever);
            cmd.Parameters.AddWithValue("@usuario", dados.Nome);
            cmd.Parameters.AddWithValue("@senha", dados.Senha);
            cmd.Parameters.AddWithValue("@status", dados.Status);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery(); // executa ao cmd SQL
                con.desconectar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool AtualizarDadosUser(User dados)
        {
            //String query = "UPDATE users SET nome=@nomedAtualizar, senha=@senhadAtualizar, status=@status WHERE id=@idAtualizar";
            String query = "UPDATE usuarios SET nome=@nomeverAtualizar, usuario=@nomedAtualizar, status=@status WHERE id=@idAtualizar";
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nomedAtualizar", dados.Nome);
            cmd.Parameters.AddWithValue("@nomeverAtualizar", dados.Nomever);
            //cmd.Parameters.AddWithValue("@senhadAtualizar", dados.Senha);
            cmd.Parameters.AddWithValue("@idAtualizar", dados.Id);
            cmd.Parameters.AddWithValue("@status", dados.Status);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery(); // executa ao cmd SQL
                con.desconectar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
#endregion

        //Inserir e Atualizar -- HOSPEDES --
        #region HOSP
        public bool InserirHosp(Hosp dados)
        {
            String query = "INSERT INTO hospedes (nome,cpf,telefone,endereco) VALUES (@nome,@cpf,@telefone,@endereco)";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", dados.Nome);
            cmd.Parameters.AddWithValue("@cpf", dados.Cpf);
            cmd.Parameters.AddWithValue("@telefone", dados.Telefone);
            cmd.Parameters.AddWithValue("@endereco", dados.Endereco);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery(); // executa ao cmd SQL
                con.desconectar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool AtualizarDadosHosp(Hosp dados)
        {
            //String query = "UPDATE users SET nome=@nomedAtualizar, senha=@senhadAtualizar, status=@status WHERE id=@idAtualizar";
            String query = "UPDATE hospedes SET nome=@nomedAtualizar, cpf=@cpfAtualizar, telefone=@telefoneAtualizar, endereco=@enderecoAtualizar WHERE id=@idAtualizar";
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nomedAtualizar", dados.Nome);
            cmd.Parameters.AddWithValue("@cpfAtualizar", dados.Cpf);
            cmd.Parameters.AddWithValue("@telefoneAtualizar", dados.Telefone);
            cmd.Parameters.AddWithValue("@enderecoAtualizar", dados.Endereco);
            cmd.Parameters.AddWithValue("@idAtualizar", dados.Id);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery(); // executa ao cmd SQL
                con.desconectar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        //Inserir e Atualizar -- FUNCIONARIOS --
        #region FUNC
        public bool InserirFunc(Func dados)
        {
            String query = "INSERT INTO funcionarios (nome,cpf,endereco,telefone,cargo) VALUES (@nome,@cpf,@endereco,@telefone,@cargo)";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", dados.Nome);
            cmd.Parameters.AddWithValue("@cpf", dados.Cpf);
            cmd.Parameters.AddWithValue("@endereco", dados.Endereco);
            cmd.Parameters.AddWithValue("@telefone", dados.Telefone);
            cmd.Parameters.AddWithValue("@cargo", dados.Cargo);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery(); // executa ao cmd SQL
                con.desconectar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool AtualizarDadosFunc(Func dados)
        {
            //String query = "UPDATE users SET nome=@nomedAtualizar, senha=@senhadAtualizar, status=@status WHERE id=@idAtualizar";
            String query = "UPDATE funcionarios SET nome=@nomedAtualizar, cpf=@cpfAtualizar, endereco=@enderecoAtualizar, cargo=@cargoAtualizar, telefone=@telefoneAtualizar WHERE id=@idAtualizar";
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nomedAtualizar", dados.Nome);
            cmd.Parameters.AddWithValue("@cpfAtualizar", dados.Cpf);
            cmd.Parameters.AddWithValue("@idAtualizar", dados.Id);
            cmd.Parameters.AddWithValue("@enderecoAtualizar", dados.Endereco);
            cmd.Parameters.AddWithValue("@cargoAtualizar", dados.Cargo);
            cmd.Parameters.AddWithValue("@telefoneAtualizar", dados.Telefone);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery(); // executa ao cmd SQL
                con.desconectar();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        public User VerificarLogin(String login, String senha)
        {
            String query = "SELECT id,usuario,status FROM usuarios WHERE usuario=@login AND senha = @senha AND status=@status";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@status", "Ativo");

            

            try
            {

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)  // achou
                {
                    while (dr.Read())
                    {
                        dadosUsers.Id = dr.GetInt32(0);
                        dadosUsers.Nome = dr.GetString(1);
                        dadosUsers.Status = dr.GetString(2);
                        Nome = dadosUsers.Nome;
                    }
                    //Console.WriteLine("LoginDaoComandos: validarLogin: dr.HasRows = {0}", dr.HasRows);
                    return dadosUsers; //true
                }
                con.desconectar();
                dr.Close();
            }
            catch (Exception err)
            {
                //throw;
                Console.WriteLine("LoginDaoComandos: validarLogin: Erro =" + err.Message);
            }
            return dadosUsers; // false;
        }

        public System.Data.DataTable listarUsuarios()
        {
            //http://www.macoratti.net/18/09/c_crudcbo1.htm
            cmd.CommandText = "SELECT id, nome, usuario, status FROM usuarios";
            da.SelectCommand = cmd;
            try
            {
                cmd.Connection = con.conectar();
                dt.Clear();
                da.Fill(dt);

                con.desconectar();
            }
            catch (Exception err)
            {
                Console.WriteLine("LoginDaoComandos: listarUsuarios: Erro =" + err.Message);
            }
            return dt;
        }

        public System.Data.DataTable listarFuncionarios()
        {
            //http://www.macoratti.net/18/09/c_crudcbo1.htm
            cmd.CommandText = "SELECT id, nome, cpf, telefone, endereco, cargo FROM funcionarios";
            da.SelectCommand = cmd;
            try
            {
                cmd.Connection = con.conectar();
                dt.Clear();
                da.Fill(dt);

                con.desconectar();
            }
            catch (Exception err)
            {
                Console.WriteLine("LoginDaoComandos: listarFuncionarios: Erro =" + err.Message);
            }
            return dt;
        }

        public System.Data.DataTable listarHospede()
        {
            //http://www.macoratti.net/18/09/c_crudcbo1.htm
            cmd.CommandText = "SELECT id, nome, cpf, telefone, endereco FROM hospedes";
            da.SelectCommand = cmd;
            try
            {
                cmd.Connection = con.conectar();
                dt.Clear();
                da.Fill(dt);

                con.desconectar();
            }
            catch (Exception err)
            {
                Console.WriteLine("LoginDaoComandos: listarHospedes: Erro =" + err.Message);
            }
            return dt;
        }
    }
}
