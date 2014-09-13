//
// ArithmeticExpression.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace XMLRules
{
	public class ArithmeticExpression : Altova.Node
	{
		#region Forward constructors
		public ArithmeticExpression() : base() { SetCollectionParents(); }
		public ArithmeticExpression(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ArithmeticExpression(XmlNode node) : base(node) { SetCollectionParents(); }
		public ArithmeticExpression(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Element, "", "SubExpression");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "SubExpression", i);
				InternalAdjustPrefix(DOMNode, true);
				new SubExpressionType(DOMNode).AdjustPrefix();
			}

			nCount = DomChildCount(NodeType.Element, "", "Value");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Value", i);
				InternalAdjustPrefix(DOMNode, true);
				new Value(DOMNode).AdjustPrefix();
			}
		}


		#region SubExpression accessor methods
		public int GetSubExpressionMinCount()
		{
			return 1;
		}

		public int SubExpressionMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSubExpressionMaxCount()
		{
			return 1;
		}

		public int SubExpressionMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSubExpressionCount()
		{
			return DomChildCount(NodeType.Element, "", "SubExpression");
		}

		public int SubExpressionCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "SubExpression");
			}
		}

		public bool HasSubExpression()
		{
			return HasDomChild(NodeType.Element, "", "SubExpression");
		}

		public SubExpressionType GetSubExpressionAt(int index)
		{
			return new SubExpressionType(GetDomChildAt(NodeType.Element, "", "SubExpression", index));
		}

		public SubExpressionType GetSubExpression()
		{
			return GetSubExpressionAt(0);
		}

		public SubExpressionType SubExpression
		{
			get
			{
				return GetSubExpressionAt(0);
			}
		}

		public void RemoveSubExpressionAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "SubExpression", index);
		}

		public void RemoveSubExpression()
		{
			while (HasSubExpression())
				RemoveSubExpressionAt(0);
		}

		public void AddSubExpression(SubExpressionType newValue)
		{
			AppendDomElement("", "SubExpression", newValue);
		}

		public void InsertSubExpressionAt(SubExpressionType newValue, int index)
		{
			InsertDomElementAt("", "SubExpression", index, newValue);
		}

		public void ReplaceSubExpressionAt(SubExpressionType newValue, int index)
		{
			ReplaceDomElementAt("", "SubExpression", index, newValue);
		}
		#endregion // SubExpression accessor methods

		#region SubExpression collection
        public SubExpressionCollection	MySubExpressions = new SubExpressionCollection( );

        public class SubExpressionCollection: IEnumerable
        {
            ArithmeticExpression parent;
            public ArithmeticExpression Parent
			{
				set
				{
					parent = value;
				}
			}
			public SubExpressionEnumerator GetEnumerator() 
			{
				return new SubExpressionEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SubExpressionEnumerator: IEnumerator 
        {
			int nIndex;
			ArithmeticExpression parent;
			public SubExpressionEnumerator(ArithmeticExpression par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.SubExpressionCount );
			}
			public SubExpressionType  Current 
			{
				get 
				{
					return(parent.GetSubExpressionAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // SubExpression collection

		#region Value accessor methods
		public int GetValueMinCount()
		{
			return 1;
		}

		public int ValueMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetValueMaxCount()
		{
			return 1;
		}

		public int ValueMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetValueCount()
		{
			return DomChildCount(NodeType.Element, "", "Value");
		}

		public int ValueCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Value");
			}
		}

		public bool HasValue()
		{
			return HasDomChild(NodeType.Element, "", "Value");
		}

		public Value GetValueAt(int index)
		{
			return new Value(GetDomChildAt(NodeType.Element, "", "Value", index));
		}

		public Value GetValue()
		{
			return GetValueAt(0);
		}

		public Value Value
		{
			get
			{
				return GetValueAt(0);
			}
		}

		public void RemoveValueAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Value", index);
		}

		public void RemoveValue()
		{
			while (HasValue())
				RemoveValueAt(0);
		}

		public void AddValue(Value newValue)
		{
			AppendDomElement("", "Value", newValue);
		}

		public void InsertValueAt(Value newValue, int index)
		{
			InsertDomElementAt("", "Value", index, newValue);
		}

		public void ReplaceValueAt(Value newValue, int index)
		{
			ReplaceDomElementAt("", "Value", index, newValue);
		}
		#endregion // Value accessor methods

		#region Value collection
        public ValueCollection	MyValues = new ValueCollection( );

        public class ValueCollection: IEnumerable
        {
            ArithmeticExpression parent;
            public ArithmeticExpression Parent
			{
				set
				{
					parent = value;
				}
			}
			public ValueEnumerator GetEnumerator() 
			{
				return new ValueEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ValueEnumerator: IEnumerator 
        {
			int nIndex;
			ArithmeticExpression parent;
			public ValueEnumerator(ArithmeticExpression par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.ValueCount );
			}
			public Value  Current 
			{
				get 
				{
					return(parent.GetValueAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // Value collection

        private void SetCollectionParents()
        {
            MySubExpressions.Parent = this; 
            MyValues.Parent = this; 
	}
}
}
