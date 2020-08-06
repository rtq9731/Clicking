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
    private float distance = 0f;

    [SerializeField]
    protected float collideDistance = 0.1f;

    private GameObject target;
    private MousePoint mousePointer = null;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        poolManager = FindObjectOfType<PoolManager>();
        mousePointer = FindObjectOfType<MousePoint>();
        time = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(imInWork());
        distance = Vector2.Distance(transform.position, mousePointer.myPosition);

        if ( distance <= collideDistance)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ++gameManager.noteFalse;
                Debug.Log(gameManager.noteFalse);
                Debug.Log("버튼 눌림");
                gameObject.SetActive(false);
            }
        }

    }
    private IEnumerator imInWork()
    {
        noteDelay = UnityEngine.Random.Range(1f, 5f);
        gameObject.SetActive(true);
        yield return new WaitForSeconds(noteDelay);
    }

}
