#pragma once
#pragma once
#include "ChessBoard.h"

using namespace System::Windows::Forms;

// The nQueensTree is comprised of ChessBoard nodes
// The root node is an empty chessboard. The children of the root node
// have a queen placed in column 0. The leftmost child is in row 0, the next child
// is in row 1, etc.
// At each subsequent level L of the tree, the nodes have an additional queen placed in 
// column L; the children of each node are the n row placements.

ref class nQueensTree
{
	int dimension;
public: ChessBoard^ rootNode;

public:

	nQueensTree(int startDimension);

	void recursiveTreeGen(ChessBoard^ %rootNodePtr, int currentColumn);

	void printTree(ChessBoard^ rootNodePtr, ListBox^ printBox);

	void printSolutions(ChessBoard^ rootNodePtr, ListBox^ printBox);
};

