namespace LogicaDeProgramacao.Conteudos;

public class EstruturaCondicional
{
    public static void AulaEstruturaCondicional()
    {
        var horario = DateTime.Now.Hour;

        Console.WriteLine($"Hora atual: {DateTime.Now} (Hora extraída: {horario})");

        string mensagem;

        if (horario >= 6 && horario < 12)
        {
            mensagem = "Bom dia!";
        }
        else if (horario>= 12 && horario < 18) 
        {
            mensagem = "Boa tarde!";
        }
        else
        {
            mensagem = "Boa noite!";
        }

        Console.WriteLine(mensagem);
    }
}
