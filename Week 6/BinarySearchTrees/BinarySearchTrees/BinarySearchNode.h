#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

ref class BinarySearchNode
{
private:
	int nodeValue;

public:
	BinarySearchNode^ leftChild;
	BinarySearchNode^ rightChild;

	BinarySearchNode(int startValue);

	void setNodeValue(int v)							{ nodeValue = v; }
	int getNodeValue()						{ return nodeValue; }
};

