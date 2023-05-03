using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i;
        for (i = 1; i <= 12; i++) 
        {
            if (i == 1) print("January");
            if (i == 2) print("February");
            if (i == 3) print("March");
            if (i == 4) print("April");
            if (i == 5) print("May");
            if (i == 6) print("June");
            if (i == 7) print("July");
            if (i == 8) print("August");
            if (i == 9) print("September");
            if (i == 10) print("It's my birthday month!");
            if (i == 11) print("November");
            if (i == 12) print("December");
        }
                 int p;
        for (p = 1; p <= 31; p++)
        {
           
             if (p == 10) {print("It's my Birthday!");}
             else { Debug.Log(p);}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
