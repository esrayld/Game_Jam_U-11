using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SpawnSol : MonoBehaviour
{
    [SerializeField] GameObject ghost;
    bool canSpawn = true;
    bool end = true;
    [SerializeField] TMP_Text tmp;

    [SerializeField] GameObject image1;
    [SerializeField] GameObject image2;
    [SerializeField] GameObject image3;


   



    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {

        if (canSpawn&&end)
        {
            float time = Random.RandomRange(4.5f, 9f);
            Instantiate(ghost, transform);
            canSpawn = false;
            Invoke("canSpawnM", time);
        }

        tmp.text = Sphere.kills.ToString();
          

        if(DungeonCharCont.lives==3)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
        }
        if(DungeonCharCont.lives==2)
        {
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(false);
        }
        if(DungeonCharCont.lives==1)
        {
            image1.SetActive(true);
            image2.SetActive(false);
            image3.SetActive(false);
        }

        if (DungeonCharCont.lives == 0)
        {
            DungeonCharCont.lives = 3;
            Sphere.kills = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);           
        }

        if(Sphere.kills>=100)
        {
           KasabaCharCont.level1 = true;
            Destroy(gameObject);
        }






      
    }


    public void canSpawnM()
    {
        canSpawn = true;
    }
}
