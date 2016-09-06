#pragma once
#include "BinaryTree.h"

ref class Traversals
{
private:
	ListBox^ listbox;
public:
	Traversals(ListBox^ listBox);

	void PreorderTraversal(IntegerBinaryTreeNode^ inputRootNode);
	void InorderTraversal(IntegerBinaryTreeNode^ inputRootNode);
	void PostorderTraversal(IntegerBinaryTreeNode^ inputRootNode);
};

