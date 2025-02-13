using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aturCahaya : MonoBehaviour
{
    public float defaultAmbientIntensity = 1.0f;
    public float increaseFactor = 1.5f;
    public float decreaseFactor = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // Tombol untuk meningkatkan intensitas pencahayaan
        if (Input.GetKeyDown(KeyCode.I))
        {
            tambahTerang();
        }

        // Tombol untuk mengurangi intensitas pencahayaan
        if (Input.GetKeyDown(KeyCode.D))
        {
            kurangTerang();
        }
    }

    // Fungsi untuk meningkatkan intensitas pencahayaan
    public void tambahTerang()
    {
        RenderSettings.ambientIntensity *= increaseFactor;
        Debug.Log("Intensitas Pencahayaan Ditingkatkan: " + RenderSettings.ambientIntensity);
    }

    // Fungsi untuk mengurangi intensitas pencahayaan
    public void kurangTerang()
    {
        RenderSettings.ambientIntensity *= decreaseFactor;
        Debug.Log("Intensitas Pencahayaan Dikurangi: " + RenderSettings.ambientIntensity);
    }
}
