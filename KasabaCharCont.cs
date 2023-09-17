<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KasabaCharCont : MonoBehaviour
{
    Scene current;
    bool isMoving;
    Animator animator;
    public float moveSpeed = 1.7f;
    Vector2 input;
    public LayerMask solidObject;
    public float radius =0.001f;
    public static bool level1 = false;
    [SerializeField] GameObject npc;
    [SerializeField] GameObject dialogue;
    [SerializeField] GameObject tutorial;
    [SerializeField] GameObject level11;

    
    
    
    void Start()
    {
        current = SceneManager.GetActiveScene();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");


        if (input.x != 0)
        {
            input.y = 0;
        }
            if(input!=Vector2.zero)
        {
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
        }
            
            

            Vector2 targetPos = transform.position;
            targetPos.x += input.x;
            targetPos.y += input.y;

            Vector2 a = transform.position;
            if(targetPos!=a)
        {
            isMoving = true;
        }
            else
        {
            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);


        Vector2 b = targetPos;
        if(input.x!=0)
        {
            b.y =b.y- 0.5f;
        }
        if(input.y!=0)
        {
            b.x = b.x-0.5f;
        }


        if (isWalkable(b))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }

        
        
            
            if ( Input.GetKey(KeyCode.Z)&&Mathf.Abs(Mathf.Abs(npc.transform.position.x) - Mathf.Abs(transform.position.x)) < Mathf.Abs(0.8f) && Mathf.Abs(Mathf.Abs(npc.transform.position.y) - Mathf.Abs(transform.position.y)) < Mathf.Abs(0.8f))
            {               
                dialogue.SetActive(true);
                tutorial.SetActive(false);
            }
            if(Input.GetKey(KeyCode.X) && Mathf.Abs(Mathf.Abs(npc.transform.position.x) - Mathf.Abs(transform.position.x)) < Mathf.Abs(0.8f) && Mathf.Abs(Mathf.Abs(npc.transform.position.y) - Mathf.Abs(transform.position.y)) < Mathf.Abs(0.8f))
            {
                dialogue.SetActive(false);
            }
                    
                    
        
            if(level1)
            {
            Destroy(level11);
            }
       
                        
        
            
            
           
    }
    public bool isWalkable(Vector2 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos,radius,solidObject))
        {
            
            return false;
        }
        return true;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obje"))
        {
            isWalkable = false;
        }
        else
        {
            isWalkable = true;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KasabaCharCont : MonoBehaviour
{
    Scene current;
    bool isMoving;
    Animator animator;
    public float moveSpeed = 1.7f;
    Vector2 input;
    public LayerMask solidObject;
    public float radius =0.001f;
    public static bool level1 = false;
    [SerializeField] GameObject npc;
    [SerializeField] GameObject dialogue;
    [SerializeField] GameObject tutorial;
    [SerializeField] GameObject level11;

    
    
    
    void Start()
    {
        current = SceneManager.GetActiveScene();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");


        if (input.x != 0)
        {
            input.y = 0;
        }
            if(input!=Vector2.zero)
        {
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
        }
            
            

            Vector2 targetPos = transform.position;
            targetPos.x += input.x;
            targetPos.y += input.y;

            Vector2 a = transform.position;
            if(targetPos!=a)
        {
            isMoving = true;
        }
            else
        {
            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);


        Vector2 b = targetPos;
        if(input.x!=0)
        {
            b.y =b.y- 0.5f;
        }
        if(input.y!=0)
        {
            b.x = b.x-0.5f;
        }


        if (isWalkable(b))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }

        
        
            
            if ( Input.GetKey(KeyCode.Z)&&Mathf.Abs(Mathf.Abs(npc.transform.position.x) - Mathf.Abs(transform.position.x)) < Mathf.Abs(0.8f) && Mathf.Abs(Mathf.Abs(npc.transform.position.y) - Mathf.Abs(transform.position.y)) < Mathf.Abs(0.8f))
            {               
                dialogue.SetActive(true);
                tutorial.SetActive(false);
            }
            if(Input.GetKey(KeyCode.X) && Mathf.Abs(Mathf.Abs(npc.transform.position.x) - Mathf.Abs(transform.position.x)) < Mathf.Abs(0.8f) && Mathf.Abs(Mathf.Abs(npc.transform.position.y) - Mathf.Abs(transform.position.y)) < Mathf.Abs(0.8f))
            {
                dialogue.SetActive(false);
            }
                    
                    
        
            if(level1)
            {
            Destroy(level11);
            }
       
                        
        
            
            
           
    }
    public bool isWalkable(Vector2 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos,radius,solidObject))
        {
            
            return false;
        }
        return true;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obje"))
        {
            isWalkable = false;
        }
        else
        {
            isWalkable = true;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
>>>>>>> eee12b2a48c24727a95310de0547e18a6881e202
}