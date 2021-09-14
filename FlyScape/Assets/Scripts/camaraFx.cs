using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraFx : MonoBehaviour
{

    Material material;

    void Awake()
    {
        material = new Material(Shader.Find("huse360/sweep"));
    }
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
