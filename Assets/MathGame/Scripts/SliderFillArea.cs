using UnityEngine;
using UnityEngine.UI;
using System.Collections;
namespace ApeGaming.MathGame
{
	public class SliderFillArea : MonoBehaviour
	{

		public RectTransform rect;

		void OnEnable(){
			rect.anchoredPosition = Vector2.zero;

		}
	}
}