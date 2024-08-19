using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManagerConstant : Singleton<ManagerConstant>
{
  public delegate void Test();

  public event Test test;


}
