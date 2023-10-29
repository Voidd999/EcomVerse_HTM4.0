using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Vuplex.WebView;
using Coherence;
using Coherence.Toolkit;
public class testWebView : MonoBehaviour
{
   public CanvasWebViewPrefab webViewPrefab;
    CoherenceSync sync;
    CoherenceBridge bridge;
    public Button button;
    public string url;

    // Start is called before the first frame update
    void Start()
    {
        bridge = FindObjectOfType<CoherenceBridge>();
        webViewPrefab = FindObjectOfType<WebViewManager>().webViewPrefab;
        button = GameObject.Find("SetWebButton").GetComponent<Button>();
        //webViewPrefab = WebViewPrefab.Instantiate(1, 0.8f);
        // Position the prefab how we want it
        //webViewPrefab.transform.parent = WebViewTransform;
        //webViewPrefab.transform.localPosition = new Vector3(0, 0f, 0.5f);

        // webViewPrefab.transform.localRotation = Quaternion.Euler(0,180,0);
        //webViewPrefab.transform.LookAt(WebViewTransform);
        // Load a URL once the prefab finishes initializing
        button.onClick.AddListener(() => 
        {
            SendURL(url);
        });

    }

    public void SendURL(string url)
    {
        if (url != string.Empty)
        {
            byte[] encodedMessage = Encoding.UTF8.GetBytes(url);

            CoherenceClientConnection myConnection = bridge.ClientConnections.GetMine();
            myConnection.SendClientMessage<testWebView>(nameof(SetWebView), MessageTarget.All, encodedMessage);
        }
    }
    public void SetWebView(byte[] encodedMessage)
    {
        string url = Encoding.UTF8.GetString(encodedMessage);
        //await webViewPrefab.WaitUntilInitialized();
        webViewPrefab.WebView.LoadUrl(url);

    }

}
