namespace ConstructorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var p1 = new Person("Ivan", "Sidorov", new Address ("Minsk", "Lenina", 4, 15));
            var p2 = new Person("Maria", "Petrova", new Address("Brest", "Gagarina", 89, 15));
            var p3 = new Person("Katerina", "Kot", new Address("Minsk", "Orlovskaya", 88, 65));
            var p4 = new Person("Yaroslavna", "Ivanova", new Address("Gomel", "Marksa", 9, 52));
            var p5 = new Person("Denis", "Nechaev", new Address("Grodno", "Minskaya", 44, 143));

            var s1 = new SubjectScore[] { new SubjectScore(90, "Language"), new SubjectScore(89, "Math"), new SubjectScore(80, "Physics") };
            var s2 = new SubjectScore[] { new SubjectScore(92, "Language"), new SubjectScore(99, "Math"), new SubjectScore(73, "Physics") };
            var s3 = new SubjectScore[] { new SubjectScore(61, "Language"), new SubjectScore(73, "Math"), new SubjectScore(90, "Physics") };
            var s4 = new SubjectScore[] { new SubjectScore(75, "Language"), new SubjectScore(86, "Math"), new SubjectScore(65, "Physics") };
            var s5 = new SubjectScore[] { new SubjectScore(96, "Language"), new SubjectScore(91, "Math"), new SubjectScore(83, "Physics") };

            var c1 = new Candidate(p1, s1);
            var c2 = new Candidate(p2, s2);
            var c3 = new Candidate(p3, s3);
            var c4 = new Candidate(p4, s4);
            var c5 = new Candidate(p5, s5);

            var candidates = new Candidate[] { c1, c2, c3, c4, c5 };

            var maxScore = 0;

            foreach(var candidate in candidates)
            {
                Console.WriteLine(candidate.Person.Address.Street);
                var subject = candidate.SubjectScores.Where(subjectScore => subjectScore.SubjectName == "Math").FirstOrDefault();
                if (subject != null && subject.Score > maxScore)
                {
                    maxScore = subject.Score;
                }
            }
            Console.WriteLine(maxScore);

            //Console.WriteLine("Hello, World!");
        }
    }
}