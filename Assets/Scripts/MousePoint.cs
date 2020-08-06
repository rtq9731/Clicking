using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector2 targetPosition = Vector2.zero;
    public Vector2 myPosition = Vector2.zero;

    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        myPosition = transform.position;
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector2(targetPosition.x, targetPosition.y);
    }
}
