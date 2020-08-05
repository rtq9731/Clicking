using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    
    public int nScore = 0;
    public Transform[] notePoss = null;
    public GameObject[] colorButtons = null;
    public float time = 0;
    private void Start()
    {
        time = Time.deltaTime;
    }
}
