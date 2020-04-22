using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OilBar : MonoBehaviour
{
    public float Oil= 75f;
    public float MaxOil= 100f;
    public GameObject Light;
    public Image oilBarImage;

    void Update()
    {
        //permet d'actualiser le barre et empecher les float de dépasser une certaine limite
        oilBarImage.fillAmount = Oil / MaxOil;
        Oil = Mathf.Clamp(Oil, 0f, MaxOil);

        // quand on utilise une recharge de lampe
        if(Input.GetKeyDown(KeyCode.E))
        {
            Oil = Oil + 10;
        }

        //quand on utilise la lanterne 
        if(Input.GetKeyDown(KeyCode.A))
        {
            Oil = Oil - 10;
        }

        //désactive la lumiére quand la barre d'huile est vide
        if (Oil == 0)
        {
            Light.SetActive(false);
        }
        //active la lumière quand la barre a encore de l'huile
        else 
        {
            Light.SetActive(true);
        }
    }
}
