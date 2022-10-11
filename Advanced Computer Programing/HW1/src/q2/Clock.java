package q2;

public class Clock {
    private int hour = 0;
    private int minute = 0;
    private int second = 0;
    public Clock(int hour, int minute, int second)
    {
        setHour(hour);
        setMinute(minute);
        setSecond(second);
    }
    
    public int getHour()
    {
        return hour;
    }
    public void setHour(int hour)
    {
        if (hour <= 23)
        {
            this.hour = hour;
        }
    }
    public int getMinute()
    {
        return minute;
    }
    public void setMinute(int minute)
    {
        if (minute <= 59)
        {
            this.minute = minute;
        }
    }
    public int getSecond()
    {
        return second;
    }
    public void setSecond(int second)
    {
        if (second <= 59)
        {
            this.second = second;
        }
    }
    public void displayTime()
    {
        System.out.println("The time is: " + hour + ":" + minute + ":" + second);
    }
}
