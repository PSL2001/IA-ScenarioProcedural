using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaberintoCrecimiento : MonoBehaviour
{
    public GameObject pieza;
    public int totalPiezas;

    private bool hayHueco;
    private GameObject piezaActual;
    // Start is called before the first frame update
    void Start()
    {
        hayHueco = true;
        piezaActual = null;
        StartCoroutine(Generar(0, 0));
    }

    IEnumerator Generar(float x, float z)
    {
        yield return new WaitForEndOfFrame();
        if (totalPiezas > 0)
        {
            if (hayHueco)
            {
                piezaActual = Instantiate(pieza, new Vector3(x, 0, z), Quaternion.identity);
                totalPiezas--;
                //Crece hacia el norte
                float newX = x;
                float newZ = z + 5;
                hayHueco = true;

                StartCoroutine(Generar(newX, newZ));
            }
        }
    }
}
