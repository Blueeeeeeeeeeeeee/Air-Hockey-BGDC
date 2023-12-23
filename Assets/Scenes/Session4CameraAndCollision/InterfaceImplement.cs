using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

//interface can be inherited multiple times
public class InterfaceImplement : MonoBehaviour, IWantToSay, IWantDataType<int>, MoreDataType<double>
{

    public void SaySomething(){
        Debug.Log("I said something here");
    }
    public void SayOtherThing(){
        Debug.Log("I said something else");
    }
    public void thisDatais(int NumDat){
        Debug.Log("The number of thisDatais:"+NumDat);
    }

    public void moreDatThing(double NumDouble){
        Debug.Log("The datatype is printed"+NumDouble);
    }
    
    void Start()
    {
        SaySomething();
        SayOtherThing();
        thisDatais(20);
        moreDatThing(12.321);
    }
}


//class can only inherit one class and monobehavior is a class
public class ClassName{
    public void MethodThing(){
        Debug.Log(1+1);
    }
}
