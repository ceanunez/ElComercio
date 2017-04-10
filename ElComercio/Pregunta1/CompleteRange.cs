namespace Pregunta1
{
    public class CompleteRange
    {
        public int[] build(int[] inInts)
        {
            int[] outInts = new int[250];

            int max = 0;

            foreach (int i in inInts)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            for (int u = 1; u <= max; u++)
            {
                outInts[u] = u;
            }

            return outInts;
        }
    }
}
