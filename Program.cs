﻿using System;
using System.Data;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(String[] args)
        {

            DataContextDapper dapper = new DataContextDapper();
            DataContextEF entityFramework = new DataContextEF();

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

            entityFramework.Add(myComputer);
            entityFramework.SaveChanges();

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

            // Console.WriteLine(sql);

            // int result = dapper.ExecuteSqlWithRowCount(sql);
            bool result = dapper.ExecuteSql(sql);

            // Console.WriteLine(result);

            string sqlSelect = @"
            SELECT
                Computer.ComputerId,
                Computer.Motherboard,
                Computer.HasWifi,
                Computer.HasLTE,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.VideoCard
             FROM TutorialAppSchema.Computer";
            
            // _____ Dapper of IEnumberable _____
            IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);

            Console.WriteLine("'ComputerId','Motherboard','HasWifi','HasLTE','ReleaseDate','Price','VideoCard'");

            foreach(Computer singleComputer in computers)
            {
                Console.WriteLine(
                "'" + singleComputer.ComputerId
                + "','" + singleComputer.Motherboard
                + "','" + singleComputer.HasWifi
                + "','" + singleComputer.HasLTE
                + "','" + singleComputer.ReleaseDate
                + "','" + singleComputer.Price
                + "','" + singleComputer.VideoCard
                + "'");
            }


            // _____ Entity Framwork of IEnumberable _____
            IEnumerable<Computer>? computersEf = entityFramework.Computer?.ToList<Computer>();

            if (computersEf != null)
            {
                Console.WriteLine("'ComputerId','Motherboard','HasWifi','HasLTE','ReleaseDate','Price','VideoCard'");

                foreach(Computer singleComputer in computersEf)
                {
                    Console.WriteLine(
                "'" + singleComputer.ComputerId
                + "','" + singleComputer.Motherboard
                + "','" + singleComputer.HasWifi
                + "','" + singleComputer.HasLTE
                + "','" + singleComputer.ReleaseDate
                + "','" + singleComputer.Price
                + "','" + singleComputer.VideoCard
                + "'");
                }
            }


            // myComputer.HasWifi = false;
            // Console.WriteLine(myComputer.Motherboard);
            // Console.WriteLine(myComputer.HasWifi);
            // Console.WriteLine(myComputer.ReleaseDate);
            // Console.WriteLine(myComputer.VideoCard);
        }

    }
}
