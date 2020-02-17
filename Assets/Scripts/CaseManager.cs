using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CaseManager : MonoBehaviour
{
    public TextMeshProUGUI InfoText;
    public GameObject Case;
    private string obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<Image>().sprite.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayInformations()
    {

        if(Case.name == "Case 1")
        {

            if(obj == "Wooden_Plank")
            {
                InfoText.text = "Des planches de bois... Mais à quoi peuvent elle bien servir ?";
            }
        }
        if (Case.name == "Case 2")
        {
            if(obj == "Hammer")
            {
                InfoText.text = "Un vieux marteau";
            }
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
