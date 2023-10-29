using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Services.Core;
//using Unity.Services.Relay;
//using Unity.Services.Relay.Models;
//using Unity.Services.Authentication;
//using Unity.Netcode;
//using Unity.Netcode.Transports.UTP;
//using Unity.Networking.Transport.Relay;
//using Unity.Networking.Transport;
using TMPro;
using UnityEngine.UI;
public class TestRelay : MonoBehaviour
{

    public TextMeshProUGUI joinLobbyCode;
    public GameObject buttons;
    public Button createButton;
    public Button joinButton;
    public TMP_InputField inputField;
    // Start is called before the first frame update
    //public async void Auth()
    //{
    //    await UnityServices.InitializeAsync();

    //    AuthenticationService.Instance.SignedIn += () => { 
    //        Debug.Log("signed in as : " + AuthenticationService.Instance.PlayerId);

    //        createButton.onClick.AddListener(CreateRelay);
    //        joinButton.onClick.AddListener(() => JoinRelay(inputField.text));

    //        NetworkManager.Singleton.LogLevel = LogLevel.Developer;
    //        NetworkManager.Singleton.NetworkConfig.EnableNetworkLogs = true;
    //    };

    //    await AuthenticationService.Instance.SignInAnonymouslyAsync();

    //}
    //public async void CreateRelay()
    //{
    //    try
    //    {
    //         Allocation hostAllocation = await RelayService.Instance.CreateAllocationAsync(5, "asia-south1");

    //        string joinCode = await RelayService.Instance.GetJoinCodeAsync(hostAllocation.AllocationId);
    //        joinLobbyCode.text = joinCode;
    //        //Debug.Log(joinCode);

    //        RelayServerData relayServerData = new RelayServerData(hostAllocation, "dtls");

    //        NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);

    //        NetworkManager.Singleton.StartHost();

    //        buttons.SetActive(false);

    //    }
    //    catch(RelayServiceException e) { Debug.Log(e); }


    //}

    //public async void JoinRelay(string joinCode)
    //{
    //    try {
    //        //await RelayService.Instance.JoinAllocationAsync(joinCode);

    //        JoinAllocation clientAllocation = await RelayService.Instance.JoinAllocationAsync(joinCode);

    //        RelayServerData relayServerData = new RelayServerData(clientAllocation, "dtls");

    //        NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);

    //        NetworkManager.Singleton.StartClient();
    //        joinLobbyCode.text = joinCode;
    //        buttons.SetActive(false);

    //    }
    //    catch(RelayServiceException e) { Debug.Log(e); }
    //}

    //private void OnEnable()
    //{
    //    //NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
    //    //NetworkManager.Singleton.OnClientDisconnectCallback += OnClientDisonnected;

       
    //}

    ////private void OnDisable()
    ////{
    ////    NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
    ////    NetworkManager.Singleton.OnClientDisconnectCallback += OnClientDisonnected;
    ////}
    //private void OnClientConnected(ulong data) {
    //    Debug.Log($"Client Connected: {data}");
    //}
    //private void OnClientDisonnected(ulong data)
    //{
    //    if(NetworkManager.Singleton.LocalClientId == data)
    //    {
    //        Debug.Log("Not Connected");
    //        NetworkManager.Singleton.Shutdown();
    //        Debug.Log("Shut Down NW Manager");

    //    }
    //}

    //private void Update()
    //{
    //    if (NetworkManager.Singleton.ShutdownInProgress)
    //    {

    //    }
    //}



}
