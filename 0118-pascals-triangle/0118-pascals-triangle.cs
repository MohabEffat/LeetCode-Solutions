public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List < IList<int> > triangle = new List<IList<int>>();

            triangle.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                IList<int> prevRow = triangle[i - 1];
                IList<int> currRow = new List<int> { 1 };

                for (int j = 1; j < i; j++)
                {
                    currRow.Add(prevRow[j - 1] + prevRow[j]);
                }

                currRow.Add(1);
                triangle.Add(currRow);
            }

            return triangle;
    }
}