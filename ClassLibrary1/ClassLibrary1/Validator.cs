namespace ClassLibrary
{
    public class Validator
    {
        public static bool IsNumber(List<string> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (!double.TryParse(list[i], out _))
                    return false;


            }
            return true;
        }

        public static bool IsZero(List<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                    return false;
            }
            return true;
        }

        public static bool IsDiagonalLongest(List<double> list)
        {
            if (list[1] >= list[0] * 2)
                return false;

            return true;
        }
    }
}