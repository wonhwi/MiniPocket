using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{
  private void Awake() => DontDestroyOnLoad(this.gameObject);


}
