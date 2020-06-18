namespace Aula20Exercício3
{
    public class Restaurante
    {
        public string Nome { get; set; }

        public string  Endereco { get; set; }

        public Restaurante(string _nome, string _endereco){
                this.Nome = _nome;
                this.Endereco = _endereco;   
        }
        public string MostrarDados(){
            return $"Restaurante: {Nome}, Endereço: {Endereco} ";
        }
    }
}