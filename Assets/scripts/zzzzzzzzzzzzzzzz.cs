using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzzzzzzzzzzzzzzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int counter=10;
      while(True){
        int no=Random.range(1,21);
        if( no ==5 )  continue;
        else if( no ==15) break;
      }
     


       string[] arr = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int no = 7;
        string result = "";

        while (no != 0)
        {
            int random = Random.Range(0, 10); // Generate a random number between 0 and 9
            result += arr[random]+" ";
            no--;
        }

        Debug.Log(result); 










    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
