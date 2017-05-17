using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakers : MonoBehaviour {

    // Use this for initialization
    public Transform camTransform;
    public static shakers main;

    // How long the object should shake for.
    public float shakeDuration;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount ;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;
    void Star()
    {
        main = this;
    }

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0f;
            camTransform.localPosition = originalPos;
        }
    }
}
