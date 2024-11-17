namespace oop_lab__project.Constructions;

public class Construction
{
    public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
    {
        Height = height;
        Width = width;
        Entrances = entrances;
        HumanCapacity = humanCapacity;
        BuildMaterial = buildMaterial;
    }

    private string _buildMaterial;
    public string BuildMaterial
    {
        get
        {
            return _buildMaterial;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value), "Build material cannot be null or empty.");
            }
            _buildMaterial = value;
        }
    }
    public float Height { get; set; }
    public float Width { get; set; }
    public int Entrances { get; set; }
    public int HumanCapacity { get; set; }
} 