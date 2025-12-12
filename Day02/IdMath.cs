using System.Numerics;

namespace Day02
{
    public static class IdMath
    {
        public static bool IsValid(BigInteger id)
        {
            string idAsString = id.ToString();
            int length = idAsString.Length;
            string firstHalf = idAsString.Substring(0, length / 2);
            string secondHalf = idAsString.Substring(length / 2);
            return !(firstHalf.Equals(secondHalf));
        }

        public static List<BigInteger> GetInvalidIdsInRange(IdRange idRange)
        {
            List<BigInteger> invalidIds = new();
            for (BigInteger i = idRange.FirstId; i <= idRange.LastId; i++)
                if (!IsValid(i))
                    invalidIds.Add(i);
            return invalidIds;
        }

        public static BigInteger SumInvalidIds(IEnumerable<IdRange> idRanges)
        {
            BigInteger sum = 0;
            foreach (IdRange idRange in idRanges)
            {
                IEnumerable<BigInteger> invalidIds = GetInvalidIdsInRange(idRange);
                foreach (BigInteger invalidId in invalidIds)
                {
                    sum += invalidId;
                }
            }
            return sum;
        }

        public static bool IsValidAdvanced(BigInteger id)
        {
            string idAsString = id.ToString();
            int idStringLength = idAsString.Length;

            for (int substringLength = 1; substringLength < idStringLength; substringLength++)
            {
                if (idStringLength % substringLength != 0)
                    continue;

                int substringCount = idStringLength / substringLength;

                List<string> substrings = new();
                for (int i = 0; i < substringCount; i++)
                {
                    int start = i * substringLength;
                    string substring = idAsString.Substring(start, substringLength);
                    substrings.Add(substring);
                }

                bool allSubstringsMatch = true;
                foreach (string substring in substrings)
                {
                    if (substring != substrings.First())
                        allSubstringsMatch = false;
                }
                if (allSubstringsMatch && substringCount > 1)
                    return false;
            }
            return true;
        }

        public static List<BigInteger> GetInvalidIdsInRangeAdvanced(IdRange idRange)
        {
            List<BigInteger> invalidIds = new();
            for (BigInteger i = idRange.FirstId; i <= idRange.LastId; i++)
                if (!IsValidAdvanced(i))
                    invalidIds.Add(i);
            return invalidIds;
        }

        public static BigInteger SumInvalidIdsAdvanced(IEnumerable<IdRange> idRanges)
        {
            BigInteger sum = 0;
            foreach (IdRange idRange in idRanges)
            {
                IEnumerable<BigInteger> invalidIds = GetInvalidIdsInRangeAdvanced(idRange);
                foreach (BigInteger invalidId in invalidIds)
                {
                    sum += invalidId;
                }
            }
            return sum;
        }
    }
}
