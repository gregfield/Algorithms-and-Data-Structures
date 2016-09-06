#pragma once
#include "BinaryTree.h"
#include "Traversals.h"
#include "ExpressionTree.h"

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

ref class Worker
{
public:
	enum class TraversalTypes
	{
		Preorder,
		Inorder,
		Postorder
	};

private:
	Traversals^ traversals;
	ListBox^ listbox;
	IntegerBinaryTreeNode^ rootNode;
	ExpressionTree^ globalTree1;
	ExpressionTree^ globalTree2;

public:
	Worker(ListBox^ listbox);

	void BuildTree();
	void BuildExpressionTree1();
	void BuildExpressionTree2();
	void RunTraversal(TraversalTypes type);
	void expressionParser();
};

