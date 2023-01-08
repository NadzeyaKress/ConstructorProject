namespace ConstructorProject
{
    internal class SubjectScore
    {
        private const int Max_Score = 100;
        private int _score;
        public int Score 
        { 
            get
            { 
                return _score; 
            }
            set
            {
                if (value >= 0 && value <= Max_Score)
                {
                    _score = value;
                }
            }
        }
        public string SubjectName { get; set; }

        public SubjectScore(int score, string subjectName)
        {
            Score = score;
            SubjectName = subjectName;
        }
    }
}
