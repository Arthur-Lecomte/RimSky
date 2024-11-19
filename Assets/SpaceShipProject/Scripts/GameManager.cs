using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject[] asteroidsPrefabs;
    public GameObject[] gatePrefabs;
    public float minCo;
    public float maxCo;
    public float minScale;
    public float maxScale;
    public int countAsteroid;
    public int countGate;

    void Start() {
        Spawn("Asteroids", countAsteroid, asteroidsPrefabs, minScale, maxScale);
        Spawn("Gates", countGate, gatePrefabs, 1, 1);
    }

    void Spawn(string name, int number, GameObject[] prefabs, float tailleMin, float tailleMax) {
        GameObject root = new GameObject(name);
        GameObject obj;
        for (int i = 0; i < number; i++) {
            obj = CreateRandom(prefabs[Random.Range(0, prefabs.Length)], root);
            float taille  = Random.Range(tailleMin, tailleMax);
            obj.transform.localScale = new Vector3(taille, taille, taille);
        }
    }
    GameObject CreateRandom(GameObject prefab, GameObject parent) {
        Vector3 position = new Vector3(Random.Range(minCo, maxCo), Random.Range(minCo, maxCo), Random.Range(minCo, maxCo));
        Quaternion rotation = Quaternion.Euler(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
        return Instantiate(prefab, position, rotation, parent.transform);
    }
}
