using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Approach
{
    abstract class Vessels
    {
        protected int VesselID { set; get; }
        protected string VesselName { set; get; }
    }

    abstract class VesselImportDetails : Vessels, IImportType
    {
        string IImportType.ListOfImportType(string importList)
        {
            return importList;
        }
    }

    sealed class ImportDetails : VesselImportDetails
    {
        public ImportDetails(int id, string vesselName)
        {
            this.VesselID = id;
            this.VesselName = vesselName;
        }

        public string AgentsName { get; set; }
        public string FlagsName { get; set; }
        public string Port { get; set; }
        public string Dock { get; set; }
        public string VesselLeaveTime { get; set; }

        public override string ToString()
        {
            return $"Vessel ID: {this.VesselID}, \nVessel Name: {this.VesselName}, \nAgent Name: {this.AgentsName}, " +
                $"\nFlag Name: {this.FlagsName}, \nPort: {this.Port}, \nDock: {this.Dock}, \nVessel Leave Time: {this.VesselLeaveTime}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter Vessel ID Please(support only numeric value)...");
            int ID = Convert.ToInt32(Console.ReadLine().ToString());

            Console.WriteLine("\nAvaiable Vessel Name:");
            var VesselList = Enum.GetNames(typeof(VesselNames));
            foreach (var vl in VesselList) { Console.WriteLine(vl); }
            Console.WriteLine("\nEnter Vessel Name ...");
            string Name = Console.ReadLine();

            ImportDetails IPD = new ImportDetails(ID, Name);

            Console.WriteLine("\nAvaiable Agent Name:");
            var agentList = Enum.GetNames(typeof(AgentName));
            foreach(var Ag in agentList) { Console.WriteLine(Ag); }
            Console.WriteLine("\nEnter Vessel Agent Name...");
            IPD.AgentsName = Console.ReadLine();

            Console.WriteLine("\nAvaiable Flag Name:");
            var flagList = Enum.GetNames(typeof(FlagName));
            foreach (var fl in flagList) { Console.WriteLine(fl); }
            Console.WriteLine("\nEnter Flag Name...");
            IPD.FlagsName = Console.ReadLine();

            Console.WriteLine("\nAvaiable Ports list:");
            var PortsList = Enum.GetNames(typeof(Ports));
            foreach (var pl in PortsList) { Console.WriteLine(pl); }
            Console.WriteLine("\nEnter Vessel Ports Name...");
            IPD.Port = Console.ReadLine();

            Console.WriteLine("\nAvaiable Dock list:");
            var dockList = Enum.GetNames(typeof(Piers));
            foreach (var dl in dockList) { Console.WriteLine(dl); }
            Console.WriteLine("\nEnter Vessel Dock Name...");
            IPD.Dock = Console.ReadLine();

            Console.WriteLine("Enter Vessel Leave date and Time...");
            IPD.VesselLeaveTime = Console.ReadLine();
            

            Console.WriteLine("\nAvaiable Import product list:");
            var productList = Enum.GetNames(typeof(ImportType));
            foreach (var pl in productList) { Console.WriteLine(pl); }
            Console.WriteLine("\nEnter Import product Name...");
            string ProductName = Console.ReadLine();
            

            IImportType IIT = (IImportType)IPD;
            List<string> ImList = new List<string>();
            ImList.Add(IIT.ListOfImportType(ProductName));

            bool Yes = true;
            while(Yes)
            {
                Console.WriteLine("what have more import product? Yes or No");
                string yesNoInput = Console.ReadLine();
                if (yesNoInput.ToUpper() == "yes".ToUpper())
                {
                    Console.WriteLine("Enter product name...");
                    string productName = Console.ReadLine();
                    ImList.Add(IIT.ListOfImportType(productName));
                }
                else
                {
                    Yes = false;
                }
            }
            Console.WriteLine("\nYour inputble Vessel full information.");
            Console.WriteLine(IPD.ToString());
            Console.WriteLine("\nTotal Vessel import product.");
            foreach (var IL in ImList)
            {
                Console.WriteLine(IL);
            }
            Console.WriteLine("\nThank you.");

            Console.ReadKey();
        }
    }
}
