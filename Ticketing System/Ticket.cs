namespace Ticketing_System
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Submitter { get; set; }
        public string Assigned { get; set; }
        public string Watching { get; set; }

        public Ticket()
        {
            Console.WriteLine("\nInput the ticket id: ");
            TicketID = Console.ReadLine();
            Console.WriteLine("\nInput the ticket summary: ");
            Summary = Console.ReadLine();
            Console.WriteLine("\nInput the ticket status: ");
            Status = Console.ReadLine();
            Console.WriteLine("\nInput the ticket priority: ");
            Priority = Console.ReadLine();
            Console.WriteLine("\nInput the ticket submitter's name: ");
            Submitter = Console.ReadLine();
            Console.WriteLine("\nInput who the ticket is assigned to: ");
            Assigned = Console.ReadLine();
            Console.WriteLine("\nInput a watching name");
            Watching = Console.ReadLine();
            do
            {
                Console.WriteLine("\nDo you want to input another watching name (Y/N)?");
                var response = Console.ReadLine().ToUpper();

                if (response != "Y")
                {
                    break;
                }
                Console.WriteLine("\nInput a watching name");
                Watching += "|" + Console.ReadLine();

            } while (true);
        }

        public string GenerateTicketLine()
        {
            return $"{TicketID},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching}";
        }
    }
}