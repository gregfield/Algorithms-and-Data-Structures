#pragma once
#include "BinaryTree.h"

ref class BinarySearchTree :
public BinaryTree
{
private:
	BinaryTree^ tree;
	Traversals^ traversal;
	int inspectionCount;
public:
	BinarySearchTree(ListBox^ listbox);
	BinarySearchTree(ListBox^ listbox, int rootValue);

	void InsertItem(BinarySearchNode^ %treeRootPtr, int insertValue);
	bool FindItem(BinarySearchNode^ inputRootNode, int targetValue);
	void AddNode(int nodeValue);
	String^ Search(int targetValue);
	void Sort();
	void ViewUnsrtoed();
};

