using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text text = null;
    void Start()
    {
        text.DOText("걸린시간" + ScoreText.time.ToString("N2"), 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
