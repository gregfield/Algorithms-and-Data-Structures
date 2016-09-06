#include "Traversals.h"


Traversals::Traversals(ListBox^ listBox)
{
	this->listbox = listBox;
}

void Traversals::PreorderTraversal(BinarySearchNode^ inputRootNode)
{
	if (inputRootNode != nullptr)
	{
		int value = inputRootNode->getNodeValue();
		listbox->Items->Add(Convert::ToString(value));

		BinarySearchNode^ leftRoot = inputRootNode->leftChild;
		PreorderTraversal(leftRoot);

		BinarySearchNode^ rightRoot = inputRootNode->rightChild;
		PreorderTraversal(rightRoot);
	}
}

void Traversals::InorderTraversal(BinarySearchNode^ inputRootNode)
{
	if (inputRootNode != nullptr)
	{
		BinarySearchNode^ leftRoot = inputRootNode->leftChild;
		InorderTraversal(leftRoot);

		int value = inputRootNode->getNodeValue();
		listbox->Items->Add(Convert::ToString(value));

		BinarySearchNode^ rightRoot = inputRootNode->rightChild;
		InorderTraversal(rightRoot);
	}
}


void Traversals::PostorderTraversal(BinarySearchNode^ inputRootNode)
{
	if (inputRootNode != nullptr)
	{
		BinarySearchNode^ leftRoot = inputRootNode->leftChild;
		PostorderTraversal(leftRoot);

		BinarySearchNode^ rightRoot = inputRootNode->rightChild;
		PostorderTraversal(rightRoot);

		int value = inputRootNode->getNodeValue();
		listbox->Items->Add(Convert::ToString(value));
	}
}
