using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzzzzzzzzzzzzzzzzzzzzz : MonoBehaviour
{
     void Start()
    {
      while (true)
        {
            int nums = Random.Range(1, 21);
            if (nums == 5) 
                continue;
            else if (nums == 15) 
                break;
            Debug.Log(nums);
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

}
