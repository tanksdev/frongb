using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FrogSpawningMechanic : MonoBehaviour
{
    //GameObject[] dangerFrogSpawnArea;
    //GameObject[] safeFrogSpawnArea;
    GameObject[] Badspawners;
    GameObject[] Goodspawners;
    GameObject[] Spawners;
    public GameObject safeFrog;
    public GameObject dangerousFrog;
    public List<GameObject> goodSpawnpoint = new List<GameObject>();
    public List<GameObject> badSpawnpoint = new List<GameObject>();
    //public bool dangerousFrog;
    //public bool safeFrog;
//at line 33 trying to instantiate my frogs but it does not like it
    // Start is called before the first frame update
    void Start()
    {
        Goodspawners = GameObject.FindGameObjectsWithTag("spawnpointGood");
        for(int i = 0; i < Goodspawners.Length; i++)
        {
            goodSpawnpoint.Add(Goodspawners[i]);
        }
        Badspawners = GameObject.FindGameObjectsWithTag("spawnpointBad");
        for(int i = 0; i < Badspawners.Length; i++)
        {
            badSpawnpoint.Add(Badspawners[i]);
        }
        //Frog = GameObject.FindGameObjectsWithTag("Frog");
        StartCoroutine(Generate());
    }
      void SpawnGoodFrogs()
    {
        for(int i = 0; i < goodSpawnpoint.Count; i++)
        {
            Instantiate(safeFrog, goodSpawnpoint[i].transform);
        }
    }
    void RemoveGoodFrogs()
    {
        for(int i = goodSpawnpoint.Count - 1; i >= 0; i--)
        {
            bool coinFlip = (Random.Range(0, 2) == 0);
            if(coinFlip == true)
            {
                goodSpawnpoint.RemoveAt(i);
            }
        }
    }
    void SpawnBadFrogs()
    {
        for(int i = 0; i < badSpawnpoint.Count; i++)
        {
            Instantiate(dangerousFrog, badSpawnpoint[i].transform);
        }
    }
    void RemoveBadFrogs()
    {
        for(int i = badSpawnpoint.Count - 1; i >= 0; i--)
        {
            bool coinFlip = (Random.Range(0, 2) == 0);
            if(coinFlip == true)
            {
                badSpawnpoint.RemoveAt(i);
            }
        }
    }
    IEnumerator Generate()
    {
        yield return new WaitForSeconds(1);
        RemoveGoodFrogs();
        yield return new WaitForSeconds(1);
        SpawnGoodFrogs();
        yield return new WaitForSeconds(1);
        SpawnBadFrogs();
        yield return new WaitForSeconds(1);
        RemoveBadFrogs();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
    // Update is called once per frame
}
