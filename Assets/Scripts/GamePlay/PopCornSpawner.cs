using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PopCornSpawner : MonoBehaviour
{
    public static PopCornSpawner popCornSpawnerInstance;
    public bool work;

    [SerializeField] GameObject[] popCornArray;
    [SerializeField] GameObject popCornForRow1, popCornForRow2, popCornForRow3, popCornForRow4;
    [SerializeField] float smallHeight, mediumHeight, highHeight;
    [SerializeField] float[] spawnerTime;

    [SerializeField] int popCornPoolIndex;
    public bool canCreate;
    private float timer;


    private void Awake()
    {
        popCornSpawnerInstance = this;
    }

    private void Start()
    {
        GetSpawnerTime();
    }

    private void Update()
    {
        if (canCreate)
        {
            if (work)
            {
                timer -= Time.deltaTime;
        
                if (timer < 0)
                {
                    GeneratePopCorn();
                    GetSpawnerTime();
                }
            }
        }

    }

    private void GetSpawnerTime()
    {
        int randomIndex = Random.Range(0, spawnerTime.Length);
        float randomValue = spawnerTime[randomIndex];
        timer = randomValue;
    }

    private void GeneratePopCorn()
    {
        if (canCreate)
        {
            int tempPopCornRow = Random.Range(0, 9);
            if (tempPopCornRow != 8)
            {
                popCornPoolIndex++;
                if (popCornPoolIndex >= popCornArray.Length)
                    popCornPoolIndex = 0;

                popCornArray[popCornPoolIndex].SetActive(true);
                popCornArray[popCornPoolIndex].transform.position = new Vector3(transform.position.x, RandomizePopCornHeight(), transform.position.z);
            }
            else
            {
                StartCoroutine(CoroutineCreatePopCornRow());
            }
        }
    }

    float RandomizePopCornHeight()
    {
        int temp = Random.Range(0, 3);
        if (temp == 0) return smallHeight;
        else if (temp == 1) return mediumHeight;
        else return highHeight;
    }

    IEnumerator CoroutineCreatePopCornRow()
    {
        float temp = RandomizePopCornHeight();
        Instantiate(popCornForRow1, new Vector3(transform.position.x, temp, transform.position.z), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(popCornForRow2, new Vector3(transform.position.x, temp, transform.position.z), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(popCornForRow3, new Vector3(transform.position.x, temp, transform.position.z), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(popCornForRow4, new Vector3(transform.position.x, temp, transform.position.z), Quaternion.identity);
    }
    
    public void DestroyThisObj()
    {
        if (!work)
        {
            PopCorn[] allPop = FindObjectsOfType<PopCorn>();

            foreach (PopCorn popCorn in allPop)
            {
                Vector3 viewportPosition = Camera.main.WorldToViewportPoint(popCorn.transform.position);
                if (viewportPosition.x < 0 || viewportPosition.x > 1 ||
                    viewportPosition.y < 0 || viewportPosition.y > 1 ||
                    viewportPosition.z < 0)
                {
                    Destroy(popCorn.gameObject);
                }
            }
        }
    }

    public void ChangeWorking()
    {
        work = !work;
    }
}
