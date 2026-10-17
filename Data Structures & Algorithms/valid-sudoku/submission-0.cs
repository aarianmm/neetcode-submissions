public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rowSeen = new bool[9,9];
        bool[,] colSeen = new bool[9,9];
        bool[,] sqrSeen = new bool[9,9];
        for(int row=0; row<9; row++){
            for(int col=0; col<9; col++){
                int val = board[row][col];
                if(val=='.'){
                    continue;
                }
                val = val -'0'-1;
                int sqrIndex = col/3 + 3*(row/3);
                if(rowSeen[row, val] || colSeen[col ,val] || sqrSeen[sqrIndex, val]){
                    return false;
                }
                rowSeen[row, val]=true;
                colSeen[col, val]=true;
                sqrSeen[sqrIndex, val]=true;
            }
        }
        return true;
    }
}
