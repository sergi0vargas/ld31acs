using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager manager;

    public float playerLife = 100;
    public Text textoFlotante;
    public RectTransform posicionTextoFlotante;

    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        textoFlotante = GameObject.FindGameObjectWithTag("FloatingText").GetComponent<Text>();
        posicionTextoFlotante = textoFlotante.transform as RectTransform;
    }
   
}
