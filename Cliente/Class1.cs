using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;



namespace PROE
{
    internal class Cliente
    {
        private IPHostEntry? clienteHost;
        private IPAddress? clienteIP;
        private IPEndPoint? endCliente;
        private Socket? Scliente;
        public Cliente (int puerto)
        {
            this.clienteHost = Dns.GetHostEntry("localHost");
            this.clienteIP = this.clienteHost.AddressList[0];
            this.endCliente = new IPEndPoint(this.clienteIP, puerto);
            this.Scliente = new Socket(this.clienteIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Scliente.Connect(this.endCliente);//eqwerdf
        }

        public void enviarTexto()
        {
            string msgEnviado = clienteIP + " " + Console.ReadLine() + " <%n%>";
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(msgEnviado);
            Scliente.Send(buffer);

        }
        public void recivirTexto()
        {
            byte[] buffer = new byte[1024];
            Scliente.Receive(buffer);
            string msgRecivido = ASCIIEncoding.ASCII.GetString(buffer);
            Console.WriteLine(msgRecivido);
        }








    }
}
