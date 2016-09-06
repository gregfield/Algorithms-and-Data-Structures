#include "Queen.h"

Queen::Queen(int startRow, int startColumn)
{
	row = startRow;
	column = startColumn;
}

String^ Queen::ToString()
{
	return row.ToString() + "," + column.ToString();
}
