using UnityEditor;
using UnityEngine;

public class SetEyePass
{
    [MenuItem("RenderPath/SetSingle")]
    static void SetSingle()
    {
        var was = PlayerSettings.stereoRenderingPath;
        PlayerSettings.stereoRenderingPath = StereoRenderingPath.SinglePass;
        Debug.Log("RenderPath was: " + was + " now is: " + PlayerSettings.stereoRenderingPath);
        AssetDatabase.SaveAssets();
    }

    [MenuItem("RenderPath/SetMulti")]
    static void SetMulti()
    {
        var was = PlayerSettings.stereoRenderingPath;
        PlayerSettings.stereoRenderingPath = StereoRenderingPath.MultiPass;
        Debug.Log("RenderPath was: " + was + " now is: " + PlayerSettings.stereoRenderingPath);
        AssetDatabase.SaveAssets();
    }
    
    [MenuItem("RenderPath/SetSingleInstance")]
    static void SetSingleInstance()
    {
        var was = PlayerSettings.stereoRenderingPath;
        PlayerSettings.stereoRenderingPath = StereoRenderingPath.Instancing;
        Debug.Log("RenderPath was: " + was + " now is: " + PlayerSettings.stereoRenderingPath);
        AssetDatabase.SaveAssets();
    }
}
