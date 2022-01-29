using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chute : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("Salut");
        Destroy(collider.gameObject);
    }
}
