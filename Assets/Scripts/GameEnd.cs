using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Data;

public class GameEnd : MonoBehaviour
{
    SpriteRenderer mr = null;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<SpriteRenderer>();
        mr.DOColor(Color.cyan, 20).SetLoops(-1,LoopType.Yoyo); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
