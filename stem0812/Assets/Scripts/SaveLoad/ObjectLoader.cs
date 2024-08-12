using System.IO;
using UnityEngine;

public class ObjectLoader : MonoBehaviour
{
    public CombinedBlockData LoadObject(string fileName)
    {
        string filePath = Path.Combine(Application.persistentDataPath, fileName + ".json");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonUtility.FromJson<CombinedBlockData>(json);
        }
        else
        {
            Debug.LogError("File not found at " + filePath);
            return null;
        }
    }
}
