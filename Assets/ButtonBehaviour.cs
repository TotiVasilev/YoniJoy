using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    
    public GameObject beginningQuestUI;
    public GameObject FlowerObjective;
    public GameObject Flower1;
    public GameObject Flower2;
    public GameObject Flower3;
    public GameObject ObjectivePannel;
    public void Accept()
    {
        beginningQuestUI.SetActive(false);
        FlowerObjective.SetActive(true);
        Flower1.SetActive(true);
        Flower2.SetActive(true);
        Flower3.SetActive(true);
        ObjectivePannel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;


    }
    public void Decline()
    {
        ObjectivePannel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

    }
}
