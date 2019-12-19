using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float factorMuerte = 10;
    public float vida = 100;
    public Image barraVida;
    public int zombiesMuertos { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Zombie")
        {
            Destroy(collision.collider.gameObject);
            vida -= factorMuerte;
            barraVida.fillAmount = vida / 100;
        }
    }
}
