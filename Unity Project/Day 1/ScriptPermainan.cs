using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPermainan : MonoBehaviour
{

    public Text textHasil = null;
    // Start is called before the first frame update
    void Start()
    {
        textHasil = GameObject.Find("Canvas/Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gunting() {
        Debug.Log("Gunting");
        hasil(1);
    }

    public void kertas() {
        Debug.Log("Kertas");
        hasil(2);
    }

    public void batu() {
        Debug.Log("Batu");
        hasil(3); 
    }

    public void hasil(int pilihanPemain) {
        int pilihanKomputer = Random.Range(1, 4);
        Debug.Log("pilihan user : " + pilihanPemain);
        Debug.Log("pilihan komputer : " + pilihanKomputer);

        if ( pilihanPemain == pilihanKomputer ) textHasil.text = "Seri";
        else if ( pilihanPemain + 1 == pilihanKomputer || (pilihanPemain == 3 && pilihanKomputer == 1) ) textHasil.text = "Menang";
        else textHasil.text = "kalah";
    }
}
