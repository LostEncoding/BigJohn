using UnityEngine;
using System.Collections;

public class SandwichController : MonoBehaviour {

	public string SandwichName;

	// Use this for initialization
	void Start () {
		createSandwich ();
	}
	
	// Update is called once per frame
	void Update () {
		print (SandwichName);
	}

	void createSandwich(){
		string Bread = randomizeBread ();
		string Meat = randomizeMeat ();
		string Cheese = randomizeCheese ();
		string Sauce = randomizeSauce ();
		SandwichName = Bread + " " + Meat + " " + Cheese + " " + Sauce;
	}

	public string randomizeBread(){
		string[] Bread = {"White", "Wheat", "Rye", "Marble"};
		int breadInt = 0;
		breadInt = Random.Range(0,3);
		return Bread[breadInt];
	}

	public string randomizeMeat(){
		string[] Meat = {"Turkey", "Chicken", "Beef", "Baon", "Pork"};
		int meatInt = 0;
		meatInt = Random.Range (0,4);
		return Meat[meatInt];
	}

	public string randomizeCheese(){
		string[] Cheese = {"American", "Provolone", "Pepperjack", "Cheddar", "Gouda"};
		int cheeseInt = 0;
		cheeseInt = Random.Range (0,4);
		return Cheese[cheeseInt];
	}

	public string randomizeSauce(){
		string[] Sauce = {"Mayonnaise", "Mustard", "Barbecue Sauce", "Oil", "Vinegar"};
		int sauceInt = 0;
		sauceInt = Random.Range (0,4);
		return Sauce[sauceInt];
	}
}
