using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lineara : MonoBehaviour {
    [SerializeField]
    private Transform startTransform;

    [SerializeField]
    private Transform endTransform;

    [SerializeField]
    private float movementTimeInSeconds = 80f;
    [SerializeField]
    private float sakuma_laiks = 0f;
    rezultats vai_sakt;

    // Use this for initialization
    void Start () {
        vai_sakt = GameObject.FindObjectOfType<rezultats>();
        if (vai_sakt.vai_sakt == true)
        {

            StartCoroutine(Example(sakuma_laiks));
        }
       
    }
    IEnumerator Example(float sakuma_laiks)
    {
        yield return new WaitForSeconds(sakuma_laiks);
        Destroy(GameObject.FindWithTag("l_siena"));
        float t = 0f;

        while(t < 1f)
        {
            transform.position = Vector3.Lerp(startTransform.position, endTransform.position, t);
            t += Time.deltaTime / movementTimeInSeconds;
            yield return null;
        }
        }

    // Update is called once per frame
    void Update () {
		
	}
}
