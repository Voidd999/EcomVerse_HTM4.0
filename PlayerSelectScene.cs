using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectScene : MonoBehaviour
{
    public GameObject playerSelectUI;
    public GameObject roomSelectUI;
    void Start()
    {
        playerSelectUI.SetActive(true);
        roomSelectUI.SetActive(false);
    }

    public void Next() 
    {
        playerSelectUI.SetActive(false);
        roomSelectUI.SetActive(true);
    }

}
