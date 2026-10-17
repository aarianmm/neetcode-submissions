public class Solution {
    public int LastStoneWeight(int[] stones) {
        var preQueue = new List<(int, int)>();
        foreach(int n in stones){
            preQueue.Add((n, -n));
        }
        var queue = new PriorityQueue<int, int>(preQueue);
        while(queue.Count > 1){
            int stoneOne = queue.Dequeue();
            int stoneTwo = queue.Dequeue();
            if(stoneOne != stoneTwo)    queue.Enqueue(Math.Abs(stoneOne-stoneTwo), -Math.Abs(stoneOne-stoneTwo));
        }
        return queue.Count == 0? 0 : queue.Dequeue();
    }
}
