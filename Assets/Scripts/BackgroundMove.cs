using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class BackgroundMove : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    float moveTime = 0;

    float time = Time.deltaTime;
    Transform myPotision = null;

    void Start()
    {
        myPotision = GetComponent<Transform>();
        transform.DOMoveY(myPotision.x)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
