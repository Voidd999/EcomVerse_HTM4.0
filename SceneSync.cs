using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Coherence.Toolkit;
public class SceneSync : MonoBehaviour
{
    public CoherenceBridge bridge;
    public CoherenceLiveQuery query;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        // Move the bridge to DontDestroyOnLoad but still
        // instantiate into the active scene
        var scene = bridge.gameObject.scene;
        DontDestroyOnLoad(bridge);
        bridge.InstantiationScene = scene;

        // Make the query find the bridge
        query.BridgeResolve += _ => bridge;

        // Make new CoherenceSync:s find the bridge
        CoherenceSync.BridgeResolve += _ => bridge;

        // Get notified if the scene is changed
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Moves the client connection to another scene on the server
        bridge.SceneManager.SetClientScene(scene.buildIndex);

        // Instantiate remote entities into the new scene instead
        bridge.InstantiationScene = scene;
    }
}
