using UnityEngine;
using System.Collections;

namespace ApeGaming.MathGame
{
	public class PlayButton : ButtonHelper 
	{
		override public void OnClicked()
		{
			print ("OnClicked : " + gameObject.name);
			menuManager.GoToGame();
			RemoveListener();
		}
	}
}