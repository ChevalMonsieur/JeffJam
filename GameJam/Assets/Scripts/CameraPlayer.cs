using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    // components and gameobjects
    static GameObject player;

    void Start()
    {
        player = GameManager.player;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
