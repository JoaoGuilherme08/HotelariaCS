namespace SistemaHotel.DAL
{
    public class Hosp
    {
        int id;
        string nome;
        string cpf;
        string endereco;
        string telefone;
        string funcionario;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Funcionario { get => funcionario; set => funcionario = value; }
    }
}
