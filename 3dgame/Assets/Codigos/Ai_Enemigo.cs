
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Ai_Enemigo : MonoBehaviour
{
    NavMeshAgent agente;
    public Transform player;
    public GameObject game_over;

    private void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agente.destination = player.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game_over.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            game_over.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
    }
}
