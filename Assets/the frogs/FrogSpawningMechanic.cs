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
    public List<GameObject> Spawnpoint = new List<GameObject>();
    //public bool dangerousFrog;
    //public bool safeFrog;
//at line 33 trying to instantiate my frogs but it does not like it

    // Start is called before the first frame update
    void Start()
    {
        Goodspawners = GameObject.FindGameObjectsWithTag("spawnpointGood");
        for(int i = 0; i < Goodspawners.Length; i++)
        {
            Spawnpoint.Add(Goodspawners[i]);
        }
        //Frog = GameObject.FindGameObjectsWithTag("Frog");

        StartCoroutine(Generate());
    }
      void SpawnGoodFrogs()
    {
        for(int i = 0; i < Spawnpoint.Count; i++)
        {
            Instantiate(safeFrog, Spawnpoint[i].transform);
        }
    }
    void RemoveFrogs()
    {
        for(int i = Spawnpoint.Count - 1; i >= 0; i--)
        {
            bool coinFlip = (Random.Range(0, 2) == 0);
            if(coinFlip == true){
                Spawnpoint.RemoveAt(i);
            }
        }
    }
    IEnumerator Generate()
    {
        yield return new WaitForSeconds(1);
        RemoveFrogs();
        yield return new WaitForSeconds(1);
        SpawnGoodFrogs();
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
