/*
using System;
using System.Data;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


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
            DataContextEF entityFramework = new DataContextEF(config);

            // return 
            DateTime rightNow = dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");

            // Console.WriteLine(rightNow.ToString());
            // ___ End Connected Database ___
            
            // Mock ข้อมูล = จำลองข้อมูล = ข้อมูลต้นแบบ
            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 973.87m,
                VideoCard = "RTX 2060"
            };

            
            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                HasWifi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            ) VALUES ('" + myComputer.Motherboard
                + "','" + myComputer.HasWifi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate
                + "','" + myComputer.Price
                + "','" + myComputer.VideoCard
            + "')";


            // _____ เขียนไฟล์ _____
            // ถ้า execute ทับไฟล์อีกที มันจะอัปเดตข้อมูลเป็นของใหม่
            File.WriteAllText("log.txt","\n" + sql + "\n");
            using StreamWriter openFile = new("log.txt", append: true);

            // _____ อ่านไฟล์ _____
            openFile.WriteLine("\n" + sql + "\n");
            openFile.Close();
            string fileText = File.ReadAllText("log.txt");
            Console.WriteLine(fileText);
        }

    }
}

*/
