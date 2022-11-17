using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Scriptables;

public class ObjectPooling : MonoBehaviour
{
    [System.Serializable]
    public class Pool {
        public string tag;
        public GameObject prefab;
        public int size;
    }
    public List<SO> scriptableObjects;
    public List<Pool> prefabs;
    public Dictionary<string, Queue<GameObject>> poolDict;

    private void Start() {
        //poolDict = new Dictionary<string, Queue<GameObject>>();
    }
    
}
