using UnityEngine;
using System.Collections;
using UnityEngine.UI;   //Allows us to use UI.

//Player inherits from MovingObject, our base class for objects that can move, Enemy also inherits from this.
public class movimientoalternativo : MovingObject
{
	
	private Vector2 touchOrigin = -Vector2.one; //Used to store location of screen touch origin for mobile controls.


	//Start overrides the Start function of MovingObject
	protected override void Start ()
	{

		//Call the Start function of the MovingObject base class.
		base.Start ();
	}


	//This function is called when the behaviour becomes disabled or inactive.
	private void OnDisable ()
	{
		//When Player object is disabled, store the current local food total in the GameManager so it can be re-loaded in next level.
		GameManager.instance.playerFoodPoints = food;
	}


	private void Update ()
	{
		//If it's not the player's turn, exit the function.
		if(!GameManager.instance.playersTurn) return;

		int horizontal = 0;     //Used to store the horizontal move direction.
		int vertical = 0;       //Used to store the vertical move direction.

		//Check if we are running either in the Unity editor or in a standalone build.
		#if UNITY_STANDALONE || UNITY_WEBPLAYER

		//Get input from the input manager, round it to an integer and store in horizontal to set x axis move direction
		horizontal = (int) (Input.GetAxisRaw ("Horizontal"));

		//Get input from the input manager, round it to an integer and store in vertical to set y axis move direction
		vertical = (int) (Input.GetAxisRaw ("Vertical"));

		//Check if moving horizontally, if so set vertical to zero.
		if(horizontal != 0)
		{
			vertical = 0;
		}
		//Check if we are running on iOS, Android, Windows Phone 8 or Unity iPhone
		#elif UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE

	

		#endif //End of mobile platform dependendent compilation section started above with #elif
		//Check if we have a non-zero value for horizontal or vertical
		if(horizontal != 0 || vertical != 0)
		{
			//Call AttemptMove passing in the generic parameter Wall, since that is what Player may interact with if they encounter one (by attacking it)
			//Pass in horizontal and vertical as parameters to specify the direction to move Player in.
			AttemptMove<Wall> (horizontal, vertical);
		}
	}


}