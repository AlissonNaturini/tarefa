Console.Write("Digite a mensagem a ser enviada: ");
        string mensagem = Console.ReadLine();

        Console.WriteLine($"\nMensagem a ser enviada: \"{mensagem}\"\n");
Console.WriteLine("Por favor, escolha o canal de mensagem.");
Console.WriteLine("Digite 1 para enviar a mensagem como E-mail.");
Console.WriteLine("Digite 2 para enviar a mensagem como SMS.");
Console.WriteLine("Digite 3 para enviar a mensagem via Whatsapp.");
Console.WriteLine("Digite 0 para cancelar o envio.");
int canal = int.Parse(Console.ReadLine());
switch (canal)
{
        case 1:
                INotificador notificador = new EmailNotificador();


                var servico = new ServicoDeMensagem(notificador);

                servico.Processar();
                break;
        case 2:
                INotificador SMSnotificador = new SMSNotificador();


                var SMSservico = new ServicoDeMensagem(SMSnotificador);

                SMSservico.Processar();
                break;
         case 3:
                INotificador Whatsnotificador = new WhatsappNotificador();


                var Whatsservico = new ServicoDeMensagem(Whatsnotificador);
                Whatsservico.Processar();
                break;
        case 0:
                Console.WriteLine("Envio da mensagem cancelado.");
                break;
        default:
                Console.WriteLine("Por favor, digite um dos números dados.");
                break;
}

