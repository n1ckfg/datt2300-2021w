using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public int damage = 1;
    public float lifetime = 4f;
    public float speed;
    public GameObject explosionPrefab;

    private IEnumerator Start() {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().takeDamage(damage);
            doExplosion();
        }
    }

    private void doExplosion() {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
