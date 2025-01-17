    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject SelectedCharacter;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        
    }
}
