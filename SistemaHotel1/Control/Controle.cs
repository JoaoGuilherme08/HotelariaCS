
using SistemaHotel.DAL;
using SistemaHotel1.DAL;
using System;
using System.Data;

namespace SistemaHotel.Control {
    public class Controle {

        public bool tem;
        public string mensagem = "";
        loginDaoComando loginDao = new loginDaoComando();

        public User validarUsuario(String usuario, String senha)
        {
            User dadosUsers = new User();
            dadosUsers = loginDao.VerificarLogin(usuario, senha);
            return dadosUsers;
        }

        //USER
        #region USER
        public bool SalvarEdicaoUser(User dados)
        {
            return loginDao.AtualizarDadosUser(dados);
        }

        public bool SalvarNovoUser(User dados)
        {
            return loginDao.InserirUser(dados);
        }
        #endregion

        // HOSPEDES
        #region HOSP
        public bool SalvarEdicaoHosp(Hosp dados)
        {
            return loginDao.AtualizarDadosHosp(dados);
        }

        public bool SalvarNovoHosp(Hosp dados)
        {
            return loginDao.InserirHosp(dados);
        }
        #endregion

        //FUNCIONARIOS
        #region FUNC
        public bool SalvarEdicaoFunc(Func dados)
        {
            return loginDao.AtualizarDadosFunc(dados);
        }

        public bool SalvarNovoFunc(Func dados)
        {
            return loginDao.InserirFunc(dados);
        }
        #endregion

        public DataTable listarUsuarios()
        {
            //LoginDaoComandos loginDao = new LoginDaoComandos();

            DataTable dt = new DataTable();
            dt = loginDao.listarUsuarios();
            return dt;
        }

        public DataTable listarFuncionarios()
        {
            //LoginDaoComandos loginDao = new LoginDaoComandos();

            DataTable dt = new DataTable();
            dt = loginDao.listarFuncionarios();
            return dt;
        }

        public DataTable listarHospede()
        {
            //LoginDaoComandos loginDao = new LoginDaoComandos();

            DataTable dt = new DataTable();
            dt = loginDao.listarHospede();
            return dt;
        }

    }
}