using UnityEngine;
using System.Collections;

namespace ApeGaming.MathGame
{
	public class ButtonCloseSetting : ButtonHelper 
	{
		override public void OnClicked()
		{
			print ("OnClicked : " + gameObject.name);
			menuManager.CloseSettings ();
			RemoveListener();
		}
	}
}