using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public InputManager inputManager;
    public CameraManager cameraManager;
    public PlayerLocomotion playerLocomotion;

    public Button button;
    public Transform theatreSpawn;
    public Transform appleSpawn;
    public Transform adsSpawn;
    public Transform nikeSpawn;
    public Transform cafeSpawn;
    public Transform lobbySpawn;

    public void Teleport(Transform spawn) 
    {
        transform.position = spawn.position;
    }
    private void Start()
    {
        // button = GameObject.Find("tesstButton").GetComponent<Button>();
        // spawn = GameObject.Find("spawntest").transform;
        theatreSpawn = GameObject.Find("theatreSpawn").transform;
        appleSpawn = GameObject.Find("appleSpawn").transform;
        adsSpawn = GameObject.Find("adsSpawn").transform;
        nikeSpawn = GameObject.Find("nikeSpawn").transform;
        cafeSpawn = GameObject.Find("cafeSpawn").transform;
        lobbySpawn = GameObject.Find("lobbySpawn").transform;

        cameraManager = FindObjectOfType<CameraManager>();
        
        playerLocomotion = GetComponent<PlayerLocomotion>();

        inputManager = GetComponent<InputManager>();
       
        playerLocomotion.cameraObject = cameraManager.cameraTransform;

        cameraManager.inputManager = inputManager;
         
        cameraManager.targetTransform = transform;
    }


    private void Update()
    {
        Application.targetFrameRate = 70;
       
        
        inputManager.HandleAllInputs();
        
    }
    private void FixedUpdate()
    {
       playerLocomotion.HandleAllMovement();
        
    }

    private void LateUpdate()
    {
    
    cameraManager.HandleAllCameraMovement();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Spawntrigger-theatre"))
        {
            Teleport(theatreSpawn);
        }
        else if (other.CompareTag("Spawntrigger-apple"))
        {
            Teleport(appleSpawn);
        }
        else if (other.CompareTag("Spawntrigger-nike"))
        {
            Teleport(nikeSpawn);
        }
        else if (other.CompareTag("Spawntrigger-ads"))
        {
            Teleport(adsSpawn);
        }
        else if (other.CompareTag("Spawntrigger-cafe"))
        {
            Teleport(cafeSpawn);
        }
        else if (other.CompareTag("Spawntrigger-lobby"))
        {
            Teleport(lobbySpawn);
        }
    }




}
