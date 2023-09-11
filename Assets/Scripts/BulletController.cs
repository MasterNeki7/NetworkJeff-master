using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

  [SerializeField]
  float initialVelocity = 115f;

  [SerializeField]
  float lifeTime = 8.5f;

  void Start()
  {
    Rigidbody rigidbody = GetComponent<Rigidbody>();
    rigidbody.velocity = transform.forward * initialVelocity;

    Destroy(this.gameObject, lifeTime);
  }
}
