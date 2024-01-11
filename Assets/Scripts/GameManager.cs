using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject BoruPrefab;
    [SerializeField] float spawntime = 2f;
    
    void Start()
    {
        StartCoroutine(SpawnBoru());
    }

    
    void Update()
    {
        
    }
    IEnumerator SpawnBoru() 
    {
        while (true) 
        {
            Vector3 spawnpoz = new Vector3(transform.position.x, transform.position.y + Random.Range(-1,2), transform.position.z);
            Instantiate(BoruPrefab,spawnpoz, Quaternion.identity);
            spawntime = Random.Range(0.8f,1.2f);
            yield return new WaitForSeconds(spawntime);
        }
     
    }
}
