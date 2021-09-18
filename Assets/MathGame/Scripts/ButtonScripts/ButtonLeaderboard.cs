using UnityEngine;
using System.Collections;
#if ApeGaming_LEADERBOARD
using ApeGaming.social;
#endif

namespace ApeGaming.MathGame
{
	public class ButtonLeaderboard : ButtonHelper 
	{
		override public void OnClicked()
		{
			OnClickedOpenLeaderboard();
		}

		/// <summary>
		/// If player clics on the leaderbord button, we call this method. Works only on mobile (iOS & Android)
		/// </summary>
		public void OnClickedOpenLeaderboard()
		{
			#if ApeGaming_LEADERBOARD
			LeaderboardManager.ShowLeaderboardUI();
			#else
			Debug.LogWarning("OnClickedOpenLeaderboard");
			#endif
		}

	}
}