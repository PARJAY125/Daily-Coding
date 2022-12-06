using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    public class Character
    {
        string nama;
        int hp, hpMax, str, regen;
        public Text displayStat;

        public Character(string nama, int hp, int hpMax, int str, int regen, Text displayStat)
        {
            this.nama = nama;
            this.hp = hp;
            this.hpMax = hpMax;
            this.str = str;
            this.regen = regen;
            this.displayStat = displayStat;
        }

        public void serang(Character penyerang, Character diserang)
        {
            if (penyerang.hp == 0 )
            {
                Debug.Log("Lu udah mati jangan nyerang lagi");
                return;
            }

            if (diserang.hp == 0)
            {
                Debug.Log("Musuh lu udah mati jangan diserang lagi");
                return;
            }
            
            if (diserang.hp - penyerang.str < 1 )
            {
                Debug.Log("Musuh Mati");
                diserang.hp = 0;
            }

            else
            {
                diserang.hp = diserang.hp - penyerang.str;
            }

            diserang.displayTextStat(diserang);
        }

        public void sembuhkan(Character diriSendiri)
        {
            if (diriSendiri.hp == 0 )
            {
                Debug.Log("Lu udah mati jangan nyerang lagi");
                return;
            }

            if (diriSendiri.hp == diriSendiri.hpMax)
            {
                Debug.Log("Darah lu udah penuh");
                return;
            }

            if (diriSendiri.hp + diriSendiri.regen > diriSendiri.hpMax)
            {
                diriSendiri.hp = diriSendiri.hpMax;
                Debug.Log("Regennya nggak maksimal");
            }

            else
            {
                diriSendiri.hp = diriSendiri.hp + diriSendiri.regen;
            }

            diriSendiri.displayTextStat(diriSendiri);
        }

        public void displayTextStat(Character diriSendiri) {
            Debug.Log(diriSendiri.hp);
            diriSendiri.displayStat.text =
                "HP : " + diriSendiri.hp + "\n" +
                "STR : " + diriSendiri.str + "\n" +
                "REGEN : " + diriSendiri.regen + "\n";
        }

    }

    Character pemain, musuh;
    // Start is called before the first frame update
    void Start()
    {
        pemain = new Character("pemain", 10, 10, 3, 3, GameObject.Find("Canvas/Pemain Stat").GetComponent<Text>());
        musuh = new Character("musuh", 8, 10, 1, 1, GameObject.Find("Canvas/Enemy Stat").GetComponent<Text>());

        pemain.displayTextStat(pemain);
        musuh.displayTextStat(musuh);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void btnClickserang()
    {
        pemain.serang(pemain, musuh);
        aksiKomputer();
    }


    public void btnClicksembuhkan()
    {
        pemain.sembuhkan(pemain);
        aksiKomputer();
    }

    void aksiKomputer()
    {
        int pilihAcak = Random.Range(1, 3);
        if (pilihAcak == 1) musuh.serang(musuh, pemain);
        else musuh.sembuhkan(musuh);
    }
}
