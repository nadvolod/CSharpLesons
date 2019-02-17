using System;

class Student : Person
{
    private string major;
    private string studentId;

    public Student(string id, string fname, string lname, int anAge, string maj, string sId,
        DateTime dob)
        :base(id, lname, fname, anAge, dob)
    {
        major = maj;
        studentId = sId;
    }

    public Student(string id, string fname, string lname, int anAge, string maj, string sId)
        : base(id, lname, fname, anAge)
    {
        major = maj;
        studentId = sId;
    }

    //public override string GetExerciseHabits()
    //{
    //    return "Zero time to exercise";
    //

    public void GetDOB()
    {
        //base.dateOfBirth;
    }

    public override string HoursOfSleep()
    {
        return "A student gets 6 hours of sleep";
    }
}