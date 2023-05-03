using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro.EditorUtilities;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{
    public GameObject swarmerPrefab;
    public float enemy = 1f;

    public float time = 60f;
    public float done;

    void Start()
    {
        NavMeshHit closestHit;

        if (NavMesh.SamplePosition(gameObject.transform.position, out closestHit, 500f, NavMesh.AllAreas))
            gameObject.transform.position = closestHit.position;
        else
            Debug.LogError("Could not find position on NavMesh!");

        StartCoroutine(spawnEnemy(enemy, swarmerPrefab));

    }

    // Update is called once per frame
    void Update()
    {
        done = done += Time.deltaTime;
        if (done >= time)
        {
            StopAllCoroutines();
            SceneManager.LoadScene("win");
        } 


    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, transform.position, transform.rotation);
        StartCoroutine(spawnEnemy(interval, swarmerPrefab));
    }
}
