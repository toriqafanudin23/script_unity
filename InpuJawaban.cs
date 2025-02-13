using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InpuJawaban : MonoBehaviour
{
	public InputField j1,j2,j3,j4,j5,j6,j7,j8,j9,j10,j11,j12,j13,j14,j15,j16,j17,j18,j19,j20,j21,j22,j23,j24;
	public GameObject s1,s2,s3,s4,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,s17,s18,s19,s20,s21,s22;
	public string k1,k2,k3,k4,k5,k6,k7,k8,k9,k10,k11,k12,k13,k14,k15,k16,k17,k18,k19,k20,k21,k22,k23,k24;
	public Text t1,t2,t3,t4,t5,t6;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	public void CekJawaban1()
    {
        string userAnswer = j1.text;

        if (userAnswer == k1)
        {
			s1.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban2()
    {
        string userAnswer = j2.text;

        if (userAnswer == k2)
        {
			s2.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban3()
    {
        string userAnswer = j3.text;

        if (userAnswer == k3)
        {
			s3.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban4()
    {
        string userAnswer = j4.text;

        if (userAnswer == k4)
        {
			s4.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban7()
    {
        string userAnswer = j7.text;

        if (userAnswer == k7)
        {
			s7.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t1.text = "24";
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban8()
    {
        string userAnswer = j8.text;

        if (userAnswer == k8)
        {
			s8.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban9()
    {
        string userAnswer = j9.text;

        if (userAnswer == k9)
        {
			s9.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban10()
    {
        string userAnswer = j10.text;

        if (userAnswer == k10)
        {
			s10.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban11()
    {
        string userAnswer = j11.text;

        if (userAnswer == k11)
        {
			s11.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban12()
    {
        string userAnswer = j12.text;

        if (userAnswer == k12)
        {
			s12.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban13()
    {
        string userAnswer = j13.text;

        if (userAnswer == k13)
        {
			s13.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t2.text = "6";
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban14()
    {
        string userAnswer = j14.text;

        if (userAnswer == k14)
        {
			s14.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t3.text = "4";
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban15()
    {
        string userAnswer = j15.text;

        if (userAnswer == k15)
        {
			s15.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban16()
    {
        string userAnswer = j16.text;

        if (userAnswer == k16)
        {
			s16.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban17()
    {
        string userAnswer = j17.text;

        if (userAnswer == k17)
        {
			s17.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t4.text = "3";
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban18()
    {
        string userAnswer = j18.text;

        if (userAnswer == k18)
        {
			s18.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t5.text = "6";
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	public void CekJawaban19()
    {
        string userAnswer = j19.text;
		string userAnswer2 = j20.text;
		string userAnswer3 = j21.text;

        if (userAnswer == k19)
        {
			s19.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban20()
    {
        string userAnswer = j22.text;

        if (userAnswer == k22)
        {
			s20.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t6.text = "147";
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban21()
    {
        string userAnswer = j23.text;

        if (userAnswer == k23)
        {
			s21.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
	
	public void CekJawaban22()
    {
        string userAnswer = j24.text;

        if (userAnswer == k24)
        {
			s22.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
}
