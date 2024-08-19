using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
  //ÃÊ¼Ó 3m
  public float speed = 3f;
  public float time = 5f;

  private void Start() => StartCoroutine(CorMove());

  IEnumerator CorMove()
  {
    Vector3 originPos = transform.position;

    while(time > 0)
    {
      
      
      this.transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);

      time -= Time.deltaTime;

      //if (Vector3.Distance(originPos , this.transform.position) > 10)
      //{
      //  yield break;
      //}

      yield return null;
    }

    
  }
}
