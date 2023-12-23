using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWantToSay{
    void SaySomething();
}
public interface IWantDataType<T>{
    void thisDatais(T someData);
}

public interface MoreDataType<P>{
    void moreDatThing(P datThingy){
        Debug.Log("The datatype is printed"+datThingy);
    }
}


