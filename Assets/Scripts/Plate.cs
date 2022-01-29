using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {
    private bool move;
   private int caca;
   [SerializeField]
   private int vitesse;

    void Awake(){
        move= true;
        caca= Random.Range(20, 100);
   }

   void FixedUpdate(){
       if (move) transform.Translate(Vector2.right*vitesse*Time.deltaTime);
       

   }
             
}




