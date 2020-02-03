using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CaseManager : MonoBehaviour
{
    public TextMeshProUGUI InfoText;
    public GameObject Case;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayInformations()
    {

        if(Case.name == "Case 1")
        {
            InfoText.text = "Case n°1";
        }
        if (Case.name == "Case 2")
        {
            InfoText.text = "Case n°2";
        }
        if (Case.name == "Case 3")
        {
            InfoText.text = "Case n°3";
        }
        if (Case.name == "Case 4")
        {
            InfoText.text = "Case n°4";
        }
        if (Case.name == "Case 5")
        {
            InfoText.text = "Case n°5";
        }
        if (Case.name == "Case 6")
        {
            InfoText.text = "Case n°6";
        }
    }
}
