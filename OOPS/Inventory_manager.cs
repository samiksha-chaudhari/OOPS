using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace OOPS
{
    class Inventory_Manager
    {
        public Inventory_Manager()
        {

            List<Inventory> inventoryList = new List<Inventory>(); //create list 

            Inventory rice = new Inventory("Rice", 658, 110); //creating object for rice
            Inventory pulses = new Inventory("Pulses", 565, 80);//creating object for pulses
            Inventory wheats = new Inventory("Wheats", 933, 210);//creating object for wheats
                                                             //adding grains to inventoryList
            inventoryList.Add(rice);
            inventoryList.Add(pulses);
            inventoryList.Add(wheats);

            //perfroming serialization on inventoryList
            string json = JsonConvert.SerializeObject(inventoryList);
            //json string save to print.json
            File.WriteAllText(@"D:\new1\bridgelabz_fellowship\OOPS\OOPS\print.json", json);

            Console.WriteLine("Data Stored to print.json");
            Console.WriteLine("\n");
            Console.WriteLine("Dispaly Inventory Data");

            //perfroming deserialization on print.json
            string datafile = File.ReadAllText(@"D:\new1\bridgelabz_fellowship\OOPS\OOPS\print.json");
            //to print string datafile
            List<Inventory> returnDataObj = JsonConvert.DeserializeObject<List<Inventory>>(datafile);

            foreach (var form in returnDataObj)
            {

                Console.WriteLine("Name : " + form.Name);
                Console.WriteLine("Weight : " + form.Weight);
                Console.WriteLine("Price : " + form.Price);
                Console.WriteLine("Total Value of {0} =  {1}: ", form.Name, (form.Weight * form.Price));
                Console.WriteLine("\n");
            }

        }
    }
}