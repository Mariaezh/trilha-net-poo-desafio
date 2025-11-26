using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// "Implementado"
class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456", 16);
        nokia.Ligar();  
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nSmartphone iPhone:");
        Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI654321", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("Telegram");  
    }
}   

