namespace Application.Commands.Index
{
    public class List
    {
        /*
        * List.Add, List.Insert
        * List.Find, list.FindLast
        * list.FindIndex, list.FindAll
        * list.Remove, list.RemoveAll, list.RemoveAt, list.RemoveRange
        */

        public List<string> GetEmptyList()
        {
            List<string> emptyList = new List<string>();
            return emptyList;
        }

        public List<string> GetLetterList()
        {
            List<string> lettersList = new List<string>();

            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            for (int i = 0; i < 10; i++)
            {
                lettersList.Insert(i, letters[i]);
            }

            if (lettersList.Equals(null))
            {
                throw new ArgumentNullException("List>GetChargedList>chargedList with value=[null]");
            }

            return lettersList;
        }

        public List<ToggleModel> GetToggleList()
        {
            List<ToggleModel> togglesList = new List<ToggleModel>();

            togglesList.Add(new ToggleModel(1, "Water", true));
            togglesList.Add(new ToggleModel(2, "Energy", true));
            togglesList.Add(new ToggleModel(3, "Cold", false));

            return togglesList;
        }

        public string FindByLetter(int option, string f)
        {
            var list = GetLetterList();
            string? filter = default;

            switch (option)
            {
                case 1:
                    // find
                    filter = list.Find(x => MatchValues(x, f));
                    break;
                case 2:
                    // find last
                    filter = list.FindLast(x => MatchValues(x, f));
                    break;
                case 3:
                    // find index
                    filter = list.FindIndex(x => MatchValues(x, f)).ToString();
                    break;
                case 4:
                    // find last index
                    filter = list.FindLastIndex(x => MatchValues(x, f)).ToString();
                    break;
                case 5:
                    filter = list.FindAll(x => MatchValues(x, f)).ToString();
                    break;
                default:
                    break;
            }

            if (filter.Equals(null))
            {
                throw new ArgumentNullException("List>FindByLetter>filter with value=[null]");
            }

            return filter;
        }

        public bool MatchValues(string a, string b)
        {
            if (a.Equals(null)) throw new ArgumentNullException("List>MatchValues>a with value=[null]");
            if (b.Equals(null)) throw new ArgumentNullException("List>MatchValues>b with value=[null]");

            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
    }
}
