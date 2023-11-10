# Trainig-.Net

## Job Scheduler
The basic design is a scheduler showing Jobs (horizontal bars) that are scheduled to be run in a test 
environment. The Jobs occupy a block of time during a day. The Scheduler allows people to see the 
plan for multiple days

## Grid with 2 axes (X,Y)
The scheduler should be implemented as a grid with two axes (x,y). Each axis will have a label.
It should be possible to see a set of grid squares (similar to screenshot example above).

## Days of week along Y-axis

Days of the week are displayed on the left (y-axis). Same as screenshot above.
The required format for days of the week are: [{week number}] {day of week} {date}
- Week number is calculated and ’week 1’ starts on 1st January.
- Day of week should be displayed in abbreviated format like: Mon, Tue, Wed, Thu, Fri, Sat, 
Sun
- Date should be displayed as: DD/MM/YYYY (Note: this is different to screenshot example)


You should use a standard library to obtain and format dates, days of week, etc.  
The current day (today’s date) should be highlighted in light green.  
The order is to show earliest date at top and latest date at bottom.  
The application should provide the following two options for viewing days. Implement as icons 
above the Scheduler. 
- Show Current Week: Showing current week with today highlighted
- Show Current Month: Showing current month with today highlighted.


##  Times along X-axis
Times during a day should be displayed along the X-axis. The list of times should be at the top of the 
scheduler (same as screenshot example).  
Once column should be implemented for each hour in the day, 24 hours in total.  
Times should be displayed in 24 hour format, i,e.: 00:00, 01.00, 12:00, 15:00, 23:00.  
The current hour should be highlighted in light green.

## Allow Jobs to be added to the Schedule
Jobs are represented on the Schedule as horizontal bars.   
Jobs are added to the Schedule by selecting an ‘empty’ grid square and double-clicking. This will 
define the start time and date for the Job.    


Jobs have the following properties:
- Name: A text string used to describe the Job.
- Team: Brown, Green, Orange or Pink
- Duration: Duration of Job in Hours, added to the start time to define end time of Job.
You must present a dialogue allowing this information to be defined for the Job.   



Job constraints:
- Jobs cannot overlap so we require some validation around start time and duration to 
prevent this.
- Jobs cannot run past midnight, so we require some validation around start time and 
duration to prevent this


Styling of Job bar:
1. The label displayed on the Job bar corresponds to the Name property. This label should be 
truncated if it cannot fit on available space.
2. The background colour of the Job bar corresponds to the Team property:
- Brown: #A1887F
- Green: #AED581
- Orange: #FFB74D
- Pink: #F06292


## Allow Jobs to be edited and deleted
Add a right-click menu to the Job bar. This menu will have two options:
- Edit: Triggering the same dialogue as used for adding a new Job. Allow changes to be saved 
(or cancelled).
- Delete: This will delete the Job. There is no need for a confirmation dialogue in this version 
of the system
