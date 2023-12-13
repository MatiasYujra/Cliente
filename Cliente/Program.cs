
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using PROE;

public class Program
{
    static void Main(string[] args)
    {

        Cliente cliente = new Cliente(4404);

        while (true)
        {
            Console.WriteLine("Inserte su mensaje");
            cliente.enviarTexto();
            cliente.recivirTexto();
            Console.WriteLine("Salir: Y/..");
            if (Console.ReadLine() == "Y") break;
        }

        Console.ReadLine();

















        //Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 31255);


        //listen.Connect(connect);

        //byte[] envianInfo = new byte[100];
        //string mensaje;

        //Console.WriteLine("Ingrese el mensaje a enviar: ");
        //mensaje = Console.ReadLine();

        //envianInfo = Encoding.Default.GetBytes(mensaje);
        //listen.Send(envianInfo);


        //Console.ReadKey();

    }
}