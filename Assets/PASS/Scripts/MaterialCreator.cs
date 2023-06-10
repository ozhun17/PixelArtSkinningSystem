using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace PixelArtSkinningSystem
{
    public class MaterialCreator : ScriptableObject
    {


        [MenuItem("Tools/PASS/UnlitURPMaterial")]
        static void CreateMaterialUnlitURP()
        {
            Material material = new Material(Shader.Find("Shader Graphs/UnlitURP"));
            AssetDatabase.CreateAsset(material, "Assets/PASS/Materials/UnlitURP.mat");
            Debug.Log(AssetDatabase.GetAssetPath(material));
        }
        [MenuItem("Tools/PASS/LitURPMaterial")]
        static void CreateMaterialLitURP()
        {
            Material material = new Material(Shader.Find("Shader Graphs/LitURP"));
            AssetDatabase.CreateAsset(material, "Assets/PASS/Materials/LitURP.mat");
            Debug.Log(AssetDatabase.GetAssetPath(material));
        }
        [MenuItem("Tools/PASS/LitBuiltinMaterial")]
        static void CreateMaterialLitBuiltin()
        {
            Material material = new Material(Shader.Find("Shader Graphs/LitBuiltin"));
            AssetDatabase.CreateAsset(material, "Assets/PASS/Materials/LitBuiltin.mat");
            Debug.Log(AssetDatabase.GetAssetPath(material));
        }
        [MenuItem("Tools/PASS/UnlitBuiltinMaterial")]
        static void CreateMaterialUnlitBuiltin()
        {
            Material material = new Material(Shader.Find("Shader Graphs/UnlitBuiltin"));
            AssetDatabase.CreateAsset(material, "Assets/PASS/Materials/UnlitBuiltin.mat");
            Debug.Log(AssetDatabase.GetAssetPath(material));
        }
    }
}


