using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableAspect : MonoBehaviour
{
    public Camera camera;
    public float baseWidth = 9.0f;
    public float baseHeight = 16.0f;

    void Awake()
    {
        // 幅固定+高さ可変
        var scaleWidth = (Screen.height / this.baseHeight) * (this.baseWidth / Screen.width);
        this.camera.orthographicSize *= scaleWidth;
    }
}
