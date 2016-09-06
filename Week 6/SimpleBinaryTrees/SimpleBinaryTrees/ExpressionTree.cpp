#include "ExpressionTree.h"

ExpressionTree::ExpressionTree()
{
}

ExpressionTree::ExpressionTree(String^ rootValue)
{
	tree = gcnew StringBinaryTree(rootValue);
}

ExpressionTree::ExpressionTree(String^ rootValue, StringBinaryTree^ leftSubtree, StringBinaryTree^ rightSubTree)
{
	tree = gcnew StringBinaryTree(rootValue);
	tree->addLeftSubTree(leftSubtree);
	tree->addRightSubTree(rightSubTree);
}

int ExpressionTree::parseExpressionTree(StringBinaryTreeNode^ inputRootNode)
{
	if (inputRootNode)
	{
		if (inputRootNode->getLeftChild())
		{
			return Convert::ToInt32(inputRootNode->getNodeValue());
		}
		else
		{
			int left = parseExpressionTree(inputRootNode->getLeftChild());
			int right = parseExpressionTree(inputRootNode->getRightChild());
			String^ nodeValue = inputRootNode->getNodeValue();
			if (nodeValue->Equals("+"))
			{
				return left + right;
			}
			if (nodeValue->Equals("*"))
			{
				return left * right;
			}
			if (nodeValue->Equals("/"))
			{
				return left / right;
			}
			if (nodeValue->Equals("-"))
			{
				return left - right;
			}
		}
	}
}

String^ ExpressionTree::postfixExpressionTree(StringBinaryTreeNode^ inputRootNode)
{
	if (inputRootNode)
	{
		StringBinaryTreeNode^ leftRootNode = inputRootNode->getLeftChild();
		String^ left = postfixExpressionTree(leftRootNode);

		StringBinaryTreeNode^ rightRootNode = inputRootNode->getRightChild();
		String^ right = postfixExpressionTree(rightRootNode);

		return left + right + inputRootNode->getNodeValue();
	}
}
