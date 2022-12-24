using UnityEngine;
using System.Collections;

public class Consts : MonoBehaviour
{
    public static float screenLimitX, screenLimitY;

    void Awake()
    {
        Camera cam;
        cam = Camera.main;
        screenLimitX = cam.orthographicSize * cam.aspect;
        screenLimitY = cam.orthographicSize;
    }
}

