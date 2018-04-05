private void HighlightDiagonal2()
        {
            int row = 0;
            int col = 2; 
            while (row < 3 && col >= 0)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
                row++;
                col--;
            }
        }
		
private void HighlightRow(int row)
        {
            for (int col = 0; col < 3; col++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }
		
private bool IsColumnWinner(int col)
        {
            if (GetSquare(0, col).Text == GetSquare(1, col).Text && GetSquare(0, col).Text == GetSquare(2, col).Text && GetSquare(0, col).Text != "")
            {
                HighlightColumn(col);
                return true;
            }
            else
            {
                return false;
            }
        }
		
private bool IsAnyColumnWinner()
        {
            bool winner = false;    // Set to true if there is a winner based on a row.
            for (int col = 0; col < 3; col++)
            {
                if (IsColumnWinner(col))
                    winner = true;
            }
            return winner;
        }
		
private bool IsFull()
        {
            bool full = true;   // Set to false when encounter an empty string is a cell.
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Label lab = GetSquare(row, col);
                    if (lab.Text == "")
                    {
                        full = false;
                    }
                }
            }
            return full;
        }