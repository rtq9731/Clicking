using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using UnityEngine;
using DG.Tweening;
using System.Security.Claims;

public class Player : MonoBehaviour
{

    public UnityEngine.Vector2 limitMin = UnityEngine.Vector2.zero;
    public UnityEngine.Vector2 limitMax = UnityEngine.Vector2.zero;

    Vector2 currentPositon = Vector3.zero;
    Rigidbody2D rigid = null;
    float timer = 0f;
    bool canJump = true;

    Vector2 currentPos = Vector3.zero;
    float currentPosX = 0;
    float currentPosY = 0;

    [SerializeField]
    float jumpPower = 0;
    [SerializeField]
    float jumpCoolTime = 0;
    [SerializeField]
    float moveTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.localPosition;
        timer += Time.deltaTime;
        if (timer >= jumpCoolTime)
            canJump = true;
        StartCoroutine(clamp());
        if (canJump && Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(jump());
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.DOMoveX(currentPos.x + 0.8f, moveTime).SetEase(Ease.OutQuad);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.DOMoveX(currentPos.x - 0.8f, moveTime);
        }

    }

    IEnumerator jump()
    {
        transform.DOLocalJump(new Vector3(currentPos.x, 0f, 0f), jumpPower, 1, 0.5f);
        timer = 0f;
        canJump = false;
        yield return 0;
    }

    IEnumerator clamp()
    {
        currentPosX = Mathf.Clamp(currentPos.x, limitMin.x, limitMax.x);

        currentPosY = Mathf.Clamp(currentPos.y, limitMin.y, limitMax.y);

        currentPos = new Vector2(currentPosX, currentPosY);
        transform.localPosition = currentPos;

        yield return 0;
    }
}
