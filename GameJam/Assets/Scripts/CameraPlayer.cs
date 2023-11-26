using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    // components and gameobjects
    static GameObject player;
    public GameObject playerRotation;

    // variables
    [SerializeField] float heightOffset = 0.75f;

    void Start()
    {
        player = GameManager.player;
        playerRotation = GameManager.playerRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = playerRotation.transform.rotation;
        transform.position = player.transform.position;
        transform.position += Vector3.up * heightOffset;
    }
}
