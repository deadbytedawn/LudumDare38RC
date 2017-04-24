using UnityEngine;
using CnControls;

// Just in case so no "duplicate definition" stuff shows up
namespace UnityStandardAssets.Copy._2D{
	[RequireComponent(typeof (TopDownCharacter2D))]
	public class TopDown2DUserControl : MonoBehaviour {

		private TopDownCharacter2D m_Character;
		private bool m_Jump;

		private void Awake()
		{
			m_Character = GetComponent<TopDownCharacter2D>();
		}

		private void Update()
		{
			if (!m_Jump)
			{
				// Read the jump input in Update so button presses aren't missed.
				m_Jump = CnInputManager.GetButtonDown("Jump");
			}
		}

		private void FixedUpdate()
		{
			float h = CnInputManager.GetAxis("Horizontal");
			float v = CnInputManager.GetAxis ("Vertical");
			// Pass all parameters to the character control script.
			m_Character.Move(v, h, m_Jump);
			m_Jump = false;


		}
	}
}



