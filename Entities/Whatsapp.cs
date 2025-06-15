public class   WhatsappNotificador : INotificador
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem via Whatsapp: {mensagem}");
    }
}
