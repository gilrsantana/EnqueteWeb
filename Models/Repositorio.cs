namespace EnqueteWeb.Models;

public class Repositorio
{
    private static List<Resposta> respostas = new List<Resposta>();
    public static IEnumerable<Resposta> Respostas => respostas;

    public static void AdicionarResposta(Resposta resposta)
    {
        respostas.Add(resposta);
    }

    static Repositorio()
    {
        respostas.Add(new Resposta()
            {Nome = "João", Email = "joao@gmail.com", Sim=true});
        respostas.Add(new Resposta()
            {Nome = "Maria", Email = "maria@gmail.com", Sim=true});
        respostas.Add(new Resposta()
            {Nome = "Pedro", Email = "pedro@gmail.com", Sim=false});
        respostas.Add(new Resposta()
            {Nome = "Ricardo", Email = "ricardo@gmail.com", Sim=true});
        respostas.Add(new Resposta()
            {Nome = "Silvério", Email = "silverio@gmail.com", Sim=false});
        
    }
}