using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSystem : MonoBehaviour
{

    [SerializeField] private RenderTexture m_renderTexture;
    private Vector2Int m_textureSize;
    [SerializeField] private Camera m_camera;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            CreateTexture();
        }
    }

    private Texture2D CreateTexture()
    {
        Debug.Log("Smile");
        //Create 2D texture
        Texture2D l_texture = new Texture2D(m_textureSize.x, m_textureSize.y, TextureFormat.ARGB32, false);

        // Save the pixel to the render texture
        m_camera.Render();
        //Set the render texture to read pixel from
        RenderTexture.active = m_renderTexture;

        Rect l_targetRect = new Rect(0, 0, m_textureSize.x, m_textureSize.y);
        l_texture.ReadPixels(l_targetRect, 0, 0);
        l_texture.Apply();

        RenderTexture.active = null;
        Debug.Log("PhotoPrinted");
        return l_texture;
        
    }

}
