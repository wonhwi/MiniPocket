using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
  public static T instance; 
  public SingletonMonoBehaviour() => instance = (T)this;


  private void OnDestroy() => instance = null;
}