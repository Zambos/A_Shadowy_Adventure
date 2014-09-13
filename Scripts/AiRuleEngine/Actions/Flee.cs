using System.Collections;
using UnityEngine;

namespace AiRuleEngine
{
	[ScriptName("Flee")]
	[ScriptCategory("Movement")]
    public class Flee : BaseAction
	{
		public GameObject destinationObject;
		public int speed;

		public override bool Execute()
		{
            Vector3 destinationVector = destinationObject.transform.position;
            GameObject movingObject = GetGameObject();
			movingObject.rigidbody.AddForce(-(destinationVector - movingObject.transform.position).normalized * movingObject.rigidbody.mass * speed);
			
            return true;
		}
	}
}
