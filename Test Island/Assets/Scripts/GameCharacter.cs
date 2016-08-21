using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCharacter : MonoBehaviour
{
	private List<Creature> team;
	private Inventory inventory;

	// Use this for initialization
	void Start ()
	{
		inventory = new Inventory ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}