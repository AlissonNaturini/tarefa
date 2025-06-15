public class SMSNotificador : INotificador
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}
