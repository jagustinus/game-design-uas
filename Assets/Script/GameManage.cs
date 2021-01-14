using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public GameObject GameCanvas;
    public GameObject MainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu()
    {
        Time.timeScale = 0;
        MainCanvas.SetActive(true);
    }
}
