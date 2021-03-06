﻿using UnityEngine;
using NodeEditorFramework;

namespace BehavorTreeDesigner
{
	[Node(false, "Behavior/Root")]
	public class Root : BaseBehaviorNode
	{
		public override Node Create(Vector2 pos)
		{
			Root node = CreateInstance<Root>();
			base.Init(node);

			node.rect = new Rect(pos.x, pos.y, 100, 80);
			node.CreateOutput("Out", "Behave", NodeSide.Bottom, 50);

			return node;
		}

		public override NodeStatus Tick(BehaviorBlackboard data)
		{
			if(this.Outputs[0].connections.Count == 0)
			{
				Debug.LogError("Behavor Tree Designer\nRoot node is not connected.");
				return NodeStatus.ERROR;
			}

			BaseBehaviorNode node = (BaseBehaviorNode)this.Outputs[0].connections[0].body;
			NodeStatus status = node.Tick(data);

			if(status == NodeStatus.ERROR)
			{
				Debug.Log("Behavor Tree Designer\nError status returned.");
			}

			return status;
		}
	}
}
