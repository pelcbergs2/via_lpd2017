using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour {
    rezultats dzivibas;
    void OnTriggerEnter(Collider node)
    {
        if (node.gameObject.tag != "fps")
        {
            Destroy(node.gameObject);
        }
       
      
    }
}
