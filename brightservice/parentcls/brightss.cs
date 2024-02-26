namespace brightservice{
    class Brightss{
    string Dayshift,Midshift,Nightshift;
    string [] Ai = {"AI and Machine Learing", "Python", "Java", "C", "Mongodb"};
     string [] CAD = {"HTML", "CSS", "Javascript", "C#", "MSQL"};
      string [] BPO = {"staffing & Recruiting", "Call Center", "IT services"};
    public Brightss(){
       Dayshift="Ai";
       Midshift="CAD";
       Nightshift="BPO";
 
    }


 public string GetDayshift(){
    return Dayshift;
 }

 public string GetMidshift(){
    return Midshift;
 }

 public string GetNightshift(){
    return Nightshift;
 }

}
}