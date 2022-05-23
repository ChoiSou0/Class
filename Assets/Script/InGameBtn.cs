using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameBtn : MonoBehaviour
{
    public Transform B;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnB()
    {
        B.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void ExitB()
    {
        B.transform.localScale = new Vector3(1, 1, 1);
    }

    public void BackMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
