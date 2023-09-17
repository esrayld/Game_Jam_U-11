<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İksir : MonoBehaviour
{
    AudioSource AS;

    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AS.Play();
            controllerDeneme.speed = 2.26f;
            Invoke("ReturnNormal", 2f);
            Destroy(gameObject);
        }
    }

   public void ReturnNormal()
    {
        controllerDeneme.speed = 2.05f;
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İksir : MonoBehaviour
{
    AudioSource AS;

    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AS.Play();
            controllerDeneme.speed = 2.26f;
            Invoke("ReturnNormal", 2f);
            Destroy(gameObject);
        }
    }

   public void ReturnNormal()
    {
        controllerDeneme.speed = 2.05f;
    }
}
>>>>>>> eee12b2a48c24727a95310de0547e18a6881e202
