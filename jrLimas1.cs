using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jrLimas1 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject objek1;
    public GameObject objek2;
    public GameObject objek3;
    public GameObject objek4;
	float step = 9f;

    public void tutupJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        // Rotasi objek1 sekitar sumbu X sebesar 90 derajat
        objek1.transform.Rotate(Vector3.left, step);

        // Rotasi objek2 sekitar sumbu Y sebesar 90 derajat
        objek2.transform.Rotate(Vector3.down, step);

        // Rotasi objek3 sekitar sumbu -Y sebesar 90 derajat
        objek3.transform.Rotate(Vector3.right, step);

        // Rotasi objek4 sekitar sumbu -Y sebesar 90 derajat
        objek4.transform.Rotate(Vector3.up, step);

        // Rotasi objek5 sekitar sumbu -X sebesar 90 derajat
    }
	
	public void bukaJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        // Rotasi objek1 sekitar sumbu X sebesar 90 derajat
        objek1.transform.Rotate(Vector3.right, step);

        // Rotasi objek2 sekitar sumbu Y sebesar 90 derajat
        objek2.transform.Rotate(Vector3.up, step);

        // Rotasi objek3 sekitar sumbu -Y sebesar 90 derajat
        objek3.transform.Rotate(Vector3.left, step);

        // Rotasi objek4 sekitar sumbu -Y sebesar 90 derajat
        objek4.transform.Rotate(Vector3.down, step);

        // Rotasi objek5 sekitar sumbu -X sebesar 90 derajat
    }
}
