using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceDialogueEnter : MonoBehaviour
{
    [SerializeField] private GameObject ambianceDialogue;
    [SerializeField] private GameObject cinematicDialogue;
    [SerializeField] private bool ambianceText;
    [SerializeField] private bool cinematicText;

    private void Start()
    {
        //dialogue.SetActive(false);
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
