using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sword : MonoBehaviour
{
    public GameObject box;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;

    int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            shooting.instance.checkSW(1);
            Player.instance.swordSW(1);
            event1.instance.checkCC(1);
            event2.instance.checkCC(1);
            count += 1;
        }

        if (box.activeInHierarchy)
        {
            box.SetActive(false);
        }
        else
        {
            box.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && count>=1)
        {
            print("AAA");
            box.SetActive(false);
            gameObject.SetActive(false);
            
        }
    }
}
