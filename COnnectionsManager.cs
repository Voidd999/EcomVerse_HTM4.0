using System.Collections.Generic;
using Coherence.Connection;
using Coherence.Toolkit;
using UnityEngine;
public class COnnectionsManager : MonoBehaviour
{
    public CoherenceBridge Bridge;

    void Start()
    {
        // Raised whenever a new connection is made (including the local one).
        Bridge.ClientConnections.OnCreated += connection =>
        {
            Debug.Log($"Connection #{connection.ClientId} " +
                      $"of type {connection.Type} created.");
        };

        // Raised whenever a connection is destroyed.
        Bridge.ClientConnections.OnDestroyed += connection =>
        {
            Debug.Log($"Connection #{connection.ClientId} " +
                      $"of type {connection.Type} destroyed.");
        };

        // Raised when all initial connections have been synced.
        Bridge.ClientConnections.OnSynced += connectionManager =>
        {
            Debug.Log($"ClientConnections are now ready to be used.");
        };
    }

    //void Update()
    //{
    //    // IMPORTANT: All of the connection retrieving calls may return null 
    //    // if the connection system was not turned on, not initialized yet,
    //    // or simply if the connection was not found.

    //    // Specifies how many clients are in this session (room or world).
    //    int clientCount = Bridge.ClientConnections.ClientConnectionCount;

    //    // Returns connection objects for all connections in this session.
    //    IEnumerable<CoherenceClientConnection> allConnections
    //        = Bridge.ClientConnections.GetAll();

    //    // Returns all connections except for the local one.
    //    IEnumerable<CoherenceClientConnection> otherConnections
    //        = Bridge.ClientConnections.GetOther();

    //    // Returns connection object of the local user.
    //    CoherenceClientConnection myConnection
    //        = Bridge.ClientConnections.GetMine();

    //    // Returns connection object of the simulator (if one is connected).
    //    CoherenceClientConnection simulatorConnection
    //        = Bridge.ClientConnections.GetSimulator();

    //    // Retrieves a connection by its ClientID.
    //    CoherenceClientConnection selectedConnection
    //        = Bridge.ClientConnections.Get(myConnection.ClientId);

    //    // Retrieves a connection by its EntityID (warning: requires
    //    // connection prefab with a CoherenceSync attached).
    //    if (myConnection.Sync != null)
    //    {
    //        selectedConnection
    //            = Bridge.ClientConnections.Get(myConnection.Sync.EntityID);
    //    }

    //    // Specifies if this is a client or a simulator connection.
    //    ConnectionType connectionType = selectedConnection.Type;

    //    // Specifies if this is a local connection (belonging to the
    //    // local user).
    //    bool isMine = selectedConnection.IsMyConnection;

    //    // Returns a GameObject associated with this connection.
    //    // Applicable only if connection prefabs are used.
    //    GameObject connectionGameObject = selectedConnection.GameObject;
    //}
}
