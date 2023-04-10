using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    AudioSource AS;
    Rigidbody2D rd2;
    int count = 0;
    static public int kills;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
        rd2 = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
                   
            if(count==0)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rd2.velocity = new Vector2(0, 20f);
                    count++; ;
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rd2.velocity = new Vector2(0, -20f);
                count++;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    rd2.velocity = new Vector2(20f, 0);
                count++;
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rd2.velocity = new Vector2(-20f, 0);
                count++;
                }
            if (Input.GetKey(KeyCode.LeftArrow)&& Input.GetKey(KeyCode.UpArrow))
            {
                rd2.velocity = new Vector2(-20f, 20f);
                count++;
            }
            if (Input.GetKey(KeyCode.LeftArrow)&& Input.GetKey(KeyCode.DownArrow))
            {
                rd2.velocity = new Vector2(-20f, -20f);
                count++;
            }
            if (Input.GetKey(KeyCode.RightArrow)&& Input.GetKey(KeyCode.UpArrow))
            {
                rd2.velocity = new Vector2(20f,20f );
                count++;
            }
            if (Input.GetKey(KeyCode.RightArrow)&& Input.GetKey(KeyCode.DownArrow))
            {
                rd2.velocity = new Vector2(20f, -20f);
                count++;
            }

        }

        Invoke("Destroyer", 4.4f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Canavar"))
        {
            AS.Play();
            Destroy(collision.gameObject);
            kills++;
            Debug.Log(kills);                     
        }
    }
    public void Destroyer()
    {
        Destroy(gameObject);
    }
}
