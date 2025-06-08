        
        INotificador notificador = new EmailNotificador();

        
        var servico = new ServicoDeMensagem(notificador);

        servico.Processar();
