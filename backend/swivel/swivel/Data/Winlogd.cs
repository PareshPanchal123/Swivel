using System;
using System.Collections.Generic;

namespace swivel.Data
{
    public partial class Winlogd
    {
        public int Ref { get; set; }
        public int Winlog { get; set; }
        public string Atapod { get; set; }
        public string AtapodEventStatus { get; set; }
        public string Activity { get; set; }
        public string ActivityCode { get; set; }
        public string BlNo { get; set; }
        public string BookingNo { get; set; }
        public string Capacity { get; set; }
        public string ContainerNo { get; set; }
        public string ContainerType { get; set; }
        public string Date { get; set; }
        public string DateEventStatus { get; set; }
        public string EtaAta { get; set; }
        public string EtaAtaEventStatus { get; set; }
        public string Etd { get; set; }
        public string EtdEventStatus { get; set; }
        public string FinalDischarge { get; set; }
        public string FinalDischargeCode { get; set; }
        public string ImoNumber { get; set; }
        public string Location { get; set; }
        public string LocationCode { get; set; }
        public string Operator { get; set; }
        public string Origin { get; set; }
        public string OriginCode { get; set; }
        public string PortOfDischarging { get; set; }
        public string PortOfDischargingCode { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfLoadingCode { get; set; }
        public string ScacCarrierCode { get; set; }
        public string ServiceName { get; set; }
        public string Source { get; set; }
        public string VesselTrainTruck { get; set; }
        public string VoyageNumber { get; set; }
        public string Weight { get; set; }
        public DateTime? Crtdate { get; set; }
    }
}
