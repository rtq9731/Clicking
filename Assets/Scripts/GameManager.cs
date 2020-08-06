using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    public int nScore = 0;
    public Transform[] notePoss = null;
    public GameObject[] colorButtons = null;
    public float time = 0;
    private Note gameEnd = null;
    public int noteFalse = 0;
    private void Start()
    {
        gameEnd = FindObjectOfType<Note>();
        time = Time.deltaTime;
    }

    private void Update()
    {
        if(noteFalse == 16)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
