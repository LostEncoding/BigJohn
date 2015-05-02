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
		print(SandwichName);
	}

	void createSandwich(){
		string Bread = randomizeBread ();
		string Meat = randomizeMeat ();
		string Cheese = randomizeCheese ();
		string Sauce = randomizeSauce ();
		string Extra = randomizeExtra ();
		SandwichName = Meat + " on " + Bread + " with " + Cheese + ", " + Sauce + Extra;
	}

	public string randomizeBread(){
		string[] Bread = {"White Bread", "Wheat Bread", "Rye Bread", "Marble Bread"};
		int breadInt = 0;
		breadInt = Random.Range(0,4);
		return Bread[breadInt];
	}

	public string randomizeMeat(){
		string[] Meat = {"Turkey", "Chicken", "Beef", "Bacon", "Pork"};
		int meatInt = 0;
		meatInt = Random.Range (0,5);
		return Meat[meatInt];
	}

	public string randomizeCheese(){
		string[] Cheese = {"American Cheese", "Provolone Cheese", "Pepperjack Cheese", "Cheddar Cheese", "Gouda Cheese"};
		int cheeseInt = 0;
		cheeseInt = Random.Range (0,5);
		return Cheese[cheeseInt];
	}

	public string randomizeSauce(){
		string[] Sauce = {"Mayonnaise", "Mustard", "Barbecue Sauce", "Oil", "Vinegar"};
		int sauceInt = 0;
		sauceInt = Random.Range (0,5);
		return Sauce[sauceInt];
	}

	public string randomizeExtra(){
		string Extra = "";
		string Extra1 = "Lettuce";
		string Extra2 = "Tomato";
		string Extra3 = "Pickles";
		string Extra4 = "Olives";
		string[] Peppers = {"Green Peppers", "Yellow Peppers", "Jalapeno Peppers"};
		int extraInt1 = 0;
		int extraInt2 = 0;
		int extraInt3 = 0;
		int extraInt4 = 0;
		int pepperInt = 0;
		int pepperInt2 = 0;
		extraInt1 = Random.Range (0, 2);
		extraInt2 = Random.Range (0, 2);
		extraInt3 = Random.Range (0, 2);
		extraInt4 = Random.Range (0, 2);
		pepperInt = Random.Range (0, 2);
		pepperInt2 = Random.Range (0, 3);
		if (extraInt1 == 0) {
			if (!(extraInt2 != 0 || extraInt3 != 0 || extraInt4 != 0 || pepperInt != 0)){
				Extra = Extra + ", and " + Extra1;
			}else{
				Extra = Extra + ", " + Extra1;
			}
		}
		if (extraInt2 == 1) {
			if (!(extraInt3 != 0 || extraInt4 != 0 || pepperInt != 0)){
				Extra = Extra + ", and " + Extra2;
			}else{
				Extra = Extra + ", " + Extra2;
			}
		}
		if (extraInt3 == 1) {
			if (!(extraInt4 != 0 || pepperInt != 0)){
				Extra = Extra + ", and " + Extra3;
			}else{
				Extra = Extra + ", " + Extra3;
			}
		}
		if (extraInt4 == 1) {
			if (!(pepperInt != 0)){
				Extra = Extra + ", and " + Extra4;
			}else{
				Extra = Extra + ", " + Extra4;
			}
		}
		if (pepperInt == 1) {
			Extra = Extra + ", and " + Peppers [pepperInt2];
		}
		return Extra;
	}
}