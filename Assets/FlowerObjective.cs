using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerObjective : MonoBehaviour
{
    public GameObject flower1;
    public GameObject flower2;
    public GameObject flower3;
    public GameObject FinishedQuestUI;
    public GameObject flower1UI;
    public GameObject flower2UI;
    public GameObject flower3UI;
    public GameObject ObjectiveUI;
    public GameObject Done1;
    public GameObject Done2;
    public GameObject Done3;
    

    void Start()
    {
        
    }

    void Update()
    {
        QuestEnd();
        PickFlowers();
    }

    public void PickFlowers()
    {
        if(!flower1)
        {
            flower1UI.SetActive(false);
            Done1.SetActive(true);
        }

        if(!flower2)
        {
            flower2UI.SetActive(false);
            Done2.SetActive(true);
        }
        
        if(!flower3)
        {
            flower3UI.SetActive(false);
            Done3.SetActive(true);
        }
    }
    public void QuestEnd()
    {
        if(!flower1 && !flower2 && !flower3)
        {
            FinishedQuestUI.SetActive(true);
            ObjectiveUI.SetActive(false);
        }
    }
}
