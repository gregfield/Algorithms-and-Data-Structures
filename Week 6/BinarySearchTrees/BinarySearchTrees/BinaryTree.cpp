#include "BinaryTree.h"



BinaryTree::BinaryTree()
{
}

BinaryTree::BinaryTree(int rootValue)
{
	rootNode = gcnew BinarySearchNode(rootValue);
}

void BinaryTree::setRootNodeValue(int newRootNodeValue)
{
	rootNode->setNodeValue(newRootNodeValue);
}

int BinaryTree::getRootNodeValue()
{
	return rootNode->getNodeValue();
}
