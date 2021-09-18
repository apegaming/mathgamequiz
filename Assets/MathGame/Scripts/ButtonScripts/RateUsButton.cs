using UnityEngine;
using System.Collections;

namespace ApeGaming.MathGame
{
	public class RateUsButton : ButtonHelper 
	{
		override public void OnClicked()
		{
			print ("OnClicked : " + gameObject.name);

		}
	}
}