namespace Biblioteca.LeetCode
{
    public static class LeetCode1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int primeiraPosicao = 0;
            int segundaPosicao = 0;
            for (int indice = 0; indice < nums.Length; indice++)
            {
                for (int subIndice = indice + 1; subIndice < nums.Length; subIndice++)
                {
                    if ((nums[indice] + nums[subIndice]) == target)
                    {
                        primeiraPosicao = indice;
                        segundaPosicao = subIndice;
                        break;
                    }
                }
            }
            return new int[] { primeiraPosicao, segundaPosicao };
        }
    }
}
