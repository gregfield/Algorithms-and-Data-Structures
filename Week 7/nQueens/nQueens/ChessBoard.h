#pragma once
#include "Queen.h"
#include <stdlib.h> 

using namespace System::Windows::Forms;

// Contains up to n placements, representing the location of the n queens
// Interior nodes have placements unfilled; leaf nodes have all placements filled

// Also contains an array of n child node pointers

ref class ChessBoard
{
	int dimension;

	// Queens placed in order by column. That is, queens[0] is in the first column,
	// queens[1] is in the second column, etc.
public: array<Queen^>^ queens;

		// Child node pointers
public:array<ChessBoard^>^ childNodes;

	   int childNodeCount;

public:
	ChessBoard(int startDimension);

	// Add a queen to the board represented by this node
	void addQueen(Queen^ q);

	// Add a child node to this node
	void addChildNode(ChessBoard^ child);

	void copyChessBoard(ChessBoard^ boardToCopy);

	void drawBoard(ListBox^ drawBox);

	bool IsLeaf();
	bool IsLegal();
};


