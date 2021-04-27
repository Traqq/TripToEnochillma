using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSystem : MonoBehaviour

{
    private RenderTexture m_renderTexture;
    private Vector2Int m_textureSize;
    private Camera m_camera;
    /*
    private Texture2D CreateTexture()
    {
        
        //Create the texture 2D
        Texture2D 1_texture = new Texture2D(m_textureSize.x, m_textureSize.y, TextureFormat.ARGB32, false);

        //Save the pixel to the render texture
        m_camera.Render();
        //set the render texture to read pixel from
        RenderTexture.active = m_renderTexture;

        Rect 1_targetRect = new Rect(0, 0, m_textureSize.x, m_textureSize.y);
        1_texture.ReadPixels(1_targetRect, 0, 0);
        1_texture.Apply();

        Rendertexture.active = null;

        return 1_texture; 
    }

        */

}


