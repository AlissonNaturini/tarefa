public class ServicoDeMensagem
{
    private readonly INotificador _notificador;

    
    public ServicoDeMensagem(INotificador notificador)
    {
        _notificador = notificador;
    }

    public void Processar()
    {
        
        _notificador.Enviar("Processamento concluído com sucesso!");
    }
}