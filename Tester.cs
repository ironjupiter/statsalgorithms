using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ItemGroup ig = new ItemGroup(1000);
        Debug.Log("sum = "+ ig.checkProportionSum());
        Debug.Log(ig.listOfProportions()[0]);
        Debug.Log(ig.listOfProportions()[1]);
        Debug.Log(ig.listOfProportions()[2]);
        Debug.Log(ig.listOfProportions()[3]);
        Debug.Log(ig.listOfProportions()[4]);
        Debug.Log(ig.listOfProportions()[5]);
        //Debug.Log(ig.getSample(1000));
    }
    
}
