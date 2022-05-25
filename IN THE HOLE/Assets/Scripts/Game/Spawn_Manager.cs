using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject planet_1, planet_2, planet_3, planet_4, planet_5, planet_6, planet_7, planet_8, blackhole;
    public float maxX;
    public float minX;
    public float minY;
    public float maxY;
    public float timeBetweenSpawn = 0.65f;
    public int blackhole_Spawn = 0;
    private float spawnTime;


    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }


    void Spawn()
    {
        GameObject planet = Random_Planet();
        float randomX = Random.Range(minX, maxX);
        float randomy = Random.Range(minY, maxY);
        Instantiate(planet, transform.position + new Vector3(randomX, randomy, 0), transform.rotation);
    }

    GameObject Random_Planet()
    {
        if (blackhole_Spawn != 4)
        {

            int rnd = Random.Range(1, 9);
            blackhole_Spawn++;

            switch (rnd)
            {
                case 1:
                    return planet_1;

                case 2:
                    return planet_2;

                case 3:
                    return planet_3;

                case 4:
                    return planet_4;

                case 5:
                    return planet_5;

                case 6:
                    return planet_6;

                case 7:
                    return planet_7;

                default:
                    return planet_8;
            }
        }
        else
        {
            int rnd = Random.Range(1, 3);

            if (rnd == 1)
            {
                blackhole_Spawn = 0;
                return blackhole;
            }
            else
            {
                int random = Random.Range(1, 9);
                blackhole_Spawn = 0;

                switch (random)
                {
                    case 1:
                        return planet_1;

                    case 2:
                        return planet_2;

                    case 3:
                        return planet_3;

                    case 4:
                        return planet_4;

                    case 5:
                        return planet_5;

                    case 6:
                        return planet_6;

                    case 7:
                        return planet_7;

                    default:
                        return planet_8;
                }
            }
            
        }
    }
}
