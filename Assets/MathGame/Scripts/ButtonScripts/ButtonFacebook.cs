﻿using UnityEngine;
using System.Collections;

namespace ApeGaming.MathGame
{
	public class ButtonFacebook : MonoBehaviour
	{

		public void OnClicked(){

			string facebookApp = "fb://profile/515431001924232" ;
			string facebookAddress = "https://www.facebook.com/ApeGaming";

			float startTime;
			startTime = Time.timeSinceLevelLoad;

			//open the facebook app
			Application.OpenURL(facebookApp);

			if (Time.timeSinceLevelLoad - startTime <= 1f)
			{
				//fail. Open safari.
				Application.OpenURL(facebookAddress);
			}
		}
	}
}