﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	/// <summary>
	/// Whether the game was paused.
	/// </summary>
	public bool paused { get; private set; }
	/// <summary>
	/// Whether the cursor was locked.
	/// </summary>
	private bool wasLocked = false;

	
	// Use this for initialization
	void Start ()
	{
		// Init
		paused = false;
		wasLocked = false;

		Screen.lockCursor = true;
		Screen.showCursor = false;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Screen.lockCursor = false;
			Screen.showCursor = true;
		}

		if (Input.GetMouseButton(0))
		{
			Screen.lockCursor = true;
			Screen.showCursor = false;
		}

		if (!Screen.lockCursor && wasLocked)
		{
			wasLocked = false;
		}
		else if (Screen.lockCursor && !wasLocked)
		{
			wasLocked = true;
		}
	}
}
