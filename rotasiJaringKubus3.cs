using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasiJaringKubus3 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject objek1;
    public GameObject objek2;
    public GameObject objek3;
    public GameObject objek4;
    public GameObject objek5;

    public void tutupJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        // Rotasi objek1 sekitar sumbu X sebesar 90 derajat
        objek1.transform.Rotate(Vector3.left, 10f);

        // Rotasi objek2 sekitar sumbu Y sebesar 90 derajat
        objek2.transform.Rotate(Vector3.down, 10f);

        // Rotasi objek3 sekitar sumbu -Y sebesar 90 derajat
        objek3.transform.Rotate(Vector3.down, 10f);

        // Rotasi objek4 sekitar sumbu -Y sebesar 90 derajat
        objek4.transform.Rotate(Vector3.right, 10f);

        // Rotasi objek5 sekitar sumbu -X sebesar 90 derajat
        objek5.transform.Rotate(Vector3.up, 10f);
    }
	
	public void bukaJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        // Rotasi objek1 sekitar sumbu X sebesar 90 derajat
        objek1.transform.Rotate(Vector3.right, 10f);

        // Rotasi objek2 sekitar sumbu Y sebesar 90 derajat
        objek2.transform.Rotate(Vector3.up, 10f);

        // Rotasi objek3 sekitar sumbu -Y sebesar 90 derajat
        objek3.transform.Rotate(Vector3.up, 10f);

        // Rotasi objek4 sekitar sumbu -Y sebesar 90 derajat
        objek4.transform.Rotate(Vector3.left, 10f);

        // Rotasi objek5 sekitar sumbu -X sebesar 90 derajat
        objek5.transform.Rotate(Vector3.down, 10f);
    }
}
