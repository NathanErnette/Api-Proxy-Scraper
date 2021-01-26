using System;
using System.Drawing;
using System.Threading;
using System.Net;
using System.IO;
using System.Linq;

namespace ProxyScrape
{
    class Program
    {
     
       

        static void Main(string[] args)
        {
            Console.Title = "qGj2eREtoN";
            Thread.Sleep(1000);
        restart:
            Colorful.Console.WriteLine(@"
$$$$$$$\                                                 $$$$$$\                                                   
$$  __$$\                                               $$  __$$\                                                  
$$ |  $$ | $$$$$$\   $$$$$$\  $$\   $$\ $$\   $$\       $$ /  \__| $$$$$$$\  $$$$$$\  $$$$$$\   $$$$$$\   $$$$$$\  
$$$$$$$  |$$  __$$\ $$  __$$\ \$$\ $$  |$$ |  $$ |      \$$$$$$\  $$  _____|$$  __$$\ \____$$\ $$  __$$\ $$  __$$\ 
$$  ____/ $$ |  \__|$$ /  $$ | \$$$$  / $$ |  $$ |       \____$$\ $$ /      $$ |  \__|$$$$$$$ |$$ /  $$ |$$$$$$$$ |
$$ |      $$ |      $$ |  $$ | $$  $$<  $$ |  $$ |      $$\   $$ |$$ |      $$ |     $$  __$$ |$$ |  $$ |$$   ____|
$$ |      $$ |      \$$$$$$  |$$  /\$$\ \$$$$$$$ |      \$$$$$$  |\$$$$$$$\ $$ |     \$$$$$$$ |$$$$$$$  |\$$$$$$$\ 
\__|      \__|       \______/ \__/  \__| \____$$ |       \______/  \_______|\__|      \_______|$$  ____/  \_______|
                                        $$\   $$ |                                             $$ |                
                                        \$$$$$$  |                                             $$ |                
                                         \______/                                              \__|                
                                                                                                                                                                    ", Color.DeepSkyBlue);
            Thread.Sleep(721);
            Colorful.Console.WriteLine();
            Colorful.Console.Write("[", Color.DarkRed);
            Colorful.Console.Write("HTTP/SOCKS4/SOCKS5", Color.OrangeRed);
            Colorful.Console.Write("]", Color.DarkRed);
            Colorful.Console.WriteLine();
            Colorful.Console.WriteLine();
            Colorful.Console.Write(">> ", Color.OrangeRed);
            string proxyOption = Colorful.Console.ReadLine();
            Colorful.Console.WriteLine();
            Colorful.Console.Write("");
         

            Colorful.Console.Write("| ", Color.OrangeRed);
            Colorful.Console.Write("Thread Timout [", Color.DarkRed);
            Colorful.Console.Write("Select A Number Between [Recomended 1000] 50 - 10000", Color.OrangeRed);
            Colorful.Console.Write("]", Color.DarkRed);
            Colorful.Console.Write(">> ", Color.OrangeRed);
            int TimeoutOption = Convert.ToInt32(Colorful.Console.ReadLine());
            Colorful.Console.Write("| ", Color.OrangeRed);
            Colorful.Console.Write("Scraping From The World Wide Web.. ", Color.PaleVioletRed);
            WebClient webClient = new WebClient();
            string currentTime = DateTime.Now.ToString();
            currentTime = currentTime.Replace(":", "-");
            string proxies = webClient.DownloadString(string.Format("https://api.proxyscrape.com/?request=displayproxies&proxytype={0}&timeout={1}", proxyOption, TimeoutOption));   // Can easily switch out the api for a better service
            Thread.Sleep(500);
            using (StreamWriter sw = File.AppendText(string.Format("Timeout - {0} Protocol - {1} .txt", TimeoutOption.ToString(), proxyOption)))
            {
                sw.WriteLine(proxies);
            }

            Colorful.Console.WriteLine();
            Colorful.Console.WriteLine();
            Colorful.Console.Write("| ", Color.OrangeRed);
            Colorful.Console.Write("Finished scraping", Color.DarkRed);
            Colorful.Console.WriteLine();
            Colorful.Console.Write("| ", Color.OrangeRed);
            Colorful.Console.Write("Press Enter to exit the program");
            Colorful.Console.WriteLine();
            Colorful.Console.Write(">> ", Color.OrangeRed);
            string options = Colorful.Console.ReadLine().ToUpper();
            if (options == "Enter")
            {
                Colorful.Console.WriteLine();
                Colorful.Console.WriteLine();
                Colorful.Console.Write("| ", Color.OrangeRed);
                Colorful.Console.Write("Disconnecting......");
                Colorful.Console.WriteLine();
                Thread.Sleep(500);
                Environment.Exit(0);
            }
           
           
            
        }
    }
}