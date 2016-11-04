using UnityEngine;
using System.Collections;

[RequireComponent (typeof(PlayerController))] // Para que siempre tenga que tener un controlador y no se nos vaya.
public class playerBehaviour : MonoBehaviour {

	public float moveSpeed = 5;
	PlayerController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<PlayerController> (); //Inicialización controlador
	}
	
	// Update is called once per frame
	void Update () {

		//Movement
		Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		controller.Move (moveVelocity);



	}
}
