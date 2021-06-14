using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoodleSpawner : MonoBehaviour,ISpowner
{
    public GameObject[] creamPoodles;
    public GameObject[] grayPoodles;
    public GameObject[] whitePoodles;

    float spawnerTimer = 0;
    string Character;

    private void Start()
    {
        CharaInfo();
    }
    private void Update()
    {
        spawnerTimer += Time.deltaTime;
        if (spawnerTimer > 5f)
        {
            Spawn();
            spawnerTimer = 0;
        }
    }
    public void CharaInfo()
    {
        Character = PlayerPrefs.GetString("Character");
        Debug.Log(Character);
    }
    public int RandomNumber()
    {
        int random = Random.Range(0, creamPoodles.Length);
        return random;
    }
    public void Spawn()
    {
        int r = RandomNumber();
        switch(Character)
        {
            case "Gray":
                Instantiate(grayPoodles[r],transform.position,Quaternion.Euler(0f,-90f,0f));
                break;
            case "White":
                Instantiate(grayPoodles[r], transform.position, Quaternion.Euler(0f, -90f, 0f));
                break;
            case "Cream":
                Instantiate(grayPoodles[r], transform.position, Quaternion.Euler(0f, -90f, 0f));
                break;
        }        
    }
}
