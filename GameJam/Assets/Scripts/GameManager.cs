using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // components and gameobjects
    public static GameObject player;
    public static GameObject playerRotation;
    public static GameObject cameraPlayer;

    void Start()
    {
        // adding objects that we need to get info of
        player = GameObject.Find("Player");
        playerRotation = GameObject.Find("PlayerRotation");
        cameraPlayer = GameObject.Find("Main Camera");

        // makes the mouse invisible and locks it in the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }
}
