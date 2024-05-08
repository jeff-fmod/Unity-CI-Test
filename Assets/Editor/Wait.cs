using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
public class Wait : MonoBehaviour
{
    void Start()
    {
        EditorUserBuildSettings.waitForManagedDebugger = true;
    }
}
#endif
