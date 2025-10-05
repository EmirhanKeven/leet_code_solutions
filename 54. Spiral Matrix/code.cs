public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        int right = matrix[0].Length - 1;
        int bottom = matrix.Length - 1;
        int[] result = new int[(right+1)*(bottom+1)];
        int left = 0;
        int top = 0;
        int index = 0;
        
       
        while(top <= bottom && right >= left){
            for(int j=left;j<=right;j++){
                result[index++] = matrix[top][j];
            }
            top += 1;
            for(int i = top;i<=bottom;i++){
                result[index++] = matrix[i][right];
            }
            right -= 1;
            
            if(bottom >= top){
                for(int k =right;k>=left;k--){
                    result[index++] = matrix[bottom][k];
                }
                bottom -=1;
            }
            if(right >= left){
                for(int f = bottom; f >= top; f--){
                    result[index++] = matrix[f][left];                
                }
                left += 1;
            }
        }
        return result;
    }
}