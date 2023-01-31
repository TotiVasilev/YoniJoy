using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanObjective : MonoBehaviour
{
    public GameObject pickUpText;
    public GameObject QuestPannel;
    public GameObject beginningQuestUI;
    public GameObject FlowerObjective;
    public GameObject Flower1;
    public GameObject Flower2;
    public GameObject Flower3;
    public bool CursorLock;
    
    bool canPressE;
    public bool pressedE;
    
    void Start()
    {
        canPressE = false;
        pressedE = false;
        CursorLock = false;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canPressE == true)
        {
            pressedE = true;
            pickUpText.SetActive(false);
            QuestPannel.SetActive(true);
            CursorLock = true;
        
            
        }
        
        CursorChange();
    }

    void OnTriggerStay(Collider other)
    {
        pickUpText.SetActive(true);
        if(other.gameObject.tag == "Player")
        {
            canPressE = true;
        }
        if (pressedE)
        {
            Cursor.lockState = CursorLockMode.None;
            pickUpText.SetActive(false);
        }
        else
        {
            pickUpText.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void OnTriggerExit()
    {
        canPressE = false;
        pickUpText.SetActive(false);
    }

    
    
    public void Accept()
    {
        beginningQuestUI.SetActive(false);
        FlowerObjective.SetActive(true);
        Flower1.SetActive(true);
        Flower2.SetActive(true);
        Flower3.SetActive(true);
        QuestPannel.SetActive(false);
        CursorLock = false;


    }
    public void Decline()
    {
        QuestPannel.SetActive(false);
        CursorLock = false;
        pressedE = false;

    }

    public void CursorChange()
    {
        if(CursorLock==true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
