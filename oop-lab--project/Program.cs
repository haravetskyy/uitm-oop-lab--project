using oop_lab__project.Constructions.models;
using oop_lab__project.Constructions.DTOs;

namespace oop_lab__project.Program 
{
    class Program
    {
        static void Main(string[] args)
        {
            Construction myBuilding = new Construction(15.0f, 30.0f, 3, 200, BuildMaterialEnum.Concrete);
            Console.WriteLine($"Building Info:");
            Console.WriteLine($"Height: {myBuilding.Height}");
            Console.WriteLine($"Width: {myBuilding.Width}");
            Console.WriteLine($"Entrances: {myBuilding.Entrances}");
            Console.WriteLine($"Human Capacity: {myBuilding.HumanCapacity}");
            Console.WriteLine($"Material: {myBuilding.BuildMaterial}");
            Console.WriteLine($"Square cost: {myBuilding.GetSquareCost()}");

            Construction defaultBuilding = new Construction();
            Console.WriteLine($"Building Info:");
            Console.WriteLine($"Height: {defaultBuilding.Width}");
            Console.WriteLine($"Entrances: {defaultBuilding.Entrances}");
            Console.WriteLine($"Human Capacity: {defaultBuilding.HumanCapacity}");
            Console.WriteLine($"Material: {defaultBuilding.BuildMaterial}");
            Console.WriteLine($"Square cost: {defaultBuilding.GetSquareCost()}");

            Construction buildingCreatedViaDto = new Construction(new CreateConstructionDto
            {
                Height = 16.0f,
                Width = 16.0f,
                Entrances = 2,
                HumanCapacity = 100,
                BuildMaterial = BuildMaterialEnum.Brick,
            });
            Console.WriteLine($"Building Info:");
            Console.WriteLine($"Height: {buildingCreatedViaDto.Height}");
            Console.WriteLine($"Width: {buildingCreatedViaDto.Width}");
            Console.WriteLine($"Entrances: {buildingCreatedViaDto.Entrances}");
            Console.WriteLine($"Human Capacity: {buildingCreatedViaDto.HumanCapacity}");
            Console.WriteLine($"Material: {buildingCreatedViaDto.BuildMaterial}");
            Console.WriteLine($"Square cost: {buildingCreatedViaDto.GetSquareCost()}");
        }
    }
}