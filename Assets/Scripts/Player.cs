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

    Animator animator = null;

    [SerializeField]
    float jumpPower = 0;
    [SerializeField]
    float jumpCoolTime = 0;
    [SerializeField]
    float moveTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.Play("Player_Idel");
        currentPos = transform.localPosition;
        timer += Time.deltaTime;
        if (timer >= jumpCoolTime)
            canJump = true;
        StartCoroutine(clamp());
        if (canJump && Input.GetKey(KeyCode.Space)) // 쿨타임이 다 찼을 때 점프가 가능하게 해줌
        {
            StartCoroutine(jump());
            currentPos = transform.localPosition;
        }

        if(Input.GetKey(KeyCode.D)) // 키 입력 받으면 오른쪽으로 움직임
        {
            transform.DOMoveX(currentPos.x + 0.8f, moveTime).SetEase(Ease.OutQuad);
            currentPos = transform.localPosition;
        }

        if (Input.GetKey(KeyCode.A)) // 키 입력 받으면 왼쪽으로 움직임
        {
            transform.DOMoveX(currentPos.x - 0.8f, moveTime);
            currentPos = transform.localPosition;
        }

    }

    IEnumerator jump() // 점프하는 코루틴
    {
        transform.DOLocalJump(new Vector3(currentPos.x, -4.61f, 0f), jumpPower, 1, 0.5f);
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
