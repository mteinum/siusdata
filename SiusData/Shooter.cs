namespace SiusData
{
   public class Shooter
   {
      /// <summary>
      /// The firer's identification number is for international competitions. Up to 16 characters.
      /// </summary>
      public string IDNo { get; set; }
      /// <summary>
      /// Firer's start number
      /// </summary>
      public string StNr { get; set; }
      /// <summary>
      /// Firers' family name (up to 18 characters)
      /// </summary>
      public string Name { get; set; }
      /// <summary>
      /// Firers' first name (up to 15 characters)
      /// </summary>
      public string Firstname { get; set; }
      /// <summary>
      /// Firers' score board name (up to 20 characters)
      /// </summary>
      public string SCBDName { get; set; }
      /// <summary>
      /// Nation
      /// </summary>
      public string NAT { get; set; }
      /// <summary>
      /// Firers category (0:women, 1:men, 2:mixed)
      /// </summary>
      public string FirerCat { get; set; }
      /// <summary>
      /// Group identification (0:regular shooters, 1:MQS firers, 2:guests)
      /// </summary>
      public string Group { get; set; }
      /// <summary>
      /// Team name for Team results (up to 15 characters)
      /// </summary>
      public string Team { get; set; }
      /// <summary>
      /// (Only for 25m pistol)
      /// </summary>
      public string Bay { get; set; }
      /// <summary>
      /// Target number
      /// </summary>
      public string Target { get; set; }
      /// <summary>
      /// Relay number
      /// </summary>
      public string Relay { get; set; }
      /// <summary>
      /// Start time of the relay (has to be defined at least once per relay.)
      /// </summary>
      public string StartTime { get; set; }
      /// <summary>
      /// Target positioin of the spectators' monitors
      /// </summary>
      public string BoxTargetNo { get; set; }
      /// <summary>
      /// Automatically activate or deactivate the lane on reading data.
      /// </summary>
      public string LaneActive { get; set; }
      /// <summary>
      /// Total of the Qualifikation.
      /// </summary>
      public string QualificationTotal { get; set; }
      /// <summary>
      /// 0:No duell defined, 1:duell defined
      /// </summary>
      public string DuellDefined { get; set; }

   }
}