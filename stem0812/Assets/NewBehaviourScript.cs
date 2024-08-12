using UnityEngine;
using System.Collections.Generic;

public class BlockManager : MonoBehaviour
{
    public BlockGenerator blockGenerator;
    public BlockCombiner blockCombiner;
    public ObjectSaver objectSaver;
    public ObjectLoader objectLoader;

    void Start()
    {
        // ��� �����͸� �����մϴ�.
        List<BlockData> blocks = new List<BlockData>
        {
            new BlockData("CubeBlock", PrimitiveType.Cube, new Vector3(0, 0.5f, 0), new Vector3(1, 1, 1), Color.blue),
            new BlockData("SphereBlock", PrimitiveType.Sphere, new Vector3(1, 1, 0), new Vector3(1, 1, 1), Color.red)
        };

        // ����� �����Ͽ� ���� ������Ʈ�� ����ϴ�.
        CombinedBlockData combinedData = new CombinedBlockData("MyCombinedBlock", blocks);
        GameObject combinedObject = blockCombiner.CombineBlocks(combinedData);

        // ���� ������Ʈ�� �����մϴ�.
        objectSaver.SaveObject(combinedData, "MyCombinedBlockData");

        // ���� ������Ʈ�� ������ �� �ҷ��ɴϴ�.
        Destroy(combinedObject);

        CombinedBlockData loadedData = objectLoader.LoadObject("MyCombinedBlockData");
        if (loadedData != null)
        {
            GameObject loadedObject = blockCombiner.CombineBlocks(loadedData);
        }
    }
}
