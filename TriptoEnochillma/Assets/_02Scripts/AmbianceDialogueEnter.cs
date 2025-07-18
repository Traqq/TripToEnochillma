using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceDialogueEnter : MonoBehaviour
{
    [SerializeField] private GameObject ambianceDialogue;
    [SerializeField] private bool ambianceText;
    [SerializeField] private Camera m_camera;
    [SerializeField] private Transform m_target;
    [SerializeField] private Vector3 m_offset;
    [SerializeField] private RectTransform m_background;
    [SerializeField] private RectTransform m_parent;

   
    private void Start()
    {
        ambianceDialogue.SetActive(false);
        m_parent = transform.parent.GetComponent<RectTransform>();
        m_background = GetComponent<RectTransform>();     
    }

    private void Update()
    {
        if (ambianceDialogue == true)
        {
           Vector3 pos = m_target.position + m_offset;
           Vector2 pos2D = m_camera.WorldToViewportPoint(pos);
           pos2D.Scale(new Vector2(m_parent.rect.width, m_parent.rect.height));

           m_background.anchoredPosition = pos2D;
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
