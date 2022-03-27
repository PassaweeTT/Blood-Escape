using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamePlay : MonoBehaviour
{
    public int sword = 0;
    public static gamePlay instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public void getSword(int getsword)
    {
        sword += getsword;
    }

    public void gameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
