using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Coherence;
using Coherence.Toolkit;
using UnityEngine.InputSystem;
using System.Text;

public class ChatManager : MonoBehaviour
{
    //public static ChatManager Singleton;
    public ChatMessage chatMessagePrefab;
    [SerializeField] CanvasGroup chatContent;
    [SerializeField] TMP_InputField chatInput;
    [SerializeField] InputField playerNameInput;
    [SerializeField] Button sendMessage;
    public string playerName;

    CoherenceBridge bridge;
    public TextMeshProUGUI playerNametext;
    //void Awake()
    //{ ChatManager.Singleton = this; }
    private void Start()
    {
        chatContent = GameObject.Find("Chat Content").GetComponent<CanvasGroup>();
        chatInput   = GameObject.Find("Chat Input (Input Field)").GetComponent<TMP_InputField>();
       // playerNametext = GameObject.Find("playerName").GetComponent<TextMeshProUGUI>(); 
        playerName = GameObject.Find("selfChat").GetComponent<NetworkChat>().playerNameInput.text;
        playerNametext.text = playerName;

        sendMessage = GameObject.Find("SendMessage").GetComponent<Button>();
        bridge = FindObjectOfType<CoherenceBridge>();
        sendMessage.onClick.AddListener(() =>
        {
            SendText();   
        chatInput.text = string.Empty;
        });
    }

    public void SendChatMessage(byte[] encodedMessage)
    {
        string decodedMessage = Encoding.UTF8.GetString(encodedMessage);
        ChatMessage message = Instantiate(chatMessagePrefab, chatContent.transform);
        message.SetText(decodedMessage);

    }
   
    void AddMessage(string msg)
    {
        ChatMessage message = Instantiate(chatMessagePrefab, chatContent.transform);
        message.SetText(msg); // just sets the text of the prefab
    }


    public void SendText()
    {
        if (chatInput.text != string.Empty)
        {
            string message = playerName + " :    " + chatInput.text;
            if (message != string.Empty)
            {
                byte[] encodedMessage = Encoding.UTF8.GetBytes(message);
                CoherenceClientConnection myConnection = bridge.ClientConnections.GetMine();
                myConnection.SendClientMessage<ChatManager>(nameof(SendChatMessage), MessageTarget.Other, encodedMessage);
            }
        }
    }

}
