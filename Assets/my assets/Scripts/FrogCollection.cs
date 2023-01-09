using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrogCollection : MonoBehaviour
{
    public GameObject safeFrog;
    public GameObject Player;
    public GameObject UIManager;
    public int gameScore;
    /*public GameObject PlayerPickUp()
    {
        GameObject[] ppu;
        ppu = GameObject.FindGameObjectsWithTag("Frog");
        if(other.gameObject.CompareTag("Frog"));
        Destroy(gameObject);
    }*/
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Frog");
        {
            //gameScore += 1;
            Debug.Log("Picked up a Frog");
            scoreUpdate();
            Destroy(other.gameObject);
        }
    }
    public void scoreUpdate()
    {
        /*GameObject objectWithScript;
        objectWithScript.refScript;
        UIManager refScript = GetComponent<UIManager>();*/
        UIManager = GameObject.FindGameObjectWithTag("Manager");
        gameScore++;
        UIManager.GetComponent<UIManager>().updateScoreDisplay(gameScore);
    }
    void Update()
    {
        if(gameScore == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
