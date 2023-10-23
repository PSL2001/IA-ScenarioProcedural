using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPerlin : MonoBehaviour
{
    public GameObject piece;
    public int width;
    public int height;
    public float scale;
    public int maxHeight;
    // Start is called before the first frame update
    void Start()
    {
        float semilla = Random.Range(0.0f, 100.0f);
        for(int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                float coordX = semilla + (i / scale);
                float coordZ = semilla + (j / scale);
                int y = (int) (Mathf.PerlinNoise(coordX, coordZ) * maxHeight);
                //GameObject pieza =  Instantiate(piece, new Vector3(i, y, j), Quaternion.identity);

                if (y < 30)
                {
                    //pieza.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
                    Instantiate(piece, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }

    }
}
