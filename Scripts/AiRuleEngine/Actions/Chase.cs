using System.Collections;
using UnityEngine;

namespace AiRuleEngine
{
	[ScriptName("Chase")]
	[ScriptCategory("Movement")]
	
    public class Chase : BaseAction
	{
		public GameObject destinationObject;
		public int speed;
	
		public override bool Execute()
		{
            Vector3 destinationVector = destinationObject.transform.position;
            GameObject movingObject = GetGameObject();
			movingObject.rigidbody.AddForce((destinationVector - movingObject.transform.position).normalized * movingObject.rigidbody.mass * speed);

			return true;
		}
	}
}
