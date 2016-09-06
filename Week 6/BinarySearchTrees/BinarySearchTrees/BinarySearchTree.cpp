#include "BinarySearchTree.h"


BinarySearchTree::BinarySearchTree(ListBox^ listbox)
{
	traversal = gcnew Traversals(listbox);
}

BinarySearchTree::BinarySearchTree(ListBox^ listbox, int rootValue)
{
	traversal = gcnew Traversals(listbox);
	tree = gcnew BinaryTree(rootValue);
}


void BinarySearchTree::InsertItem(BinarySearchNode^ %treeRootPtr, int insertValue)
{
	if (treeRootPtr == nullptr)
	{
		BinarySearchNode^ newNode = gcnew BinarySearchNode(insertValue);
		treeRootPtr = newNode;
	}
	else
	{
		if (insertValue < treeRootPtr->getNodeValue())
		{
			//left
			InsertItem(treeRootPtr->leftChild, insertValue);
		}
		else
		{
			//right
			InsertItem(treeRootPtr->rightChild, insertValue);
		}
	}
}

bool BinarySearchTree::FindItem(BinarySearchNode^ inputRootNode, int targetValue)
{
	if (inputRootNode == nullptr)
	{
		inspectionCount += 2;
		return false;
	}
	else
	{
		if (inputRootNode->getNodeValue() == targetValue)
		{
			inspectionCount += 2;
			return true;
		}
		else
		{
			if (targetValue < inputRootNode->getNodeValue())
			{
				inspectionCount += 2;
				return FindItem(inputRootNode->leftChild, targetValue);
			}
			else
			{
				inspectionCount++;
				return FindItem(inputRootNode->rightChild, targetValue);
			}
		}
	}
}

void BinarySearchTree::AddNode(int nodeValue)
{
	InsertItem(rootNode, nodeValue);
}

String^ BinarySearchTree::Search(int targetValue)
{
	inspectionCount = 0;
	bool result = FindItem(rootNode, targetValue);
	String^ foundResult = targetValue.ToString() + " Was Found" + " Count: "+ inspectionCount;
	String^ notFoundResult = "Value Not Found" + " Count: " + inspectionCount;

	if (result)
	{
		return foundResult;
	}
	else
	{
		return notFoundResult;
	}
}

void  BinarySearchTree::Sort()
{
	traversal->InorderTraversal(rootNode);
}

void BinarySearchTree::ViewUnsrtoed()
{
	traversal->PreorderTraversal(rootNode);
}