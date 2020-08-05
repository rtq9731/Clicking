using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class NoteIsHere : MonoBehaviour
{

    private GameManager gameManager = null;
    private PoolManager poolManager = null;
    private GameObject[] colorButtons;
    
    private float time;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        poolManager = FindObjectOfType<PoolManager>();
        colorButtons = gameManager.colorButtons;

        StartCoroutine(startSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;
    }

    private IEnumerator startSpawn()
    {
        for(int i = 0; i < 1; i++)
        Instantiate(colorButtons[i], gameObject.transform );
        yield return 0;
    }

}
