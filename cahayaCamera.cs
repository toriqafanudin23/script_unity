using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cahayaCamera : MonoBehaviour
{
    public float cameraBrightness = 1.0f;

    void Update()
    {
        // Tombol untuk meningkatkan kecerahan cahaya kamera
        if (Input.GetKeyDown(KeyCode.I))
        {
            IncreaseCameraBrightness();
        }

        // Tombol untuk mengurangi kecerahan cahaya kamera
        if (Input.GetKeyDown(KeyCode.D))
        {
            DecreaseCameraBrightness();
        }
    }

    public void IncreaseCameraBrightness()
    {
        // Meningkatkan kecerahan cahaya kamera
        ChangeCameraBrightness(1.5f); // Sesuaikan nilai sesuai kebutuhan
    }

    public void DecreaseCameraBrightness()
    {
        // Mengurangi kecerahan cahaya kamera
        ChangeCameraBrightness(0.5f); // Sesuaikan nilai sesuai kebutuhan
    }

    void ChangeCameraBrightness(float brightnessMultiplier)
    {
        // Mengubah kecerahan cahaya kamera berdasarkan multiplier
        Camera.main.backgroundColor *= brightnessMultiplier;

        // Pastikan nilai color berada di dalam rentang 0-1
        Camera.main.backgroundColor = new Color(
            Mathf.Clamp01(Camera.main.backgroundColor.r),
            Mathf.Clamp01(Camera.main.backgroundColor.g),
            Mathf.Clamp01(Camera.main.backgroundColor.b),
            Camera.main.backgroundColor.a
        );
    }
}