#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

ref class StringBinaryTreeNode
{
private:
	String^ nodeValue;
	StringBinaryTreeNode^ leftChild;
	StringBinaryTreeNode^ rightChild;

public:
	StringBinaryTreeNode(String^ startString);

	void setNodeValue(String^ v)							{ nodeValue = v; }
	void setLeftChild(StringBinaryTreeNode^ newLeft)		{ leftChild = newLeft; }
	void setRightChild(StringBinaryTreeNode^ newRight)		{ rightChild = newRight; }

	String^ getNodeValue()						{ return nodeValue; }
	StringBinaryTreeNode^ getLeftChild()		{ return leftChild; }
	StringBinaryTreeNode^ getRightChild()		{ return rightChild; }
};

