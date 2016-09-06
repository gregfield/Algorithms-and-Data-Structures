#pragma once
#include "IntegerBinaryTreeNode.h"

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

ref class BinaryTree
{
protected:
	IntegerBinaryTreeNode^ rootNode;

public:
	BinaryTree();
	BinaryTree(int rootValue);
	BinaryTree(int rootValue, BinaryTree^ leftSubtree, BinaryTree^ rightSubTree);

	//difference between getting root nodes value and gettting its address
	void setRootNodeValue(int newRootNodeValue);
	int getRootNodeValue();
	IntegerBinaryTreeNode^ getRootNode()		{ return rootNode; }

	//tinker toy tree building methods
	void addLeftSubTree(BinaryTree^ newLeftSubTree);
	void addRightSubTree(BinaryTree^ newRightSubTree);
	void makeLeftChildNode(int nodeValue);
	void makeRightChildNode(int nodeValue);
};

