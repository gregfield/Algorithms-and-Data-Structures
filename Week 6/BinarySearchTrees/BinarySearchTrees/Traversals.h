#pragma once
#include "BinarySearchNode.h"

ref class Traversals
{
private:
	ListBox^ listbox;
public:
	Traversals(ListBox^ listBox);

	void PreorderTraversal(BinarySearchNode^ inputRootNode);
	void InorderTraversal(BinarySearchNode^ inputRootNode);
	void PostorderTraversal(BinarySearchNode^ inputRootNode);
};

