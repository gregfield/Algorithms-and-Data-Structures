#include "nQueensTree.h"

nQueensTree::nQueensTree(int startDimension)
{
	dimension = startDimension;
	rootNode = gcnew ChessBoard(dimension);

} // end ctor

//=============================================================
// Recursive tree gen
// Each node's children hold the queens it already has, plus all queens in the next column over
void nQueensTree::recursiveTreeGen(ChessBoard^ %rootNodePtr, int currentColumn)
{
	// YOUR CODE HERE
	if (currentColumn < dimension)
	{
		for (int r = 0; r < dimension; r++)
		{
			ChessBoard^ newChessBoard = gcnew ChessBoard(dimension);
			newChessBoard->copyChessBoard(rootNodePtr);
			Queen^ newQueen = gcnew Queen(r, currentColumn);
			newChessBoard->addQueen(newQueen);
			rootNodePtr->addChildNode(newChessBoard);

			if (newChessBoard->IsLegal())
			{
				recursiveTreeGen(newChessBoard, currentColumn + 1);
			}
		}
	}
} // end recursiveTreeGen

//=============================================================
// Preorder Traverse and print
void nQueensTree::printTree(ChessBoard^ rootNodePtr, ListBox^ printBox)
{
	// Implied base case: Do nothing if rootNodePtr = nullptr
	if (rootNodePtr != nullptr)
	{
		//Print Self
		for (int q = 0; q<dimension; q++)
		{
			String^ queenString = "null, null";
			if (rootNodePtr->queens[q] != nullptr)
				queenString = rootNodePtr->queens[q]->ToString();

			printBox->Items->Add(queenString);
		}
		// Recurse down children

		for (int c = 0; c<dimension; c++)
		{
			printTree(rootNodePtr->childNodes[c], printBox);
		}
	}
}

//=============================================================
// Preorder Traverse and check for solutions
void nQueensTree::printSolutions(ChessBoard^ rootNodePtr, ListBox^ printBox)
{
	// Implied base case: Do nothing if rootNodePtr = nullptr
	if (rootNodePtr != nullptr)
	{
		//test Self and print if legal
		if ((rootNodePtr->IsLeaf()) && (rootNodePtr->IsLegal()))
		{

			printBox->Items->Add("__________________");
			rootNodePtr->drawBoard(printBox);

			/*Print Self
			for (int q=0; q<dimension; q++)
			printBox->Items->Add(rootNodePtr->queens[q]->ToString());
			*/

			printBox->Items->Add("__________________");
		}

		// Recurse down children

		for (int c = 0; c<dimension; c++)
		{
			printSolutions(rootNodePtr->childNodes[c], printBox);
		}
	}
}

