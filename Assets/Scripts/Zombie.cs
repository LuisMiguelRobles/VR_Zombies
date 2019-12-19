using UnityEngine;
using UnityEngine.UI;

public class Zombie : MonoBehaviour
{
    public GameObject personaje;
    public Image barraVida;
    public float velocidad;
    public float factorMuerte = 25;
    public float vida = 100;
    public bool apuntar { get; set; }

    // Start is called before the first frame update4
    void Start()
    {
        velocidad = Random.Range(0.3f, 2);
        personaje = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstaMuerto())
            Killer();
        else
            Movimiento();
    }

    public void Killer()
    {
        personaje.GetComponent<Character>().zombiesMuertos++;
        Destroy(this.gameObject);
    }

    private bool EstaMuerto()
    {
        var estaMuerto = false;

        if (apuntar)
        {
            vida -= factorMuerte * Time.deltaTime;
            barraVida.fillAmount = vida / 100;
        }

        if (vida <= 0)
        {
            estaMuerto = true;
        }

        return estaMuerto;
    }

    private void Movimiento()
    {
        var posicion = new Vector3(personaje.GetComponent<Transform>().position.x, transform.position.y, personaje.GetComponent<Transform>().position.z);
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        transform.LookAt(posicion);
    }
}
