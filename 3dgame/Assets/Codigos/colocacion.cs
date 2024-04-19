using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class colocacion : MonoBehaviour
{
    [SerializeField] string nombreobjeto;
    [SerializeField] string puerta;
    public Animator anim;
   
  
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name== nombreobjeto)
        {
           
            anim.SetBool("activarpuerta_D", true);
            anim.SetBool("activarpuerta_U", true);
            
            Debug.Log("Es correcto");
        }
        else
        {
            anim.SetBool("activarpuerta_f", false);
            anim.SetBool("activarpuerta_D", false);
            anim.SetBool("activarpuerta_U", false);

            Debug.Log("Es incorrecto");

        }

   
    }

   
}
