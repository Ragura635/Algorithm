using System;

public class Solution {
    public int[] solution(int m, int n, int startX, int startY, int[,] balls) {
        int[] answer = new int[balls.GetLength(0)];

        for (int i = 0; i < answer.Length; i++)
        {
            pos origin = new pos(balls[i, 0], balls[i, 1], startX, startY);
            
            pos tar1 = new pos(-origin.x, origin.y, startX, startY);
            pos tar2 = new pos(2*m - origin.x, origin.y, startX, startY);
            pos tar3 = new pos(origin.x, -origin.y, startX, startY);
            pos tar4 = new pos(origin.x, 2*n - origin.y, startX, startY);
            
            if(origin.angle == tar1.angle) tar1.distance = int.MaxValue;
            if(origin.angle == tar2.angle) tar2.distance = int.MaxValue;
            if(origin.angle == tar3.angle) tar3.distance = int.MaxValue;
            if(origin.angle == tar4.angle) tar4.distance = int.MaxValue;
            
            int minDistance = Math.Min(Math.Min(tar1.distance, tar2.distance), Math.Min(tar3.distance, tar4.distance));
            
            answer[i] = minDistance;
        }
        
        return answer;
    }
}

class pos
{
    public int x;
    public int y;
    public int distance;
    public double angle;
    
    public pos(int x, int y, int startX, int startY)
    {
        this.x = x;
        this.y = y;

        int deltaX = startX - x;
        int deltaY = startY - y;
        
        distance = deltaX * deltaX + deltaY * deltaY;
        angle = Math.Atan2(deltaY, deltaX);
    }
}