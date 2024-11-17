using oop_lab__project.Constructions;

namespace oop_lab__project.Program 
{
    class Program
    {
        static void Main(string[] args)
        {
            Construction myBuilding = new Construction(15.0f, 30.0f, 3, 200, "");
            
            Console.WriteLine($"Building Info:");
            Console.WriteLine($"Height: {myBuilding.Height}");
            Console.WriteLine($"Width: {myBuilding.Width}");
            Console.WriteLine($"Entrances: {myBuilding.Entrances}");
            Console.WriteLine($"Human Capacity: {myBuilding.HumanCapacity}");
            Console.WriteLine($"Material: {myBuilding.BuildMaterial}");
        }
    }
}