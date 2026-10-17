public class KthLargest {
    PriorityQueue<int, int> queue;
    int k;
    public KthLargest(int k, int[] nums) {
        queue = new PriorityQueue<int, int>();
        this.k = k;
        foreach(int n in nums){
            queue.Enqueue(n,n);
            if(queue.Count > k){
                queue.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if (queue.Count > k) queue.Dequeue();
        return queue.Peek();
    }
}
