<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int count=0;
    AudioSource AS;
    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            AS.Play();
            count++;
            Destroy(other.gameObject);           
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int count=0;
    AudioSource AS;
    private void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            AS.Play();
            count++;
            Destroy(other.gameObject);           
        }
    }
}
>>>>>>> eee12b2a48c24727a95310de0547e18a6881e202
