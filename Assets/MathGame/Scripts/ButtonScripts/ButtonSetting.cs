using UnityEngine;
using System.Collections;

namespace ApeGaming.MathGame
{
	public class ButtonSetting : ButtonHelper 
	{
		override public void OnClicked()
		{
			print ("OnClicked : " + gameObject.name);
			menuManager.OpenSettings ();
			RemoveListener();
		}
	}
}