using UnityEngine;
using System.Collections;

public class HasTheKey : MonoBehaviour {

    public bool hasKey = false;
   
	
	void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasKey)
                {
                    StartCoroutine("CambiaTexto", "Found a Key");
                }
                else
                {
                    StartCoroutine("CambiaTexto", "Nothing here...");
                }
            }
        }
	}

    IEnumerator CambiaTexto(string txt)
    {
        GameManager.manager.posicionTextoFlotante.position = Camera.main.WorldToScreenPoint(transform.position);
        GameManager.manager.textoFlotante.text = txt;
        yield return new WaitForSeconds(1);
        GameManager.manager.textoFlotante.text = "";
    }
}
