int student = 5;
while (student != 0)
{
    string NewStudentGroup = GroupForDevs();
    student = student - 1;
}
Console.WriteLine("All groups are full");

static string GroupForDevs()
{

    string classType;
    bool studentHasExperience = false;
    int studentAge = 0;
    String ExperienceRawAnswer = "placeholder";


    while (!(studentAge > 6 && studentAge < 121))

    {
        Console.WriteLine("What is your full age? Possible input 1-120");
        studentAge = int.Parse(Console.ReadLine());
        continue;
    }


    while (ExperienceRawAnswer != "yes" || ExperienceRawAnswer != "no")

    {
        Console.WriteLine("Do you have experience in coding? Answer yes or no!");
        ExperienceRawAnswer = Console.ReadLine().ToLower();
        if (ExperienceRawAnswer == "yes")
        {
            studentHasExperience = true;
            break;
        }
        else if (ExperienceRawAnswer == "no")
        {
            studentHasExperience = false;
            break;
        }
        else
        {
            Console.WriteLine("Your input is incorrect!");
            continue;

        }
    }


    if (studentAge > 0 && studentAge < 18 && studentHasExperience == true)
    {
        classType = "Your group is 1 (kid with experience)";
        Console.WriteLine(classType);
        return classType;
    }
    else if (studentAge > 0 && studentAge < 18 && studentHasExperience == false)
    {
        classType = "Your group is 2 (kid with NO experience)";
        Console.WriteLine(classType);
        return classType;
    }
    else if (studentAge >= 18 && studentAge <= 120 && studentHasExperience == true)
    {
        classType = "Your group is 3 (adult with experience)";
        Console.WriteLine(classType);
        return classType;
    }
    else
    {
        classType = "Your group is 4 (adult with NO experience)";
        Console.WriteLine(classType);
        return classType;
    }

}
