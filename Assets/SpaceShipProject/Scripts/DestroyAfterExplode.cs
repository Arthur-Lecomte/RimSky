using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterExplode : MonoBehaviour {
    void Start() {
        StartCoroutine(DeleteMe());
    }

    private IEnumerator DeleteMe() {
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
