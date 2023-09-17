<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonCharCont : MonoBehaviour
{
    public static int lives = 3;
    Scene current;
    bool isMoving;
    Animator animator;
    public float moveSpeed = 1.7f;
    Vector2 input;
    public LayerMask solidObject;
    public Vector2 targetPos;
    public bool canFire = true;
    

    

    
    [SerializeField] GameObject ghost;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject fireball;
    [SerializeField] GameObject reward;
    
    



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
       

        
        if (input != Vector2.zero)
        {
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
        }



        targetPos = transform.position;
        targetPos.x += input.x;
        targetPos.y += input.y;

        Vector2 a = transform.position;

        if (targetPos != a)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);


        Vector2 b = targetPos;
        if (input.x != 0)
        {
            b.y = b.y - 0.5f;
        }
        if (input.y != 0)
        {
            b.x = b.x - 0.5f;
        }


        if (isWalkable(b))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }


        

        if(canFire)
        {
            Instantiate(sphere, fireball.transform);
            canFire = false;
            Invoke("Reload", 0.9f);
        }

        if(Sphere.kills>=100)
        {
            reward.SetActive(true);
        }

    }
    public bool isWalkable(Vector2 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, 0.00001f, solidObject))
        {

            return false;
        }
        return true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(collision.gameObject.CompareTag("Canavar"))
        {
            lives--;
            Destroy(collision.gameObject);
        }
    }

    public void Reload()
    {
        
        canFire = true;
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonCharCont : MonoBehaviour
{
    public static int lives = 3;
    Scene current;
    bool isMoving;
    Animator animator;
    public float moveSpeed = 1.7f;
    Vector2 input;
    public LayerMask solidObject;
    public Vector2 targetPos;
    public bool canFire = true;
    

    

    
    [SerializeField] GameObject ghost;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject fireball;
    [SerializeField] GameObject reward;
    
    



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
       

        
        if (input != Vector2.zero)
        {
            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
        }



        targetPos = transform.position;
        targetPos.x += input.x;
        targetPos.y += input.y;

        Vector2 a = transform.position;

        if (targetPos != a)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        animator.SetBool("isMoving", isMoving);


        Vector2 b = targetPos;
        if (input.x != 0)
        {
            b.y = b.y - 0.5f;
        }
        if (input.y != 0)
        {
            b.x = b.x - 0.5f;
        }


        if (isWalkable(b))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }


        

        if(canFire)
        {
            Instantiate(sphere, fireball.transform);
            canFire = false;
            Invoke("Reload", 0.9f);
        }

        if(Sphere.kills>=100)
        {
            reward.SetActive(true);
        }

    }
    public bool isWalkable(Vector2 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, 0.00001f, solidObject))
        {

            return false;
        }
        return true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(collision.gameObject.CompareTag("Canavar"))
        {
            lives--;
            Destroy(collision.gameObject);
        }
    }

    public void Reload()
    {
        
        canFire = true;
    }
}
>>>>>>> eee12b2a48c24727a95310de0547e18a6881e202
