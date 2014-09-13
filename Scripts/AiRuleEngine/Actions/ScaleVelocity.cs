using System.Collections;
using UnityEngine;
	
namespace AiRuleEngine
{
	[ScriptName("ScaleVelocity")]
	[ScriptCategory("Movement")]
	
    public class ScaleVelocity : BaseAction
	{
		public float percentage;
		
        public override bool Execute()
		{
			GetGameObject().rigidbody.velocity *= (percentage / 100f);
			
            return true; 
		}
	}
}
