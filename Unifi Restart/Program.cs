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
            string filePath = "path/to/file.txt";
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
                        string username = "sshusername";
                        string password = "sshpassword";
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
                        if (ipadres == "") ;
                            Environment.Exit(0);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}