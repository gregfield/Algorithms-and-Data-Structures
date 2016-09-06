#include "Traversals.h"


Traversals::Traversals(ListBox^ listBox)
{
	this->listbox = listBox;
}

void Traversals::PreorderTraversal(IntegerBinaryTreeNode^ inputRootNode)
{
	if (inputRootNode != nullptr)
	{
		int value = inputRootNode->getNodeValue();
		listbox->Items->Add(Convert::ToString(value));

		IntegerBinaryTreeNode^ leftRoot = inputRootNode->getLeftChild();
		PreorderTraversal(leftRoot);

		IntegerBinaryTreeNode^ rightRoot = inputRootNode->getRightChild();
		PreorderTraversal(rightRoot);
	}
}

void Traversals::InorderTraversal(IntegerBinaryTreeNode^ inputRootNode)
{
	if (inputRootNode != nullptr)
	{
		IntegerBinaryTreeNode^ leftRoot = inputRootNode->getLeftChild();
		InorderTraversal(leftRoot);

		int value = inputRootNode->getNodeValue();
		listbox->Items->Add(Convert::ToString(value));

		IntegerBinaryTreeNode^ rightRoot = inputRootNode->getRightChild();
		InorderTraversal(rightRoot);
	}
}


void Traversals::PostorderTraversal(IntegerBinaryTreeNode^ inputRootNode)
{
	if (inputRootNode != nullptr)
	{
		IntegerBinaryTreeNode^ leftRoot = inputRootNode->getLeftChild();
		PostorderTraversal(leftRoot);

		IntegerBinaryTreeNode^ rightRoot = inputRootNode->getRightChild();
		PostorderTraversal(rightRoot);

		int value = inputRootNode->getNodeValue();
		listbox->Items->Add(Convert::ToString(value));
	}
}
