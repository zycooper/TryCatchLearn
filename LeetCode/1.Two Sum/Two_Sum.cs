public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {                
        List<int> Result = new List<int>();   
        List<int> nums_list = new List<int>(nums);

        for (int i = 0; i < nums_list.Count; i++)
        {
            int current_num = nums_list[i];
            int new_target = target - current_num;

            //next level list
            List<int> _next = nums_list.GetRange(i+1,nums_list.Count-i-1);
            
            int FoundIndex = _next.IndexOf(new_target); 

            if(FoundIndex != -1)
            {
                return new int[]{i,i+FoundIndex+1};
            }         
        }

        return new int[2];    
    }   
}
/*
    First Submission: 11-11-2020
    Submission Result:Time Limit Exceeded
    Solution Time Duration: 34 min
    Summary: still need to spend more time on this since the submission failed, anyway, start from the abandon on the vocabulary
    1. get more familier with C# list 
    2. get more familier with array
*/
