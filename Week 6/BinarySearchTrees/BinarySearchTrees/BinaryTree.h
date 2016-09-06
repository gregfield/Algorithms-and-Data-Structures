#pragma once
#include "BinarySearchNode.h"
#include "Traversals.h"

ref class BinaryTree
{
protected:
	BinarySearchNode^ rootNode;

public:
	BinaryTree();
	BinaryTree(int rootValue);;

	//difference between getting root nodes value and gettting its address
	void setRootNodeValue(int newRootNodeValue);
	int getRootNodeValue();
	BinarySearchNode^ getRootNode()		{ return rootNode; }
};

