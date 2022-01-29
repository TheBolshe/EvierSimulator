using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {
    private Vector2 direction;
    public bool canPick;
    public List<GameObject> pickable;

    [SerializeField]
    private int vitesse;

    public void OnTriggerEnter2D(Collider2D collider) {
        this.canPick = true;
        pickable.Add(collider.gameObject);
    }

    public void OnTriggerExit2D(Collider2D collider) {
        this.canPick = false;
        pickable.Remove(collider.gameObject);
    }

    public void SetDirection(Vector2 dir) {
        direction = dir;
    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.Translate(direction * vitesse * Time.deltaTime);
        Debug.Log(pickable.length);

    }
}
