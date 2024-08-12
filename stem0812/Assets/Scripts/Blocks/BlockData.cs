using UnityEngine;

[System.Serializable]
public class BlockData
{
    public string blockName;
    public PrimitiveType blockType;
    public Vector3 position;
    public Vector3 size;
    public Color color;

    public BlockData(string name, PrimitiveType type, Vector3 pos, Vector3 size, Color color)
    {
        this.blockName = name;
        this.blockType = type;
        this.position = pos;
        this.size = size;
        this.color = color;
    }
}
