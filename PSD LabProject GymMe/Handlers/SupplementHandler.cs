using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Handlers
{
    public class SupplementHandler
    {
        public static Response<MsSupplement> CreateSupplement(string supplementName, DateTime supplementExpiryDate, int supplementPrice, int SupplementTypeId)
        {
            MsSupplementType supplementType = SupplementTypeRepo.FindSupplementTypeById(SupplementTypeId);
            if (supplementType == null )
            {
                return new Response<MsSupplement>
                {
                    message = "Invalid Supplement Type",
                    status = false,
                    payload = null
                };
            } else
            {
                SupplementRepo.CreateSupplement(supplementName, supplementExpiryDate, supplementPrice, SupplementTypeId);
                return new Response<MsSupplement>
                {
                    message = "Success!",
                    status = true,
                    payload = null
                };
            }
        }
        public static Response<MsSupplement> UpdateSupplement(int supplementId, string supplementName, DateTime supplementExpiryDate, int supplementPrice, int supplementTypeId)
        {
            MsSupplementType supplementType = SupplementTypeRepo.FindSupplementTypeById(supplementTypeId);
            if (supplementType == null)
            {
                return new Response<MsSupplement>
                {
                    message = "Invalid Supplement Type",
                    status = false,
                    payload = null
                };
            }
            else
            {
                SupplementRepo.UpdateSupplement(supplementId, supplementName, supplementExpiryDate, supplementPrice, supplementTypeId);
                return new Response<MsSupplement>
                {
                    message = "Success!",
                    status = true,
                    payload = null
                };
            }
        }

        public static Response<MsSupplement> RemoveSupplement(int supplementId)
        {
            SupplementRepo.RemoveSupplement(supplementId);
            return new Response<MsSupplement>
            {
                message = "Success!",
                status = true,
                payload = null
            };
        }
        public static List<object> GetSupplementList()
        {
            return SupplementRepo.GetSupplementList();
        }
        public static MsSupplement GetSupplement(int supplementId)
        {
            return SupplementRepo.GetSupplement(supplementId);
        }
    }
}