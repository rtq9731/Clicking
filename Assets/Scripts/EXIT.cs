using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXIT : MonoBehaviour
{
    Note note = null;
    // Start is called before the first frame update
    void Start()
    {
        note = FindObjectOfType<Note>();
    }

    // Update is called once per frame
    public void Click()
    {
        Application.Quit();
    }
}
