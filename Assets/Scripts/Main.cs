using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class Main : MonoBehaviour
{
    Note note = null;
    // Start is called before the first frame update
    void Start()
    {
        note = FindObjectOfType<Note>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Click()
    {
        SceneManager.LoadScene ("Main");
    }
}
