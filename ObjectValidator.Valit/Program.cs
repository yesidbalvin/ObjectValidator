using ObjectValidator.Domain.ConfirmedViolationCreated;
using System;
using System.IO;
using System.Text.Json;

namespace ObjectValidator.Valit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }

        public static ConfirmedViolationCreated GetConfirmedViolationCreated(string cvPath)
        {
            var cvFile = File.ReadAllText(cvPath);
            return JsonSerializer.Deserialize<ConfirmedViolationCreated>(cvFile);
        }
    }
}
