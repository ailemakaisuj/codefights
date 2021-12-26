namespace CodeFights.SmoothSailing
{
    public static class Solution_9
    {
        public static string[] Solution(string[] inputArray)
        {
            //var output = new List<string>();

            //var max = 0;

            //for(int i = 0; i < inputArray.Length; i++)
            //{
            //    if(inputArray[i].Length > max)
            //    {
            //        max = inputArray[i].Length;
            //    }
            //}

            

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    if (inputArray[i].Length == max)
            //    {
            //       output.Add(inputArray[i]);
            //    }
            //}

            

            return inputArray.Where(x => x.Length == inputArray.Max(x => x.Length)).ToArray();
        }

    }
}
