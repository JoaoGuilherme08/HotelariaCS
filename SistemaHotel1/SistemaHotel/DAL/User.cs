namespace SistemaHotel.DAL
{
    public class User
    {
        int id;
        string nome;
        string nomever;
        string senha;
        string status;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Nomever { get => nomever; set => nomever = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Status { get => status; set => status = value; }
    }
}