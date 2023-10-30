using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezaController : MonoBehaviour
{
    private GameObject suelo;
    private GameObject paredN;
    private GameObject paredS;
    private GameObject paredE;
    private GameObject paredO;
    void Start()
    {
        suelo = this.transform.GetChild(0).gameObject;
        paredN = this.transform.GetChild(2).gameObject;
        paredS = this.transform.GetChild(1).gameObject;
        paredE = this.transform.GetChild(3).gameObject;
        paredO = this.transform.GetChild(4).gameObject;

        Invoke("quitarParedes", 5.0f);
    }

    private void quitarParedes()
    {
        // Norte

        if(Physics.Raycast(suelo.transform.position, suelo.transform.forward, 3))
        {
            Destroy(paredN);
        }

        // Sur

        if (Physics.Raycast(suelo.transform.position, suelo.transform.forward * -1, 3))
        {
            Destroy(paredS);
        }

        // Este

        if (Physics.Raycast(suelo.transform.position, suelo.transform.right, 3))
        {
            Destroy(paredE);
        }

        // Oeste

        if (Physics.Raycast(suelo.transform.position, suelo.transform.right * -1, 3))
        {
            Destroy(paredO);
        }
    }
}
