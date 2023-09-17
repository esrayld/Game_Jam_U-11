using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    GameObject player;
    
    public float moveSpeed=4.15f;
    Vector2 targetPos;
    
    void Start()
    {
        player = GameObject.Find("Character");
    }

    
    void Update()
    {
        targetPos = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        
    }
}
