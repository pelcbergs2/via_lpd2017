using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class rezultats : MonoBehaviour {
    private int rez;
    public int dziv;
    public Text rez_teksts;
    public Text dziv_teksts;
    public Text txt_beigas;
    public Text ieg_punkt;
    public bool vai_sakt=false;
    shakers shak;
    FirstPersonController fpc;
   
    // Use this for initialization
    void Start () {

        ieg_punkt.enabled = false;
        fpc = GameObject.FindObjectOfType<FirstPersonController>();
        shak = GameObject.FindObjectOfType<shakers>();
        rez = 0;
        dziv = 100;
        teksts();
    }

    public void OnCollisionEnter(Collision node)
    {
        if (node.gameObject.tag == "liels")
        {
            dziv = dziv - 30;
            teksts();
            shak.shakeDuration = 0.5f;
            shak.shakeAmount = 1.5f;
            shak.decreaseFactor = 1f;
        }
        if (node.gameObject.tag == "vid")
        {
            dziv = dziv - 15;
            teksts();
            shak.shakeDuration = 0.5f;
            shak.shakeAmount = 1.2f;
            shak.decreaseFactor = 1f;
        }
        if (node.gameObject.tag == "maz")
        {
            dziv = dziv - 5;
            teksts();
            shak.shakeDuration = 0.5f;
            shak.shakeAmount = 0.7f;
            shak.decreaseFactor = 1f;
        }
        if (node.gameObject.tag == "coin")
        {
            rez = rez +15;
            teksts();
            Destroy(node.gameObject);
            StartCoroutine(ShowMessage("+15", 1));
        }
        if (node.gameObject.tag == "lade")
        {
            rez = rez +50;
            teksts();
            Destroy(node.gameObject);
            StartCoroutine(ShowMessage("+50", 1));
        }
        
    }
    void OnTriggerEnter(Collider node)
    {
        if (node.gameObject.tag == "Game_over")
        {
            beigas();
        }

    }
    IEnumerator ShowMessage(string message, float delay)
    {
        ieg_punkt.text = message;
        ieg_punkt.enabled = true;
        yield return new WaitForSeconds(delay);
        ieg_punkt.enabled = false;
    }

        void teksts()
    {
        rez_teksts.text = "Rezultāts: " + rez.ToString();
        dziv_teksts.text = "Dzivības: " + dziv.ToString();
        if(rez>0)
        fpc.m_WalkSpeed = 25.0f *dziv/100;
        if (dziv <= 0)
        {
            beigas();
        }

    }
    void beigas()
    {
        Time.timeScale = 0;
        txt_beigas.text = "Rezultāts: " + rez.ToString();

        GameObject.Find("txt_beigas").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("but_sakumu").transform.localScale = new Vector3(1, 1, 1);
    }
}
