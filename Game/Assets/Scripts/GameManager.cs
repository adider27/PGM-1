using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform titikRespown;
    int skor = 0;


    public TextMeshProUGUI skorTeks;
    public GameObject tombolMulai;
    public GameObject player;
    public GameObject Teks;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, titikRespown.position, Quaternion.identity);
        }
    }



    void skorNaik()
    {
        skor++;
        skorTeks.text = skor.ToString();
    }



    public void JumpStart()
    {
        player.SetActive(true);
        tombolMulai.SetActive(false);
        Teks.SetActive(true);


        StartCoroutine("SpawnObstacles");
        InvokeRepeating("skorNaik", 2f, 1f);

    }
}
