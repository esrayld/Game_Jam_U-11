using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    GameObject enemy;

     public float moveSpeed = 4.15f;
     Vector2 targetPos;

      void Start()
      {
        enemy = GameObject.Find("Player");
      }


      void Update()
      {
        targetPos = enemy.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);


      }
    
}
