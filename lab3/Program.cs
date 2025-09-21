//main
string day = GetDayOfWeek();
while (day ! = "stop")
{
    string misEvent = EventDecision(day);
    DisplayEventMessage(day, misEvent);
    day = GetDayOfWeek;
}
//end main
static string GetDayOfWeek()
{
    Console.Writeline("Enter the day of the week. (Monday-Sunday, Enter stop to stop)");
    return Console.Readline();
}
static string EventDecision(string day)
{
    if (day = "monday")
        return "Class";
        else if(day = "wednesday")
        return "Class";
        else if(day = "tuesday")
        return "AIMS Meeting";
        else if(day = "friday")
        return "Lab";
        else
        return "No Activities";
}
static void DisplayEventMessage (string day, string misEvent);
if(misEvent = "")

    Console.Writeline("No Activties");

   else Console.Writeline({day}, {misEvent})
