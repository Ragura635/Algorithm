using System;

public class Solution {
    public long solution(int a, int b) {
        
        int tempA = Math.Max(a, b);
        int tempB = Math.Min(a, b);
        
        long answer = (long)(tempA + tempB) * (tempA - tempB + 1) / 2;
        return answer;
    }
}

