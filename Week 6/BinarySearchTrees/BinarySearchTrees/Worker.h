#pragma once
#include "BinarySearchTree.h"

ref class Worker
{
private:
	BinarySearchTree^ searchTree;
	Random^ randGen;
	ListBox^ listBox;

public:
	Worker(ListBox^ listBox);

	void CreateRandomTree();
	void SearchTree(int value);
	void ViewSort();
	void ViewUnsortedTree();
};

