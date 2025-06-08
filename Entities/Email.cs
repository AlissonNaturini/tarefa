public class EmailNotificador : INotificador
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}