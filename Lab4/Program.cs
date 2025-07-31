using System.Text;

namespace Lab4{
    internal class Program {
        static void Main(string[] args){
            {

                int[] nums = new int[args.Length];
                int j=0;

                for(int i=0; i < args.Length; i++)
                {
                    if (int.TryParse(args[i], out nums[j]))
                        j++;
                    else
                        Console.WriteLine($"Не число: {args[i]}");
                }

                nums = nums[0..j];
                StringBuilder sb = new StringBuilder();
                string result;

                foreach(int k in nums){
                    sb.Append(k).Append(' ');
                }
                result = sb.ToString();
                Console.WriteLine(result);
                
                int summ = 0;
                for(int i=0; i < nums.Length; i++){
                    summ += nums[i];
                }
                Array.Sort(nums);
                Console.WriteLine($"Сумма: {summ}");
                Console.WriteLine($"Отсортированный массив:");
                
                sb.Clear();
                foreach(int k in nums){
                    sb.Append(k).Append(' ');
                }
                result = sb.ToString();
                Console.WriteLine(result);
            }
            
        }
    }
}

