#include "BinaryTree.h"


BinaryTree::BinaryTree()
{
}

BinaryTree::BinaryTree(int rootValue)
{
	rootNode = gcnew IntegerBinaryTreeNode(rootValue);
}

BinaryTree::BinaryTree(int rootValue, BinaryTree^ leftSubTree, BinaryTree^ rightSubTree)
{
	rootNode = gcnew IntegerBinaryTreeNode(rootValue);
	IntegerBinaryTreeNode^ leftRoot = leftSubTree->getRootNode();
	IntegerBinaryTreeNode^ rightRoot = rightSubTree->getRootNode();

	rootNode->setLeftChild(leftRoot);
	rootNode->setRightChild(rightRoot);
}

void BinaryTree::addLeftSubTree(BinaryTree^ newLeftSubTree)
{
	IntegerBinaryTreeNode^ newSubRoot = newLeftSubTree->getRootNode();
	rootNode->setLeftChild(newSubRoot);
}

void BinaryTree::addRightSubTree(BinaryTree^ newRightSubTree)
{
	IntegerBinaryTreeNode^ newSubRoot = newRightSubTree->getRootNode();
	rootNode->setRightChild(newSubRoot);
}

void BinaryTree::makeLeftChildNode(int nodeValue)
{
	IntegerBinaryTreeNode^ newLeftChildNode = gcnew IntegerBinaryTreeNode(nodeValue);
	rootNode->setLeftChild(newLeftChildNode);
}

void BinaryTree::makeRightChildNode(int nodeValue)
{
	IntegerBinaryTreeNode^ newRightChildNode = gcnew IntegerBinaryTreeNode(nodeValue);
	rootNode->setRightChild(newRightChildNode);
}

void BinaryTree::setRootNodeValue(int newRootNodeValue)
{
	rootNode->setNodeValue(newRootNodeValue);
}

int BinaryTree::getRootNodeValue()
{
	return rootNode->getNodeValue();
}