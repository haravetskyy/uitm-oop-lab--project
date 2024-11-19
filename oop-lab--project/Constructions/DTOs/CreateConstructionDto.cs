using oop_lab__project.Constructions.models;

namespace oop_lab__project.Constructions.DTOs;

public class CreateConstructionDto
{
    public float Height { get; set; } 
    public float Width { get; set; } 
    public int Entrances { get; set; }
    public int HumanCapacity { get; set; }
    public BuildMaterialEnum BuildMaterial { get; set; }
}