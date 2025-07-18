using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private GameObject m_intTooltip;
    [SerializeField] private Vector3 m_pickPosition;
    public bool interactionTrigger = false;
    internal Transform itemGet;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "InteractableObject")
        {
            m_intTooltip.SetActive(true);
            interactionTrigger = true;
            itemGet = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "InteractableObject")
        {
            HideTooltip();
            interactionTrigger = false;
        }
    }

    private void HideTooltip()
    {
        m_intTooltip.SetActive(false);
    }

    public void InteractionPickableObject()
    {
        itemGet.position = new Vector3(m_pickPosition.x, m_pickPosition.y, m_pickPosition.z);
    }

}
