#include "ChessBoard.h"

ChessBoard::ChessBoard(int startDimension)
{
	dimension = startDimension;

	queens = gcnew array<Queen^>(dimension);
	childNodes = gcnew array<ChessBoard^>(dimension);

	childNodeCount = 0;

	// Set all pointers to clean null
	for (int i = 0; i<dimension; i++)
	{
		queens[i] = nullptr;
		childNodes[i] = nullptr;
	}


}

void ChessBoard::copyChessBoard(ChessBoard^ boardToCopy)
{
	for (int c = 0; c<dimension; c++)
	{
		queens[c] = boardToCopy->queens[c];
	}
}

void ChessBoard::drawBoard(ListBox^ drawBox)
{
	// queens should be in the array in row order
	// rotate for r,c problem
	for (int q = 0; q<dimension; q++)
	{
		String^ queenString = "";

		int r = queens[q]->getRow();

		for (int loc = 0; loc<dimension; loc++)
		{
			if (loc == r)
				queenString += "Q ";
			else
				queenString += "* ";
		}
		drawBox->Items->Add(queenString);
	}
}

void ChessBoard::addQueen(Queen^ q)
{
	int qColumn = q->getColumn();
	queens[qColumn] = q;
}



void ChessBoard::addChildNode(ChessBoard^ child)
{
	// Needs error checking
	childNodes[childNodeCount] = child;
	childNodeCount++;
}

bool ChessBoard::IsLegal()
{
	int queenCount = 1;
	//checks rows and columns
	for each(Queen^ q in queens)
	{	
		for (int i = queenCount; i < queens->Length; i++)
		{	
			if (queens[i] != nullptr)
			{
				if (q->getRow() == queens[i]->getRow())
				{
					return false;
				}
				if (q->getColumn() == queens[i]->getColumn())
				{
					return false;
				}

				int dRow = q->getRow() - queens[i]->getRow();
				int dColumn = q->getColumn() - queens[i]->getColumn();
				if (abs(dRow) == abs(dColumn))
				{
					return false;
				}
			}
		}
		queenCount++;
	}



	return true;
}

//===================================
bool ChessBoard::IsLeaf()
{
	// if all n Queens are defined, you are a leaf
	for (int q = 0; q<dimension; q++)
	{
		if (queens[q] == nullptr)
			return false;
	}

	// if you made it here, all queens are filled, so you are a leaf
	return true;
}
