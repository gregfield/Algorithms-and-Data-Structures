#include "StringBinaryTree.h"


StringBinaryTree::StringBinaryTree()
{
}

StringBinaryTree::StringBinaryTree(String^ rootValue)
{
	rootNode = gcnew StringBinaryTreeNode(rootValue);
}

StringBinaryTree::StringBinaryTree(String^ rootValue, StringBinaryTree^ leftSubTree, StringBinaryTree^ rightSubTree)
{
	rootNode = gcnew StringBinaryTreeNode(rootValue);
	StringBinaryTreeNode^ leftRoot = leftSubTree->getRootNode();
	StringBinaryTreeNode^ rightRoot = rightSubTree->getRootNode();

	rootNode->setLeftChild(leftRoot);
	rootNode->setRightChild(rightRoot);
}

void StringBinaryTree::addLeftSubTree(StringBinaryTree^ newLeftSubTree)
{
	StringBinaryTreeNode^ newSubRoot = newLeftSubTree->getRootNode();
	rootNode->setLeftChild(newSubRoot);
}

void StringBinaryTree::addRightSubTree(StringBinaryTree^ newRightSubTree)
{
	StringBinaryTreeNode^ newSubRoot = newRightSubTree->getRootNode();
	rootNode->setRightChild(newSubRoot);
}

void StringBinaryTree::makeLeftChildNode(String^ nodeValue)
{
	StringBinaryTreeNode^ newLeftChildNode = gcnew StringBinaryTreeNode(nodeValue);
	rootNode->setLeftChild(newLeftChildNode);
}

void StringBinaryTree::makeRightChildNode(String^ nodeValue)
{
	StringBinaryTreeNode^ newRightChildNode = gcnew StringBinaryTreeNode(nodeValue);
	rootNode->setRightChild(newRightChildNode);
}

void StringBinaryTree::setRootNodeValue(String^ newRootNodeValue)
{
	rootNode->setNodeValue(newRootNodeValue);
}

String^ StringBinaryTree::getRootNodeValue()
{
	return rootNode->getNodeValue();
}
