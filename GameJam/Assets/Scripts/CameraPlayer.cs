using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    // components and gameobjects
    static GameObject player;
    public GameObject playerRotation;

    void Start()
    {
        player = GameManager.player;
        playerRotation = GameManager.playerRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.rotation = playerRotation.transform.rotation;
    }
}
