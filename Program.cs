class Program
{
    static void Main(string[] args)
    { 
        System system =new System("Brott","Plats","Tid");
        system.Start();
        system.AddItem("Stöld", "Göteborg", "12.45");
        
    }

    public class System
    {
    List<System> list  = new();
    public string crime {get; set;} // tex stöld, bråk, trafik
    public string place{get;set;}
    public string time{get;set;} 
    
    public System(string crime, string place, string time){
        this.crime = crime;
        this.place = place;
        this.time = time;
    }

    public void AddItem(string crime,string place, string time)
    {
        list.Add(new System(crime,place,time));
        Console.WriteLine($"Typ av brott: {crime}");
        Console.WriteLine("Plats: "+ place);
        Console.WriteLine("Klockslag: "+time);
        
    }
    public void Start(){
        while(true)
        {
        
        Police police = new Police("Name", 1000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("RAPPORTSYSTEM 80");
        Console.WriteLine("1. REGISTRERING AV UTRYCKNINGAR");
        Console.WriteLine("2. RAPPORTER"); //  RAPPORTNUMMER, DATUM, POLISSTATION som hanterar ärendet samt BESKRIVNING
        Console.WriteLine("3. REGISTERA NY PERSONAL");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
            {
                case 1: 
                Console.Write("Skriv in typ av brott: ");
                string crime = Console.ReadLine();
                Console.Write("Skriv in plats: ");
                string place = Console.ReadLine();
                Console.Write("Skriv in klockslag, i format 00.00: ");
                string time = Console.ReadLine();

                AddItem(crime,place,time); 
                

                Console.Write("Lägg till polis? j/n: "); // Displaya lista med polis där man får välja vem som var där!!!! 
                string jn = Console.ReadLine();
                if (jn == "j"){
                  
                    police.DisplayPolice();
                    Console.Write("Välj med hjälp av siffrorna: ");
                    int nr = int.Parse(Console.ReadLine());
                    for (int i = 0; i < list.Count; i++)
                    {
                            
                    }

                } 
                else if (jn == "n")
                {
                    Console.WriteLine("Ingen polis tillagd."); 
                }
                break; 
                case 2: 
                police.DisplayPolice();
                break;     
                case 3: 
                 police.AddPolice();
                 break;
                
        
            }
        }
    }

    public class Police{
        public string name {get; set;} 
        public int idNr{get;set;}

        public Police(string name, int idNr){
            this.name = name;
            this.idNr = idNr;
        }
        List<Police> policeList = new();
        
       
        public void AddPolice(){
            Console.Write("Skriv in namn: ");
            string name = Console.ReadLine();
            Console.Write("Skriv in ID-nummer: ");
            int idNr = int.Parse(Console.ReadLine());
            policeList.Add(new Police(name, idNr));
            
            
        }
         public void DisplayPolice()
         {
             Console.WriteLine("Alla poliser: ");
            // display all polices
            for (int i = 0; i < policeList.Count; i++)
            {   
                Console.WriteLine(policeList[i].name + policeList[i].idNr);
            }
            // foreach(Police p in policeList)
            // {
            //     Console.WriteLine("Namn: "+p.name);
            //     Console.WriteLine("ID-nummer:"+p.idNr);
            // }
        }
    }
    } 
}