using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsLock : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60; //-1 for unlimited FPS
    }
}
