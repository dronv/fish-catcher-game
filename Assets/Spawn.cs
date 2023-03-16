using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Right;
    public GameObject[] items;
    public float start_timer, repeater;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", start_timer, repeater);
    }

    void Spawner()
    {
        Vector3 location = new Vector3(Random.Range(gameObject.transform.position.x, Right.transform.position.x), gameObject.transform.position.y, 0);
        Instantiate(items[Random.Range(0, items.Length)], location, gameObject.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
