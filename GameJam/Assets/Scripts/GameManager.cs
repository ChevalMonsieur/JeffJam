using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // components and gameobjects
    public static GameObject player;
    public static GameObject cameraPlayer;

    void Start()
    {
        player = GameObject.Find("Player");
        cameraPlayer = GameObject.Find("Main Camera");
    }
}
