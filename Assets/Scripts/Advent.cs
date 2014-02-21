using UnityEngine;
using System.Collections;

public class Advent : MonoBehaviour {

	public Transform MainText;
	public Transform InputText;

	TextMesh MainTextMesh;
	TextMesh InputTextMesh;

	//Room X and Y coords
	public int RoomX = 2;
	public int RoomY = 2;

	// Use this for initialization
	void Start () {
		MainTextMesh = (TextMesh)MainText.GetComponent(typeof(TextMesh));
		InputTextMesh = (TextMesh)InputText.GetComponent(typeof(TextMesh));
	}

	void OnGUI() {

		//Example code from unity documentation
		//http://docs.unity3d.com/Documentation/ScriptReference/Event-keyCode.html
		Event e = Event.current;
		if (e.isKey) {

			//Debug.Log("Detected key code: " + e.keyCode);

			if (Input.GetKeyDown(e.keyCode)){
				if(e.keyCode == KeyCode.Backspace){
					ClearInput();
				} else if (e.keyCode == KeyCode.Return) {
					ChangeRoom();
					ClearInput();
				} else if (e.keyCode != KeyCode.None && e.keyCode != KeyCode.Space) {
					InputTextMesh.text += e.keyCode;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (RoomY == 1){
			if (RoomX == 1) {MainTextMesh.text = "You are standing on a BEACH." +
				"\nThere is black spirals of sand under your feet." +
				"\nThe tallest MOUNTAIN can be seen to the EAST." +
				"\nThe shoreline builds up to a JETTY in the SOUTH.";}
			else if (RoomX == 2) {MainTextMesh.text = "You have reached the top of the MOUNTAIN." +
				"\nThere is snow under your feet and a stacked pile of stones." +
				"\nYou can see a long BEACH to the WEST and a CLOCK tower to the SOUTH." +
				"\nA lone SHRINE stands on the decending peaks to the EAST.";}
			else if (RoomX == 3) {MainTextMesh.text = "You are in front of a SHRINE." +
				"\nPrayer flags hang from the surrounding evergreen trees" +
				"\nA VALLEY runs to the SOUTH." +
				"\nTo the WEST looms the tallest MOUNTAIN.";}
		} else if (RoomY == 2) {
			if (RoomX == 1) {MainTextMesh.text = "You stand on the end of the JETTY." +
				"\nYou look at the rocks below as the waves crash over." +
				"\nTo the NORTH, the cliff decends to a BEACH." +
				"\nThere is a CLOCK tower to the EAST and a FEILD to the SOUTH.";}
			else if (RoomX == 2) {MainTextMesh.text = "You stand at the base of a CLOCK tower. You can't read its symbols." +
				"\nA MOUNTAIN casts a shadow over you from the NORTH." +
				"\nA river runs from a VALLEY in the EAST to a FOREST in the SOUTH." +
						"\nThe land expands to a JETTY in the WEST.";}
			else if (RoomX == 3) {MainTextMesh.text = "You are in the lowest part of a large VALLEY." +
				"\nYou are standing along a river that runs to the southwest." +
				"\nA CLOCK tower is to the WEST with HILLS that roll to the SOUTH." +
				"\nA SHRINE can be seen above you, to the NORTH";}
		} else if (RoomY == 3){
			if (RoomX == 1) {MainTextMesh.text = "You are in an endless FEILD." +
				"\nThe tall grass brushes against your hands." +
				"\nTo the NORTH is a JETTY that lines the ocean." +
				"\nYou can see a FOREST to your EAST";}
			else if (RoomX == 2) {MainTextMesh.text = "Tall trees surround you in the FOREST." +
				"\nThrough the trees you can see a CLOCK tower in the NORTH" +
				"\nand a FEILD to the WEST." +
				"\nThe trees get shorter towards the HILLS to the EAST.";}
			else if (RoomX == 3){MainTextMesh.text = "You are on the tallest of a series of HILLS." +
				"\nThe landscape resembles a giant wrinkled sheet." +
				"\nTo the NORTH the land drops off into a VALLEY." +
				"\nThe scattered trees have grown into a dense FOREST in the WEST.";}
		}
	}

	void ChangeRoom () {
		//Cardinal Directions
		if (InputTextMesh.text == ">NORTH" && RoomY>1) {RoomY--;}
		else if (InputTextMesh.text == ">SOUTH" && RoomY<3) {RoomY++;}
		else if (InputTextMesh.text == ">WEST" && RoomX>1) {RoomX--;}
		else if (InputTextMesh.text == ">EAST" && RoomX<3) {RoomX++;}
		//BEACH	MOUNTAIN SHRINE
		//JETTY CLOCK VALLEY
		//FEILD FOREST HILLS
		else if (InputTextMesh.text == ">BEACH") {
			RoomX = 1;
			RoomY = 1;
		}
		else if (InputTextMesh.text == ">MOUNTAIN") {
			RoomX = 2;
			RoomY = 1;
		}
		else if (InputTextMesh.text == ">SHRINE") {
			RoomX = 3;
			RoomY = 1;
		}
		else if (InputTextMesh.text == ">JETTY") {
			RoomX = 1;
			RoomY = 2;
		}
		else if (InputTextMesh.text == ">CLOCK") {
			RoomX = 2;
			RoomY = 2;
		}
		else if (InputTextMesh.text == ">VALLEY") {
			RoomX = 3;
			RoomY = 2;
		}
		else if (InputTextMesh.text == ">FEILD") {
			RoomX = 1;
			RoomY = 3;
		}
		else if (InputTextMesh.text == ">FOREST") {
			RoomX = 2;
			RoomY = 3;
		}
		else if (InputTextMesh.text == ">HILLS") {
			RoomX = 3;
			RoomY = 3;
		}
	}

	void ClearInput () {
		//Clears input text
		InputTextMesh.text = ">";
	}
}
