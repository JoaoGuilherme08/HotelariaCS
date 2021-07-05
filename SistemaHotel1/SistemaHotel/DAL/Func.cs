namespace SistemaHotel.DAL
{
    public class Func
    {
        int id;
        string nome;
        string cpf;
        string endereco;
        string telefone;
        string cargo;
        string data;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Data { get => data; set => data = value; }
    }
}
