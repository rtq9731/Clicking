﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Unity.Collections;
using UnityEngine;
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
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        poolManager = FindObjectOfType<PoolManager>();  
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        noteDelay = UnityEngine.Random.Range(1f, 20f);
    }

    private IEnumerator imInWork()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            
        }

        yield return new WaitForSeconds(noteDelay);
    }

}
