using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Camera
    {
        public int CameraID { get; set; }  
        public int Status { get; set; }  
        public string LastAvailableDate { get; set; }  
        public string LastNotAvailableDate { get; set; }  
        public int ONVIFStatus { get; set; }  
    }
}