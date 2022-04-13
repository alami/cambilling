using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ForpostAccount
    {            
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public int IsActive { get; set; }
        
        public string NetworkIP { get; set; }
        
        public string NetworkMask { get; set; }
        
        public int MaxCameraCount { get; set; }
        
        public int MaxLoginCount { get; set; }
        
        public int MaxCameraArchivalTranslationCount { get; set; }
        
        public int MaxCameraOnlineTranslationCount { get; set; }
        
        public int MaxCameraUserArchivalTranslationCount { get; set; }
        
        public int MaxCameraUserOnlineTranslationCount { get; set; }
        
        public int MaxSMSPerMonth { get; set; }
        
        public int Quota { get; set; }
        
        public string ContractNumber { get; set; }
        
        public string CreationDate { get; set; }
        
        public int CreationAdminID { get; set; }
        
        public int ManagementAccountID { get; set; }
        
        public int IsLoginLocked { get; set; }
        
        public string LoginLockReason { get; set; }
        
        public int IsNotificationEnabled { get; set; }
        
        public int CityID { get; set; }
    }
}