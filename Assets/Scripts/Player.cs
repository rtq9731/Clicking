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
    float timer = 0f;
    bool canJump = true;

    [SerializeField]
    float jumpPower = 0;
    [SerializeField]
    float jumpCoolTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= jumpCoolTime)
            canJump = true;
        if (canJump && Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(jump());
        }
        
    }

    IEnumerator jump()
    {
        transform.DOLocalJump(new Vector3(0f, 0f, 0f), jumpPower, 1, 0.2f);
        timer = 0f;
        canJump = false;
        yield return 0;
    }


}
