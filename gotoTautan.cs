using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotoTautan : MonoBehaviour
{
    public string tautan;

    public void BukaTautan()
    {
        // Memeriksa apakah tautan tidak kosong atau null sebelum membuka
        if (!string.IsNullOrEmpty(tautan))
        {
            // Buka tautan
            Application.OpenURL(tautan);
        }
        else
        {
            Debug.LogWarning("Tautan kosong atau tidak valid.");
        }
    }
}
