using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionZombie : MonoBehaviour
{
    public float tiempoCreacion;

    public float tiempo;

    public GameObject zombie;
    // Start is called before the first frame update
    void Start()
    {
        tiempoCreacion = Random.Range(5, 7);
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo < tiempoCreacion)
        {
            tiempo += Time.deltaTime;
        }
        else
        {
            tiempo = 0;
            tiempoCreacion = Random.Range(12, 15);
            var gameObject = Instantiate(zombie, transform.position, transform.rotation);
            gameObject.name = "Zombie";
            gameObject.SetActive(true);
        }
    }
}
