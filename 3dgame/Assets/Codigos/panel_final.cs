using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_final : MonoBehaviour
{
    [SerializeField] string nombreobjeto;
    [SerializeField] string puerta;
    public Animator anim;
    public GameObject p_final;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == nombreobjeto)
        {
            anim.SetBool("activarpuerta_f", true);
            p_final.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            if (Input.GetKey("x"))
            {
                Application.Quit();
            }


            Debug.Log("Es correcto");
        }
    }
}
