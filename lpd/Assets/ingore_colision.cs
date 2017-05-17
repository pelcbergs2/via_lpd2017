using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingore_colision : MonoBehaviour
{
    void Start()
    {

    }

    public void OnCollisionEnter(Collision node)
    {
        if (node.gameObject.tag == "liels")
        {
            Physics.IgnoreCollision(node.gameObject.GetComponent<Collider>(),gameObject.GetComponent<Collider>());
        }
        if (node.gameObject.tag == "vid")
        {
            Physics.IgnoreCollision(node.gameObject.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        }
        if (node.gameObject.tag == "maz")
        {
            Physics.IgnoreCollision(node.gameObject.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        }
    }
}