using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("5 * " + i + " = " + Multiply(i, 5));
        }
    }

    // Update is called once per frame
    int Multiply(int x, int y)
    {
        return x * y;
    }
}
