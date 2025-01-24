using Fusion;
using UnityEngine;

public class arrownetwork : MonoBehaviour
{
    public NetworkRunner runner;
    public GameObject arrow;

    async void Start()
    {
        
        runner = gameObject.AddComponent<NetworkRunner>();
        await runner.StartGame(new StartGameArgs()
        {
            GameMode = GameMode.Host
        });

        
        runner.Spawn(arrow, Vector3.zero, Quaternion.identity);
    }
}
