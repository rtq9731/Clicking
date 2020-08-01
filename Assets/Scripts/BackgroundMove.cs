using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class BackgroundMove : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float moveTime = 0;
    [SerializeField]
    private float moveRadius = 0;

    private float time = Time.deltaTime;
    private Vector2 myPotision = Vector2.zero;

    void Start()
    {
        myPotision = transform.localPosition;

        transform.DOMoveY(myPotision.y + moveRadius, moveTime).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
