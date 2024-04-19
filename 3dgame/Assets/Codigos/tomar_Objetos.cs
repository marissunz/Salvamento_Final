using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject manopunto;
    private GameObject tomarobjeto = null;

    void Update()
    {
        if(tomarobjeto!=null)
        {
            if (Input.GetKey("e"))
            {
                tomarobjeto.GetComponent<Rigidbody>().useGravity = true;
                tomarobjeto.GetComponent<Rigidbody>().isKinematic = false;
                tomarobjeto.gameObject.transform.SetParent(null);
                tomarobjeto = null;

            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("objeto"))
        {
            if (Input.GetKey("f")&& tomarobjeto==null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = manopunto.transform.position;
                other.gameObject.transform.SetParent(manopunto.gameObject.transform);
                tomarobjeto = other.gameObject;
            }
        }
    }
}
