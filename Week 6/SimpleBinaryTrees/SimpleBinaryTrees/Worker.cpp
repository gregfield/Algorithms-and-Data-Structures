#include "Worker.h"


Worker::Worker(ListBox^ listbox)
{
	this->listbox = listbox;
	traversals = gcnew Traversals(listbox);
}

void Worker::BuildTree()
{
	BinaryTree^ lt1 = gcnew BinaryTree(6);
	lt1->makeLeftChildNode(9);

	BinaryTree^ lt2 = gcnew BinaryTree(4);
	lt2->addLeftSubTree(lt1);

	BinaryTree^ rt1 = gcnew BinaryTree(5);
	rt1->makeLeftChildNode(7);
	rt1->makeRightChildNode(8);

	BinaryTree^ lt3 = gcnew BinaryTree(2, lt2, rt1);

	BinaryTree^ rootTree = gcnew BinaryTree(1);
	rootTree->addLeftSubTree(lt3);
	rootTree->makeRightChildNode(3);

	rootNode = rootTree->getRootNode();
}

void Worker::BuildExpressionTree1()
{
	ExpressionTree^ lt1 = gcnew ExpressionTree("2");
	ExpressionTree^ lt2 = gcnew ExpressionTree("6");
	ExpressionTree^ lt3 = gcnew ExpressionTree("*", lt1, lt2);
	ExpressionTree^ lt4 = gcnew ExpressionTree("3");
	ExpressionTree^ lt5 = gcnew ExpressionTree("+", lt3, lt4);

	globalTree1 = lt5;
}
void Worker::BuildExpressionTree2()
{
	ExpressionTree^ lt1 = gcnew ExpressionTree("6");
	ExpressionTree^ lt2 = gcnew ExpressionTree("3");
	ExpressionTree^ lt3 = gcnew ExpressionTree("+", lt1, lt2);
	ExpressionTree^ lt4 = gcnew ExpressionTree("2");
	ExpressionTree^ lt5 = gcnew ExpressionTree("*", lt3, lt4);

	globalTree2 = lt5;
}

void Worker::RunTraversal(TraversalTypes type)
{
	switch (type)
	{
	case TraversalTypes::Preorder:
		traversals->PreorderTraversal(rootNode);
		break;
	case TraversalTypes::Inorder:
		traversals->InorderTraversal(rootNode);
		break;
	case TraversalTypes::Postorder:
		traversals->PostorderTraversal(rootNode);
		break;
	default:
		break;
	}
}

void Worker::expressionParser()
{
	listbox->Items->Add(Convert::ToString(globalTree1->parseExpressionTree(globalTree1->getRootNode())));
	listbox->Items->Add(Convert::ToString(globalTree2->parseExpressionTree(globalTree2->getRootNode())));
	listbox->Items->Add(Convert::ToString(globalTree1->postfixExpressionTree(globalTree1->getRootNode())));
	listbox->Items->Add(Convert::ToString(globalTree2->postfixExpressionTree(globalTree2->getRootNode())));
}



