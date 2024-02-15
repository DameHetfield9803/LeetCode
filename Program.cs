using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
	public class Program
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
			string z = x.ToString();
			for (int a = 0; a < z.Length / 2; ++a)
			{
				if (z[a] != z[z.Length - a - 1])
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

		public ListNode SwapPairs(ListNode head)
		{
			var prevNode = new ListNode();
			var first = head;
			var second = head?.next;
			var newHead = second ?? first;
			while(first != null && second != null)
			{
				(prevNode.next, first.next, second.next) = (second, second.next, first);
				(prevNode, first, second) = (first, first.next, first.next?.next);
			}
			return newHead;
		}

		public static void Main(String[] args)
		{
			Program solution = new();
			Console.WriteLine(solution.TwoSum([2, 7, 11, 15], 9));
			Console.WriteLine(solution.TwoSum([3, 2, 4], 6));
			Console.WriteLine(solution.TwoSum([3, 3], 6));
			Console.WriteLine(solution.IsPalindrome(121));
			Console.WriteLine(solution.IsPalindrome(-121));
			Console.WriteLine(solution.IsPalindrome(10));
			Console.WriteLine(solution.FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]));
			Console.WriteLine(solution.FirstPalindrome(["notapalindrome", "racecar"]));
			Console.WriteLine(solution.FirstPalindrome(["def", "ghi"]));
        }
	}
}
