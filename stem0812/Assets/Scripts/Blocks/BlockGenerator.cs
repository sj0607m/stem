using UnityEngine;
using System.Collections.Generic;

public class BlockGenerator : MonoBehaviour
{
    public GameObject CreateBlock(BlockData data)
    {
        GameObject block = GameObject.CreatePrimitive(data.blockType);
        block.name = data.blockName;
        block.transform.position = data.position;
        block.transform.localScale = data.size;

        MeshRenderer renderer = block.GetComponent<MeshRenderer>();
        renderer.material.color = data.color;

        return block;
    }
}

public class BlockCombiner : MonoBehaviour
{
    public BlockGenerator blockGenerator;

    public GameObject CombineBlocks(CombinedBlockData combinedData)
    {
        GameObject combinedObject = new GameObject(combinedData.combinedName);

        foreach (BlockData blockData in combinedData.blocks)
        {
            GameObject block = blockGenerator.CreateBlock(blockData);
            block.transform.parent = combinedObject.transform;
        }

        return combinedObject;
    }
}
