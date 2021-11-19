using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachChar : MonoBehaviour
{
    int characters;
    public GameObject[] sHero = new GameObject[4];
    GameObject place = null;
    // Start is called before the first frame update
    void Start()
    {
        characters = TurnOnTheStage.characterNum;
        place = GameObject.FindGameObjectWithTag("place");
        // 위치를 위한 오브젝트
        for (int i = 0; i < 4; i++)
            if (characters == i) Instantiate(sHero[i], place.transform.position, Quaternion.identity);
    }
}

    
