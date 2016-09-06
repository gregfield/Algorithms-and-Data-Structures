#pragma once
#pragma once

using namespace System;

ref class Queen
{
	int row;
	int column;

public:
	Queen(int startRow, int startColumn);

	int getRow()			{ return row; }
	int getColumn()			{ return column; }

	void setRow(int r)		{ row = r; }
	void setColumn(int c)	{ column = c; }
	virtual String^ ToString() override;
};

