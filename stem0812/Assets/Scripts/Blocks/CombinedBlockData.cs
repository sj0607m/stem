[System.Serializable]
public class CombinedBlockData
{
    public string combinedName;
    public List<BlockData> blocks;

    public CombinedBlockData(string name, List<BlockData> blocks)
    {
        this.combinedName = name;
        this.blocks = blocks;
    }
}
