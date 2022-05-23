using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Transform Gs;
    public Transform Ex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnGs()
    {
        Gs.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void ExitGs()
    {
        Gs.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    public void OnEx()
    {
        Ex.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void ExitEx()
    {
        Ex.transform.localScale = new Vector3(1f, 1f, 1f);
    }

}
