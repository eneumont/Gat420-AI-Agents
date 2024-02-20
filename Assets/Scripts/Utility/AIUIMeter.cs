using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//public class AIUIMeter : MonoBehaviour {
//	[SerializeField] TMP_Text label;
//	[SerializeField] Slider slider;
//	[SerializeField] Image image;
	
//	public Vector3 position {
//		set {
//			Debug.DrawLine(value, value + Vector3.up * 3);
//			Vector2 viewportPoint = Camera.main.WorldToViewportPoint(value);
//			GetComponent<RectTransform>().anchorMin = viewportPoint;
//			GetComponent<RectTransform>().anchorMax = viewportPoint;
//		}
//	}

//	public float value {
//		set {
//			slider.value = value;
//		}
//	}

//	public string text {
//		set { 
//			label.text = value; 
//		}
//	}

//	public bool visible {
//		set {
//			gameObject.SetActive(value);
//		}
//	}

//	public float alpha {
//		set {
//			Color color = image.color;
//			color.a = value;
//			image.color = color;
//		}
//	}
//}

// AIUIMeter class is responsible for managing UI elements like text label, slider, and image
public class AIUIMeter : MonoBehaviour {
	// Text label for displaying information
	[SerializeField] TMP_Text label;
	// Slider for representing a value visually
	[SerializeField] Slider slider;
	// Image for additional visual representation
	[SerializeField] Image image;

	// Property to set the position of the meter
	public Vector3 position {
		set {
			// Draw a debug line from the specified position
			Debug.DrawLine(value, value + Vector3.up * 3);
			// Convert the world position to a viewport point for UI anchoring
			Vector2 viewportPoint = Camera.main.WorldToViewportPoint(value);
			// Set the anchor points of the RectTransform to match the viewport position
			GetComponent<RectTransform>().anchorMin = viewportPoint;
			GetComponent<RectTransform>().anchorMax = viewportPoint;
		}
	}

	// Property to set the value of the meter (slider)
	public float value {
		set {
			// Set the value of the slider
			slider.value = value;
		}
	}

	// Property to set the text displayed on the label
	public string text {
		set {
			// Set the text of the label
			label.text = value;
		}
	}

	// Property to control the visibility of the meter
	public bool visible {
		set {
			// Set the visibility of the game object
			gameObject.SetActive(value);
		}
	}

	// Property to set the alpha value of the meter's image
	public float alpha {
		set {
			// Get the current color of the image
			Color color = image.color;
			// Update the alpha value
			color.a = value;
			// Apply the updated color to the image
			image.color = color;
		}
	}
}