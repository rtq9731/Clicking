using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text scoreText = null;
    private float time;

    void Start()
    {
        time += Time.deltaTime;
        scoreText.text = string.Format("{0:N2}", time);


    }

    // Update is called once per frame
    void Update()
    { 
    }
}
