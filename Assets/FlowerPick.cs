using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPick : MonoBehaviour
{
    public GameObject Flower1;
    public GameObject Flower2;
    public GameObject Flower3;
    public GameObject pickUpText;
    bool canPressE;
    
    void Start()
    {
        canPressE = false;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canPressE == true)
        {
            pickUpText.SetActive(false);
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        pickUpText.SetActive(true);
        if(other.gameObject.tag == "Player")
        {
            canPressE = true;
        }
    }

    void OnTriggerExit()
    {
        canPressE = false;
        pickUpText.SetActive(false);
    }
}
