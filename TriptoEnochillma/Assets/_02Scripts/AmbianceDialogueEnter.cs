using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceDialogueEnter : MonoBehaviour
{
    [SerializeField] private GameObject ambianceDialogue;
    [SerializeField] private bool ambianceText;
    [SerializeField] private Transform playerCamera;

    private void Start()
    {
        playerCamera = Camera.main.transform;
    }

    private void Update()
    {
        if (ambianceDialogue == true)
        {
            transform.LookAt(playerCamera);
        }
        else
        {
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ambianceText == true && ambianceDialogue != null)
        {
            ambianceDialogue.SetActive(true);
        }      
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && ambianceText == true && ambianceDialogue != null)
        {
            ambianceDialogue.SetActive(false);
        }    
    }
}
