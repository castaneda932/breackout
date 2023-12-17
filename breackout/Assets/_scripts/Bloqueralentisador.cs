using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloqueralentisador : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2; 
    }
    public override void rebotarbola()
    {
        base.rebotarbola();
    }

}
