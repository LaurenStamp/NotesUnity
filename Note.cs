// This script is used for Impaired to zoom into notes to be read by players by Lauren Stamp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour {

	public Image noteImage;
	public GameObject HideNoteButton;

	public AudioClip pickupSound;
	public AudioClip putAwaySound;

	public GameObject playerObject;

	// Use this for initialization

	void Start () {
        // notes are disabled, note button to exit note disabled
		noteImage.enabled = false;
		HideNoteButton.SetActive (false);
	}
	
	public void ShowNoteImage()
	{
        // note image is enabled, sound played, note exit button enabled
		noteImage.enabled = true;
		GetComponent<AudioSource> ().PlayOneShot (pickupSound);
		HideNoteButton.SetActive (true);

		// Disable the Player - Controller (player cannot move while reading notes)
		playerObject.GetComponent<Mobility>().enabled = false;
	}

	public void HideNoteImage()
	{
        // disables the note image, sound played, note exit button disabled
		noteImage.enabled = false;
		GetComponent<AudioSource> ().PlayOneShot (putAwaySound);
		HideNoteButton.SetActive (false);
		//* Time.timeScale = 1f; *
        // Enable the player - Controller
		playerObject.GetComponent<Mobility>().enabled = true;
	}

}
