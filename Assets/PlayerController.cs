using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private RawImage leftArrow;

	[SerializeField]
	private RawImage rightArrow;

	[SerializeField]
	private RawImage upArrow;

	[SerializeField]
	private RawImage downArrow;

	[SerializeField]
	private float speed = 10;
	private Rigidbody rb;

	private Color32 defaultColor;

	private void Start()
	{
		this.rb = GetComponent<Rigidbody>();
		this.defaultColor = leftArrow.color;
	}

	private void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

		this.rb.AddForce(movement * speed);
	}

	private void Update()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Color32 redColor = new Color32(255, 180, 180, 255);
		if (moveHorizontal > 0)
		{
			rightArrow.color = redColor;
		}
		else if (moveHorizontal < 0)
		{
			leftArrow.color = redColor;
		}
		else
		{
			leftArrow.color = defaultColor;
			rightArrow.color = defaultColor;
		}

		if (moveVertical > 0)
		{
			upArrow.color = redColor;
		}
		else if (moveVertical < 0)
		{
			downArrow.color = redColor;
		}
		else
		{
			upArrow.color = defaultColor;
			downArrow.color = defaultColor;
		}
	}
}
