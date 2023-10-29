using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class NetworkChat : MonoBehaviour
{
    public ChatMessage chatMessagePrefab;
    [SerializeField] CanvasGroup chatContent;
    [SerializeField] TMP_InputField chatInput;
    [SerializeField] public InputField playerNameInput;
    [SerializeField] Button sendMessage;
    
    //public string playerName;

    private void Start()
    {
        //chatContent = GameObject.Find("Chat Content").GetComponent<CanvasGroup>();
        //chatInput = GameObject.Find("Chat Input (Input Field)").GetComponent<TMP_InputField>();
        //playerInput = GameObject.Find("Player Input").GetComponent<TMP_InputField>();
        //sendMessage = GameObject.Find("SendMessage").GetComponent<Button>();
       
        sendMessage.onClick.AddListener(() =>
        {
            ChatMessage message = Instantiate(chatMessagePrefab, chatContent.transform);
            message.SetText(playerNameInput.text + " > " + chatInput.text);
            //chatInput.text = null;
        });
    }

}
