using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replayButton : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
