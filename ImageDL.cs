using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ImageDL : MonoBehaviour
{
    public Texture2D savedTexture_renderer1;
    //public static ImageDL instance;
    public string imageUrl = "";
    public Renderer targetRenderer;
    public Button updateButton;

    //private void Start()
    //{
    //    instance = this;
    //}
    private void Start()
    {
        updateButton.onClick.AddListener(StartDownload);
        targetRenderer = GetComponent<Renderer>();
        StartDownload();
    }
    public void StartDownload()
    {
        StartCoroutine(DownloadImage(SetTexture));
    }
    public void SetTexture()
    {
        targetRenderer.material.mainTexture = savedTexture_renderer1;
    }
    public IEnumerator DownloadImage(Action a)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(imageUrl);
        yield return www.SendWebRequest();
        Debug.Log(imageUrl);
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Failed to download image: " + www.error);
        }
        else
        {
            Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            savedTexture_renderer1 = texture;
            //targetRenderer.material.mainTexture = texture;
            a();
        }
    }
}
