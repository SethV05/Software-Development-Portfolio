using System;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Threading;

class Program
{
    static void Main()
    {
        string[] websites = new string[]
        {
            "google.com",
            "youtube.com",
            "amazon.com",
            "netflix.com",
            "reddit.com",
            "runescape.com",
            "apple.com",
            "twitch.com",
            "chess.com",
            "chatgpt.com"
        };

        string filePath = "PingResults.txt";

        Console.WriteLine("Starting ping test...\n");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string site in websites)
            {
                Console.Write($"Processing: {site}... ");

                writer.WriteLine($"===== {site} =====");

                try
                {
                    // Get IP info
                    IPHostEntry entry = Dns.GetHostEntry(site);
                    writer.WriteLine($"Host Name: {entry.HostName}");

                    foreach (IPAddress address in entry.AddressList)
                    {
                        writer.WriteLine($"IP Address: {address}");
                    }

                    // Ping the site
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(site);

                    writer.WriteLine($"Status: {reply.Status}");

                    if (reply.Status == IPStatus.Success)
                    {
                        writer.WriteLine($"Reply from {reply.Address}");
                        writer.WriteLine($"Time: {reply.RoundtripTime} ms");
                    }

                    Console.WriteLine("Done");
                }
                catch (Exception ex)
                {
                    writer.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Error");
                }

                writer.WriteLine();

                // Delay to read where data is being written
                Thread.Sleep(300);
            }
        }

        Console.WriteLine("\nAll websites processed!");
        Console.WriteLine("Results saved to PingResults.txt");
    }
}