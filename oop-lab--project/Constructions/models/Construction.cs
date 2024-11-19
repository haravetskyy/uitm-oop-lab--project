using oop_lab__project.Constructions.DTOs;

namespace oop_lab__project.Constructions.models;

public class Construction
{
    public Construction(float height, float width, int entrances, int humanCapacity, BuildMaterialEnum buildMaterial)
    {
        Height = height;
        Width = width;
        Entrances = entrances;
        HumanCapacity = humanCapacity;
        _buildMaterial = buildMaterial;
    }

	public Construction()
    {
        Height = 0.0f;
        Width = 0.0f;
        Entrances = 0;
        HumanCapacity = 0;
        _buildMaterial = models.BuildMaterialEnum.Concrete;
    }

    public Construction(CreateConstructionDto data)
    {
        Height = data.Height;
        Width = data.Width; 
        Entrances = data.Entrances;
        HumanCapacity = data.HumanCapacity;
        BuildMaterial = data.BuildMaterial;
    }
    
    public BuildMaterialEnum BuildMaterial { get => _buildMaterial;
        set { _buildMaterial = value; }
    }

    private BuildMaterialEnum _buildMaterial;
    public float Height { get; }
    public float Width { get; }
    public int Entrances { get; }
    public int HumanCapacity { get; }

    public float GetSquareCost()
    {
        float basicSquareCostPart = Height * Width * 0.9f; 
        
        switch (BuildMaterial)
        {
            case BuildMaterialEnum.Concrete:
                return basicSquareCostPart*0.87f;
            case BuildMaterialEnum.Brick:
                return basicSquareCostPart*0.8f;
            case BuildMaterialEnum.Wood:
                return basicSquareCostPart*0.78f;
            default:
                return 0;
        }
    }
} 