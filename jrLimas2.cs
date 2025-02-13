using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jrLimas2 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject objek1;
    public GameObject objek2;
    public GameObject objek3;
	float step = 10f;

    public void tutupJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        // Rotasi objek1 sekitar sumbu X sebesar 90 derajat
        objek1.transform.Rotate(Vector3.down, step);

        // Rotasi objek2 sekitar sumbu Y sebesar 90 derajat
        objek2.transform.Rotate(Vector3.up, step);

        // Rotasi objek3 sekitar sumbu -Y sebesar 90 derajat
        objek3.transform.Rotate(Vector3.right, step);
    }
	
	public void bukaJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        // Rotasi objek1 sekitar sumbu X sebesar 90 derajat
        objek1.transform.Rotate(Vector3.up, step);

        // Rotasi objek2 sekitar sumbu Y sebesar 90 derajat
        objek2.transform.Rotate(Vector3.down, step);

        // Rotasi objek3 sekitar sumbu -Y sebesar 90 derajat
        objek3.transform.Rotate(Vector3.left, step);
    }
}
