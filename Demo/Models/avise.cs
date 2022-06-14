namespace Demo.Models
{
    public class avise
    {
        public int Id { get; set; }
        public string Besteller { get; set; }
        public string Entladestellen { get; set; }
        public string status { get; set; }

        public avise()
        {
            Id = 0;
            Besteller = "Demomandant";
            Entladestellen = "Bauteil 1";
            status = "offen";
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public avise(int v1, string v2, string v3, string v4)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        internal static void Add(avise avise)
        {
            
        }
    }

    
    }
