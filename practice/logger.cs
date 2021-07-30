
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using YamlDotNet.RepresentationModel;
using Newtonsoft.Json;

namespace practice

{
    class test
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
            //This is the setup for the logger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .CreateLogger();
            Log.Logger.Information("Starting...");
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ITest2, Test2>();
                })
                .UseSerilog()
                .Build();
            var svc = ActivatorUtilities.CreateInstance<Test2>(host.Services);
            List<Employee> list = new List<Employee>();
            Employee pe1 = new PermanentEmployee("Annie", 35, 2000);
            Employee ce1 = new ContractEmployee("Jose", 35, 1500);
            list.Add(pe1);
            list.Add(ce1);
            
            for (int i = 0; i < list.Count; i++)
            {

                Log.Logger.Information(list[i].EmployeeDetails() + " " + list[i].displaySalary());
            }

            //JSON AND YAML PARSING HAPPENS HERE
            StreamReader reader = new StreamReader("C:\\Users\\178788\\Desktop\\practice\\practice\\json1.json");
            string jsonString = reader.ReadToEnd();

            var people = JsonConvert.DeserializeObject<Wrapper>(jsonString).Person;
            foreach (var person in people.People)
            {
                Console.WriteLine("Name: {0} Age: {1} ", person.Value.name, person.Value.age);
            }

            var reader2 = new StreamReader("C:\\Users\\178788\\Desktop\\practice\\practice\\YamlPractice.yml");
            var yaml = new YamlStream();
            yaml.Load(reader2);
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;


            foreach (var entry in mapping.Children)
            {
                var myKey = ((YamlScalarNode)entry.Key).Value;

                Console.WriteLine("Key: {0} Value: {1}", myKey, entry.Value);
                if (myKey != "turtle-doves")
                {
                    continue;
                }
            }



                svc.Run();
        }

       
        static void BuildConfig(IConfigurationBuilder builder)
        {
            //This tells our builder the ability to talk to appsettings.json in the current directory
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                //This obtains the whatever enviroment it is running and override it, if it doesnt find any enviroment, run production.json
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIROMENT") ?? "Prodution"}.json", optional: true)
                .AddEnvironmentVariables();
            //write it t a text file instead of console.
        }

    }


    
}

