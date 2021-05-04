using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private Camera mainCamera;
    private float paddleInitialY;
  
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        paddleInitialY = this.transform.position.y;
    }

 
    void Update()
    {
        Debug.Log("update");
        paddleMovement();
    }

    private void paddleMovement()
    {
        float mousePositionWorldX = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0)).x;
        this.transform.position = new Vector3(mousePositionWorldX, paddleInitialY, 0);
        Debug.Log("Yeet");
    }
}
