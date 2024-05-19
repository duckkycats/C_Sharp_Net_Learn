/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace HelloWorld
{
    public class Program
    {
        static void Main(String[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            DataContextDapper dapper = new DataContextDapper(config);
            
            // string sql = @"INSERT INTO TutorialAppSchema.Computer (
            //     Motherboard,
            //     HasWifi,
            //     HasLTE,
            //     ReleaseDate,
            //     Price,
            //     VideoCard
            // ) VALUES ('" + myComputer.Motherboard
            //     + "','" + myComputer.HasWifi
            //     + "','" + myComputer.HasLTE
            //     + "','" + myComputer.ReleaseDate
            //     + "','" + myComputer.Price
            //     + "','" + myComputer.VideoCard
            // + "')";


            // _____ เขียนไฟล์ _____
            // ถ้า execute ทับไฟล์อีกที มันจะอัปเดตข้อมูลเป็นของใหม่
            // File.WriteAllText("log.txt","\n" + sql + "\n");
            // using StreamWriter openFile = new("log.txt", append: true);

            // _____ อ่านไฟล์ _____
            // openFile.WriteLine("\n" + sql + "\n");
            // openFile.Close();
            string computersJson = File.ReadAllText("Computers.json");

            // Console.WriteLine(computersJson);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }; 

            // // ใส่เครื่องหมาย ? เพราะไม่รู้จะ return ออกมาเป็นค่าอะไร
            IEnumerable<Computer>? computersNewtonSoft = JsonConvert.DeserializeObject<IEnumerable<Computer>>(computersJson);
            
            IEnumerable<Computer>? computersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Computer>>(computersJson, options);
            

            if (computersNewtonSoft != null)
            {
                foreach( Computer computer in computersNewtonSoft ) 
                {
                    // Console.WriteLine(computer.Motherboard);
                    string sql = @"INSERT INTO TutorialAppSchema.Computer (
                        Motherboard,
                        HasWifi,
                        HasLTE,
                        ReleaseDate,
                        Price,
                        VideoCard
                    ) VALUES ('" + EscapeSingleQuote(computer.Motherboard)
                        + "','" + computer.HasWifi
                        + "','" + computer.HasLTE
                        + "','" + computer.ReleaseDate
                        + "','" + computer.Price
                        + "','" + EscapeSingleQuote(computer.VideoCard)
                    + "')";

                    dapper.ExecuteSql(sql);
                }
            }

            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            string computersCopyNewtonsoft = JsonConvert.SerializeObject(computersNewtonSoft, settings);

            File.WriteAllText("computerCopyNewtonsoft.txt", computersCopyNewtonsoft);

             string computersCopy2 = System.Text.Json.JsonSerializer.Serialize(computersSystem, options);

            File.WriteAllText("computerCopySystem.txt", computersCopyNewtonsoft);

        }

        static string EscapeSingleQuote(string input)
        {
            string output = input.Replace("'", "''");
            // จะได้ 'Rabel-O''Hara'

            return output;
        }

    }
}

*/