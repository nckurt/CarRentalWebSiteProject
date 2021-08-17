using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.DTOs
{
   public class AddedCarFormDto
    {
        public AddedCarFormDto()
        {
            GearTypeList = new List<GearsDto>();
            FuelTypeList = new List<FuelTypesDto>();
            ModelList = new List<ModelsDto>();
            StatusList = new List<CarStatusTypeDto>();
           
        }
        public List<GearsDto> GearTypeList { get; set; }
        public List<FuelTypesDto> FuelTypeList { get; set; }
        public List<ModelsDto> ModelList { get; set; }
        public List<CarStatusTypeDto> StatusList { get; set; }

        //public int CarID { get; set; }
        public byte[] Image { get; set; }
        public string PlateNo { get; set; }
        public string ChassisNo { get; set; }
        public int GearID { get; set; }
        public int BrandModelDetailID { get; set; }
        public int BrandRefID { get; set; }
        public int FuelTypeID { get; set; }
        public int StatusTypeID { get; set; }
        public decimal DailyFee { get; set; }
    }
}
