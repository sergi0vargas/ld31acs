using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager manager;

    public float playerLife = 100;
    public Text txtFlotante;
    public Image imgTrofeo;
    public RectTransform posTxtFlotante;
    
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
        txtFlotante = GameObject.FindGameObjectWithTag("FloatingText").GetComponent<Text>();
        imgTrofeo = GameObject.FindGameObjectWithTag("Trofeo").GetComponent<Image>();
        posTxtFlotante = txtFlotante.transform as RectTransform;
        DesactivarTrofeo();
    }

    public void ActivarTrofeo()
    {
        imgTrofeo.color = new Color(255, 255, 255, 255);
    }
    public void DesactivarTrofeo()
    {
        imgTrofeo.color = new Color(0, 0, 0, 0);
    }
   
}
