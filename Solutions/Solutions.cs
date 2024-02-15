using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
	public class Solutions
	{
		public int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
				for (int j = i + 1; j < nums.Length; j++)
					if (nums[i] + nums[j] == target)
						return new int[] { i, j };
			return new int[] { };
		}
		public bool IsPalindrome(int x)
		{
			string k = x.ToString();

			for (int i = 0; i < k.Length / 2; i++)
			{
				if (k[i] != k[k.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
		public string FirstPalindrome(string[] words)
		{
			string ans = "";
			foreach (string word in words)
			{
				int j = 0, k = word.Length - 1;
				while (word[j] == word[k])
				{
					if (j >= k)
					{
						ans = word;
						return ans;
					}
					++j;
					--k;
				}
			}
			return ans;
		}
	}
}
