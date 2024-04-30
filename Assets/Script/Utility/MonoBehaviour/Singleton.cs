using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
  public static T instance;

  public Singleton() => instance = (T)this;


  private void OnDestroy() => instance = null;


  //public static T Instance
  //{
  //  get
  //  {
  //    if (!instance)
  //    {
  //      instance = (T)FindObjectOfType(typeof(T));

  //    }

  //    return instance;
  //  }

  //}


}
