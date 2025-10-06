public class Solution {
    public int NumIslands(char[][] grid) {
        int result = 0;

        for(int i = 0;i < grid.Length;i++){
            for(int j = 0; j < grid[0].Length;j++){
                if(grid[i][j] == '1'){
                    result++;
                    converter(grid,i,j);
                } 
            }
        }
        return result;
    }
    public void converter(char[][] grid,int n,int m){

        if(n < 0 || n >= grid.Length || m < 0 || m >= grid[0].Length) return;
        if(grid[n][m]=='0') return;

        grid[n][m] = '0';

        converter(grid,n+1,m);
        converter(grid,n,m+1);
        converter(grid,n-1,m);
        converter(grid,n,m-1);
        
    }
}