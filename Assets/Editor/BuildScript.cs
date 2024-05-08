using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
public class BuildScript : MonoBehaviour
{
    public static void Build()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = new string[] { "Assets/Scenes/SampleScene.unity" };
        options.target = EditorUserBuildSettings.activeBuildTarget;
        options.locationPathName = "C:\\Users\\Public\\Documents\\Unity-CI-Test\\_builds\\MyProject.exe";
        options.targetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        options.options = BuildOptions.Development | BuildOptions.AllowDebugging;

        FMODUnity.EventManager.CopyToStreamingAssets(BuildTarget.StandaloneWindows64);

        BuildPipeline.BuildPlayer(options);
    }
}
#endif