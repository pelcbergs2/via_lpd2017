using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class sakt_poga : MonoBehaviour {
    FirstPersonController fpc;
    // Use this for initialization
    rezultats vai_sakt;
    void Start()
    {
        vai_sakt = GameObject.FindObjectOfType<rezultats>();
        
            GameObject.Find("txt_beigas").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("but_sakumu").transform.localScale = new Vector3(0, 0, 0);
        fpc = GameObject.FindObjectOfType<FirstPersonController>();
        GameObject.FindGameObjectWithTag("kustiga_siena").GetComponent<Lineara>().enabled = false;
        GameObject[] visi;
        visi = GameObject.FindGameObjectsWithTag("viss");
        foreach (GameObject visi_objekti in visi)
        {
            GameObject istais_objekts = visi_objekti.transform.parent.gameObject;
            istais_objekts.GetComponent<pieskirt_masu>().enabled = false;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            speles_sakums();
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Application.Quit();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Time.timeScale = 1;
            Application.LoadLevel(Application.loadedLevel);
        }

    }
    void speles_sakums()
    {
        vai_sakt.vai_sakt = true;
        fpc.m_WalkSpeed = 25.0f;
        GameObject.Find("but_sakt").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("but_aizvert").transform.localScale = new Vector3(0, 0, 0);
        GameObject.FindGameObjectWithTag("kustiga_siena").GetComponent<Lineara>().enabled = true;
        GameObject[] visi1;
        visi1 = GameObject.FindGameObjectsWithTag("viss");
        foreach (GameObject visi_objekti1 in visi1)
        {
            GameObject istais_objekts1 = visi_objekti1.transform.parent.gameObject;
            istais_objekts1.GetComponent<pieskirt_masu>().enabled = true;
        }
    }

}
