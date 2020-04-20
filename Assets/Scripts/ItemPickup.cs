using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public CaseManager CaseManager;

    //Quand le joueur collide avec 1 item à ramasser,
    //Un bool correspondant à l'item est activé sur le script CaseManager
    private void OnTriggerEnter(Collider other)
    {


        if (other.name == "Hammer")
        {
            CaseManager.Hammer = true;
        }

        if (other.name == "Planks")
        {
            CaseManager.Planks = true;
        }

        if (other.name == "Ladder")
        {
            CaseManager.Ladder = true;
        }

        if (other.name == "KeyRemise")
        {
            CaseManager.KeyRemise = true;
        }

        if (other.name == "KeyLabo")
        {
            CaseManager.KeyLabo = true;
        }

        if(other.name == "MunLampe")
        {
            CaseManager.MunLampe = true;
        }
    }
}
