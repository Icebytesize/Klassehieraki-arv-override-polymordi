using Klassehieraki_arv_override_polymordi.Classes;

List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>
{
    new HourlyEmployee("Alice", 101, new DateTime(2020, 1, 15), 20.5m, 40),
    new HourlyEmployee("Bob", 102, new DateTime(2019, 3, 10), 18.0m, 35),
    new HourlyEmployee("Charlie", 103, new DateTime(2021, 6, 5), 22.0m, 45)
};
List<SalariedEmployee> salariedEmployees = new List<SalariedEmployee>
{
    new SalariedEmployee("David", 201, new DateTime(2018, 2, 20), 5000m, 500m),
    new SalariedEmployee("Eva", 202, new DateTime(2017, 5, 15), 6000m, 600m),
    new SalariedEmployee("Frank", 203, new DateTime(2019, 8, 10), 5500m, 550m)
};
