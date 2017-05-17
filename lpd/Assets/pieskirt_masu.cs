using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieskirt_masu : MonoBehaviour {
    public Rigidbody rb;
    [SerializeField]
    private float sakuma_laiks = 0f;

    [SerializeField]
    private float masa = 0f;
    rezultats vai_sakt;
    // Use this for initialization
    void Start () {
        vai_sakt = GameObject.FindObjectOfType<rezultats>();
        if (vai_sakt.vai_sakt == true)
        {
            StartCoroutine(Example(sakuma_laiks, masa));
        }
    }

    IEnumerator Example(float sakuma_laiks, float masa)
    {
        yield return new WaitForSeconds(sakuma_laiks);
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        if (masa < 20.0f)
        {
            rb.mass =System.Convert.ToSingle(svars(10.0,20.0));
        }
        else
        {
            if(masa < 60.0f)
            {
                rb.mass = System.Convert.ToSingle(svars(40.0, 60.0));
            }else
            {
                rb.mass = System.Convert.ToSingle(svars(80.0, 120.0));
            }
        }
        


    }
    public double svars(double min, double max)
    {
        System.Random random = new System.Random();
        return random.NextDouble() * (max - min) + min;
    }

    // Update is called once per frame
    void Update () {
		
	}

}

