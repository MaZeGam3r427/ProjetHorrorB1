using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public CaseManager CaseManager;
    public TextDisplaying TextDisplaying;

    //Quand le joueur collide avec 1 item à ramasser,
    //Un bool correspondant à l'item est activé sur le script CaseManager
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Hammer")
        {
            CaseManager.Hammer = true;
            other.enabled = false;
        }

        if (other.tag == "Planks")
        {
            CaseManager.Planks = true;
            other.enabled = false;
        }

        if (other.tag == "Etabli")
        {
            TextDisplaying.EtabliNoRessource = true;
        }

        if (other.tag == "Ladder")
        {
            CaseManager.Ladder = true;
            other.enabled = false;
        }

        if (other.tag == "KeyRemise")
        {
            CaseManager.KeyRemise = true;
            other.enabled = false;
        }

        if (other.tag == "KeyLabo")
        {
            CaseManager.KeyLabo = true;
            other.enabled = false;
        }

        if(other.tag == "MunLampe")
        {
            CaseManager.MunLampe = true;
            other.enabled = false;
        }
    }
}
