using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    private int vitesse;
    private Vector2 direction;
    public void SetDirection(Vector2 dir){
        direction = dir;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(direction * vitesse * Time.deltaTime);

    }
}
