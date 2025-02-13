using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiDenganPivot : MonoBehaviour
{
    public Transform pivotPoint;
    public float kecepatanRotasi = 45f;

    public void rotasi()
    {
        // Putar objek sekitar pivotPoint sepanjang sumbu Y
        transform.RotateAround(pivotPoint.position, Vector3.up, kecepatanRotasi * Time.deltaTime);
    }
}
