using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Experimental.PlayerLoop;

public class Rocket : MonoBehaviour {

	Rigidbody rigidbody;
	AudioSource audiosource;
	
	// Use this for initialization
	void Start ()
	{
	rigidbody = GetComponent<Rigidbody>();
	audiosource = GetComponent<AudioSource>();
	//audiosource.Play(0);
	//audiosource.Pause();
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Rotate();
		Thrust();
	}
	
	private void Thrust()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			rigidbody.AddRelativeForce(Vector3.up);
			if (!audiosource.isPlaying)
			{
				audiosource.Play();
			}
			else
			{
				audiosource.Stop();
			}

			//audiosource.UnPause();
		}
	}

	private void Rotate()
	{
		rigidbody.freezeRotation = true;
		if (Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.forward);
		}

		else if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(-Vector3.forward);
		}

		rigidbody.freezeRotation = false;
	}


}
