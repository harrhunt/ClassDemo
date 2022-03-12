namespace ClassDemo.Models {
    public class DAL {
        public List<Person> GetPeople() {
            List<Person> people = new List<Person>();
            people.Add(new Person() {FirstName = "Bruce", LastName = "Banner"});
            people.Add(new Person() {FirstName = "James", LastName = "Williams"});
            people.Add(new Person() {FirstName = "Wilson", LastName = "Everson"});
            people.Add(new Person() {FirstName = "Daniel", LastName = "Rogers"});
            people.Add(new Person() {FirstName = "Sarah", LastName = "Lott"});
            return people;
        }
    }
}