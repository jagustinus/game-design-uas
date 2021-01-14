using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    public GameObject plane1;
    public GameObject plane2;
    public GameManage gameManager;
    private Rigidbody2D rb;
    int plane = 1;
    // Start is called before the first frame update
    void Start()
    {
        plane1.gameObject.SetActive(true);
        plane2.gameObject.SetActive(false);
    }
    public void Switch()
    {
        switch(plane)
        {
            case 1:
                plane = 2;
                plane1.gameObject.SetActive(false);
                plane2.gameObject.SetActive(true);
                break;
            case 2:
                plane = 1;
                plane1.gameObject.SetActive(true);
                plane2.gameObject.SetActive(false);
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
