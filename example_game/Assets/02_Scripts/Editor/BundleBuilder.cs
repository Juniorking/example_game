using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class BundleBuilder : MonoBehaviour
{
    [MenuItem("Assets/Build AssetBundle")]
    public static void BuildAssetBundle()
    {
        string path = Application.dataPath + "/AssetBundles";
        


        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
    }
}
