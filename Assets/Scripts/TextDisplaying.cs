using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplaying : MonoBehaviour
{

    public GameObject TextNoRessource;

    public bool EtabliNoRessource = false;


    private void Update()
    {
        if (EtabliNoRessource == true)
        {
            EtabliNoRessource = false;
            Etablietext();
        }
    }

    public void Etablietext()
    {
        StartCoroutine(ShowMessage(3));
    }

    IEnumerator ShowMessage(float delay)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        TextNoRessource.SetActive(true);
        yield return new WaitForSeconds(delay);
        TextNoRessource.SetActive(false);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}