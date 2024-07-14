namespace BtkAkademi.Models{
    public static class Repository{
        private static List<Candidate> applications=new();//liste oluştu
        public static IEnumerable<Candidate> Applications=>applications;//interface desteği ile dönüş yapıyorum erişmek isteyenlere

        public static void Add(Candidate candidate){
            applications.Add(candidate);

        } 

    }
}