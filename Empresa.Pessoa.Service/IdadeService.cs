namespace Empresa.Pessoa.Service
{
    public class IdadeService
    {
        public int BuscarIdade(DateTime dataNAscimento)
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - dataNAscimento.Year;

            if(dataAtual.Month < dataNAscimento.Month)            
                idade--;            
            return idade;
        }    

    }
}
