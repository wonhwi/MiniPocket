using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScriptableMonoBehaviour<T> : ScriptableObject where T : SingletonScriptableMonoBehaviour<T>
{
  private static T _instance;
  public static T instance
  {
    get
    {
      if (_instance == null)
      {
        T[] asset = Resources.LoadAll<T>("");
        if (asset != null && asset.Length.Equals(1))
        {
          _instance = asset[0];
        }
      }
      return _instance;
    }
  }
}
