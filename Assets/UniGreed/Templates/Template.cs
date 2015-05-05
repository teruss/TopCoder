using UnityEngine;
using System.Collections;

public class Template : MonoBehaviour
{
    void Start()
    {
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(gameObject, "Assets/UniGreed/Templates/Template.cs (8,9)", Application.loadedLevelName + "Test");
    }
}
