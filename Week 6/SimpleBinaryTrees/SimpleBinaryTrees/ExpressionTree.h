#pragma once
#include "StringBinaryTree.h"

ref class ExpressionTree :
public StringBinaryTree
{
private:
	StringBinaryTree^ tree;
public:
	ExpressionTree();
	ExpressionTree(String^ rootValue);
	ExpressionTree(String^ rootValue, StringBinaryTree^ leftSubtree, StringBinaryTree^ rightSubTree);

	int parseExpressionTree(StringBinaryTreeNode^ inputRootNode);
	String^ postfixExpressionTree(StringBinaryTreeNode^ inputRootNode);
};

