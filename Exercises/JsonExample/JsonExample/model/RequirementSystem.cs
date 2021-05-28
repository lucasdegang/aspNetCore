namespace JsonExample.Model
{
    public class RequirementSystem
    {
        /*
            {
            "Processor": "1 gigahertz",
            "RAM": "1 gigabyte (GB) for 32-bit or 2 GB for 64-bit",
            "Hard Drive": "16 GB for 32-bit OS 32 GB for 64-bits OS",
            "Display": "800x600"
            }
        */

        // Edit > Paste Especial > Paste Json as Class
        
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string HardDrive { get; set; }
        public string Display { get; set; }
    }
}
