using UnityEngine;

public enum ColorDistributionPattern
{
    Uniform,    // Uniforme
    Striped,    // Listrado
    Spotted,    // Com manchas
    Gradient    // Gradiente
}

public class BeetleMale : MonoBehaviour
{
    private Color beetleColor;
    private float size;
    private ColorDistributionPattern colorPattern;

    public Color BeetleColor
    {
        get { return beetleColor; }
        set { beetleColor = value; }
    }

    public float Size
    {
        get { return size; }
        set { size = value; }
    }

    public ColorDistributionPattern ColorPattern
    {
        get { return colorPattern; }
        set { colorPattern = value; }
    }

    void Start()
    {
        beetleColor = Color.green;
        size = 1.0f;
        colorPattern = ColorDistributionPattern.Striped;
    }
    void OnMouseDown()
    {
        Debug.Log("Inseto clicado!");
    }
}

