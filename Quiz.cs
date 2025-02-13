using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public InputField jawaban1, jawaban2, jawaban3, jawaban4, jawaban5;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public Text skorAkhir;
	
    void Update()
    {
		int skor = 0;
        string kunci1 = "22";
		string kunci2 = "2,3,1";
        string kunci3 = "392";
        string kunci4 = "6";
        string kunci5 = "24";

        string answer1 = jawaban1.text.Trim(); // Trim untuk menghilangkan spasi
		string answer2 = jawaban2.text.Trim();
        string answer3 = jawaban3.text.Trim();
        string answer4 = jawaban4.text.Trim();
        string answer5 = jawaban5.text.Trim();
        
        

        // Cek jawaban dan beri skor
        if (answer1 == kunci1) skor += 20;
		if (answer2 == kunci2) skor += 20;
        if (answer3 == kunci3) skor += 20;
        if (answer4 == kunci4) skor += 20;
        if (answer5 == kunci5) skor += 20;
		
		skorAkhir.text = skor.ToString();
    }
}
