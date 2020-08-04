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

    private float noteDelay;

    private float time;
    private float noteNum;

    private GameObject[] colorButtons;
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
        noteNum = UnityEngine.Random.Range(1f, 7f);
    }

    private IEnumerator MakeNote()
    {
        yield return new WaitForSeconds(noteDelay);
    }

    private IEnumerator startSpawn()
    {
        for (int i = 0; i < 6; i++)
        Instantiate(colorButtons[i], gameObject.transform );
        yield return new WaitForSeconds(noteDelay);
    }

}
