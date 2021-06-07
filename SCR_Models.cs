using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SCR_Models
{
	public enum PlayerStance
	{
		Stand,
		Crouch,
		Prone
	}

	[Serializable]
    public class PlayerSettingsModel
    {
    	[Header("ViewSettings")]
    	public float ViewXSensitivity;
    	public float ViewYSensitivity;

    	public bool ViewXInverted;
    	public bool ViewYInverted;

    	[Header("Movement - Running")]
    	public float RunningForwardSpeed;
    	public float RunningStrafeSpeed;

    	[Header("Movement - Walking")]
    	public float WalkingForwardSpeed;
    	public float WalkingStrafeSpeed;
    	public float WalkingBackwardSpeed;

    	[Header("Jumping")]
    	public float JumpingHeight;
    	public float JumpingFalloff;
    }

	[Serializable]
    public class CharacterStance
    {
    	public float CameraHeight;
    	public CapsuleCollider StanceCollider;
    }
}
