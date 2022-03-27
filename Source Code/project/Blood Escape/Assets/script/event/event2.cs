using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class event2 : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;

    public static event2 instance;
    int check = 0;
    int check2 = 0;
    int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (check2 >= 1)
            {
                Destroy(gameObject);
            }
            if (check == 0 && check2 == 0)
            {
                if (dialogBox.activeInHierarchy)
                {
                    dialogBox.SetActive(false);
                }
                else
                {
                    dialogBox.SetActive(true);
                    count += 1;
                }
            }
            
                
        }

    }

    private void Start()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && count >= 1)
        {
            print("AAA");
            dialogBox.SetActive(false);

        }

    }
    public void checkCC(int cc)
    {
        check2 += cc;
    }
}
