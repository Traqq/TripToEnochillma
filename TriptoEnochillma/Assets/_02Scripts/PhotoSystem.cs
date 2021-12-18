using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoSystem : MonoBehaviour
{
    [SerializeField] private int resWidth = 2550;
    [SerializeField] private int resHeight = 3300;
    [SerializeField] private Camera m_camera;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            TakeScreenShot();
        }
    }

    public string ScreenShotName(int a_width, int a_height)
    {
        return string.Format("{0}/_09screenshots/screen_{1}x{2}_{3}.png", Application.dataPath, a_width, a_height, System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }

    public void TakeScreenShot()
    {
        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        m_camera.targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
        m_camera.Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        m_camera.targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);
        byte[] bytes = screenShot.EncodeToPNG();
        string filename = ScreenShotName(resWidth, resHeight);
        System.IO.File.WriteAllBytes(filename, bytes);
    }


}
