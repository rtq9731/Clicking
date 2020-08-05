using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Unity.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class Note : MonoBehaviour
{
    private GameManager gameManager = null;
    private PoolManager poolManager = null;
    private float time;
    private float noteDelay;
    private float noteCooldown;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        poolManager = FindObjectOfType<PoolManager>();
        time = Time.deltaTime;
        StartCoroutine(imInWork()); 
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator imInWork()
    {
        gameObject.SetActive(true);
        noteDelay = UnityEngine.Random.Range(1f, 5f);
        if (Input.GetMouseButtonDown(0) == true)
        {
            gameManager.nScore += 30;
            gameObject.SetActive(false);    
        }

        yield return new WaitForSeconds(noteDelay);
    }

}
