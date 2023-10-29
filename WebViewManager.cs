using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuplex.WebView; 
public class WebViewManager : MonoBehaviour
{
    // Start is called before the first frame update
    public CanvasWebViewPrefab webViewPrefab;
    public Button button;
    public string url;

    async private void Start()
    {
        button.onClick.AddListener(() => 
        {
            webViewPrefab.WebView.LoadUrl(url);
        });
        //webViewPrefab = WebViewPrefab.Instantiate(8, 4);
        //webViewPrefab.transform.parent = transform;

        //webViewPrefab.transform.localPosition = new Vector3(0, 0f, 0.5f);
        //webViewPrefab.transform.LookAt(

    }


}
