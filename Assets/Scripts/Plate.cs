using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {
   private int caca;
   [SerializeField]
   private int vitesse;

    public Plate(){
        caca = 0;
        vitesse = 2;
    }
    void Awake(){
        caca= Random.Range(20, 100);
   }

   void FixedUpdate(){
       transform.Translate(Vector2.right*vitesse*Time.deltaTime);
   }
             
}




