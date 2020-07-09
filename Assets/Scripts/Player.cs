using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{

    Vector3 currentPositon = Vector3.zero;
    Rigidbody2D rigid = null;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.DOLocalJump(new Vector3(0f, 0.3f, 0f), 1f, 1, 0.2f);
        }
    }
}
