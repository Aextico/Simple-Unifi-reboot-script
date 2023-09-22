using Renci.SshNet;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unifi_Restart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "sciezka/do/pliku.txt";
            string ipadres = "";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ipadres = line;
                        string host = ipadres;
                        string username = "użytkownikssh";
                        string password = "HasloSSH";
                        try
                        {
                            using (var client = new SshClient(host, username, password))
                            {
                                client.Connect();
                                using (var command = client.CreateCommand("reboot"))
                                {
                                    Console.Write(command.Execute());
                                }
                                client.Disconnect();
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}