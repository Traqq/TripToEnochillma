using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PhotoCapture : MonoBehaviour
{
    [Header("Photo PostProc")]
    [SerializeField] private GameObject vignetteProfile;

    [Header("Camera")]
    [SerializeField] private Camera m_camera;

    [Header("Photo Taker")]
    [SerializeField] private Image photoDisplayArea;
    [SerializeField] private GameObject photoFrame;

    [Header("Flash Effect")]
    [SerializeField] private GameObject cameraFlash;
    [SerializeField] private float flashTime;

    [Header("Photo Fader Effect")]
    [SerializeField] private Animator fadingAnimation;

    [Header("Sound Effect")]
    [SerializeField] private AudioSource cameraClick;

    [Header("Screenshot Rez")]
    [SerializeField] private int resWidth = 2550;
    [SerializeField] private int resHeight = 3300;


    private Texture2D screenCapture;
    private bool viewingPhoto;
    private bool isInPhotoMode = false;
    //private float waitForQuit = 2.0f;
    private float securityTimer;

    void Start()
    {
        screenCapture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);   
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N) && isInPhotoMode == true)
        {
            if(!viewingPhoto)
            {
                StartCoroutine(CapturePhoto());
            }
            else
            {
                RemovePhoto();
            }
        }

        if (Input.GetKeyDown(KeyCode.B) && isInPhotoMode == false)
        {
            vignetteProfile.SetActive(true);
            isInPhotoMode = true;
        }

        if (isInPhotoMode == true)
        {
            securityTimer += Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.B) && isInPhotoMode == true && securityTimer >= 1.0f)
        {
            RemovePhoto();
            vignetteProfile.SetActive(false);
            isInPhotoMode = false;
            securityTimer = 0;
        }
    }

    IEnumerator CapturePhoto()
    {       
        viewingPhoto = true;
        yield return new WaitForEndOfFrame();
        Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);
        screenCapture.ReadPixels(regionToRead, 0, 0, false);
        screenCapture.Apply();
        ShowPhoto();
        yield return new WaitForSeconds(1);
        TakeScreenShot();
    }

    void ShowPhoto()
    {
        cameraClick.Play();
        StartCoroutine(CameraFlashEffect());
        
        Sprite photoSprite = Sprite.Create(screenCapture, new Rect(0.0f, 0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);
        photoDisplayArea.sprite = photoSprite;

        photoFrame.SetActive(true);
        fadingAnimation.Play("PhotoFade");
    }

    IEnumerator CameraFlashEffect()
    {
        cameraFlash.SetActive(true);
        yield return new WaitForSeconds(flashTime);
        cameraFlash.SetActive(false);
    }

    void RemovePhoto()
    {
        viewingPhoto = false;
        photoFrame.SetActive(false);
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
