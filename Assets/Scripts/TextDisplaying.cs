using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplaying : MonoBehaviour
{

    public bool EtabliNoRessource = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Etablietext()
    {
        if(EtabliNoRessource == true)
        {
            StartCoroutine(ShowMessage("ABC", 2));
        }
    }

    IEnumerator ShowMessage (string message, float delay)
    {
        //GUIText.text = message;
       // GUIText.enabled = true;
        yield return new WaitForSeconds(delay);
        //GUIText.enabled = false;
    }
}
