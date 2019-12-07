using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform character;
    public float velocity;

    // Start is called before the first frame update4
    void Start()
    {
        character = GameObject.Find("Character").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * velocity);
        transform.LookAt(character);
        
    }

    public void Killer()
    {
        Destroy(this.gameObject);
    }
}
