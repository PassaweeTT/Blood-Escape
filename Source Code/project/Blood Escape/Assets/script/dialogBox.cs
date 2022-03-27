using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogBox : MonoBehaviour
{

    public GameObject box;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;

    public static dialogBox instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bfGetsword()
    {

    }
    
}
