using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Start : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        SceneManager.LoadScene(0);
    }
}