using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
	public float speed = 20;
	public GameObject explosionparticle;

	void Start()
	{
		Destroy(gameObject,3f);
	}

	void Update()
	{
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
		var health = other.gameObject.GetComponent<health>();
        if (health != null)
        {
			health.Damage(10);
        }

		Instantiate(explosionparticle, transform.position,transform.rotation);
	}
	
}