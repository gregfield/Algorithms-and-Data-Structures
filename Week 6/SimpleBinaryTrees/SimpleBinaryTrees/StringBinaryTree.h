#pragma once
#include "StringBinaryTreeNode.h"

ref class StringBinaryTree
{
	StringBinaryTreeNode^ rootNode;

public:
	StringBinaryTree();
	StringBinaryTree(String^ rootValue);
	StringBinaryTree(String^ rootValue, StringBinaryTree^ leftSubtree, StringBinaryTree^ rightSubTree);

	//difference between getting root nodes value and gettting its address
	void setRootNodeValue(String^ newRootNodeValue);
	String^ getRootNodeValue();
	StringBinaryTreeNode^ getRootNode()		{ return rootNode; }

	//tinker toy tree building methods
	void addLeftSubTree(StringBinaryTree^ newLeftSubTree);
	void addRightSubTree(StringBinaryTree^ newRightSubTree);
	void makeLeftChildNode(String^ nodeValue);
	void makeRightChildNode(String^ nodeValue);
};

