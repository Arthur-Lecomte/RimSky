using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenTrigger : MonoBehaviour {
    public GameObject destroyAsteroid;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            GameObject obj = Instantiate(destroyAsteroid, transform.position, transform.rotation);
            obj.transform.localScale = transform.localScale;
            Destroy(this.gameObject);
        }
    }
}
