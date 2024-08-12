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
        // 블록 데이터를 정의합니다.
        List<BlockData> blocks = new List<BlockData>
        {
            new BlockData("CubeBlock", PrimitiveType.Cube, new Vector3(0, 0.5f, 0), new Vector3(1, 1, 1), Color.blue),
            new BlockData("SphereBlock", PrimitiveType.Sphere, new Vector3(1, 1, 0), new Vector3(1, 1, 1), Color.red)
        };

        // 블록을 조합하여 복합 오브젝트를 만듭니다.
        CombinedBlockData combinedData = new CombinedBlockData("MyCombinedBlock", blocks);
        GameObject combinedObject = blockCombiner.CombineBlocks(combinedData);

        // 복합 오브젝트를 저장합니다.
        objectSaver.SaveObject(combinedData, "MyCombinedBlockData");

        // 복합 오브젝트를 삭제한 후 불러옵니다.
        Destroy(combinedObject);

        CombinedBlockData loadedData = objectLoader.LoadObject("MyCombinedBlockData");
        if (loadedData != null)
        {
            GameObject loadedObject = blockCombiner.CombineBlocks(loadedData);
        }
    }
}
