#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

ref class IntegerBinaryTreeNode
{
private:
	int nodeValue;
	IntegerBinaryTreeNode^ leftChild;
	IntegerBinaryTreeNode^ rightChild;

public:
	IntegerBinaryTreeNode(int startValue);

	void setNodeValue(int v)								{ nodeValue = v; }
	void setLeftChild(IntegerBinaryTreeNode^ newLeft)		{ leftChild = newLeft; }
	void setRightChild(IntegerBinaryTreeNode^ newRight)		{ rightChild = newRight; }

	int getNodeValue()							{ return nodeValue; }
	IntegerBinaryTreeNode^ getLeftChild()		{ return leftChild; }
	IntegerBinaryTreeNode^ getRightChild()		{ return rightChild; }
};

