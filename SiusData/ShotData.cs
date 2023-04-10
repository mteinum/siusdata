namespace SiusData
{
   public class ShotData
   {
      /// <summary>
      /// The shooter is identified definitely by his start number
      /// </summary>
      public string StartNR { get; set; }
      /// <summary>
      /// Primary score(1.0 through 10.9 or 1 through 10)
      /// </summary>
      public string PrimaryScore { get; set; }
      /// <summary>
      /// 0=Sighter, 1=Match shot, 8=Final shot
      /// </summary>
      public string MatchShot { get; set; }
      /// <summary>
      /// Lane number of the shooter(1-9999)
      /// </summary>
      public string Firingpoint { get; set; }
      /// <summary>
      /// Secondary score (1.0 through 10.9)
      /// </summary>
      public string SecondaryScore { get; set; }
      /// <summary>
      /// Number of 100th millimeter to center
      /// </summary>
      public string Divisions { get; set; }
      /// <summary>
      /// Time mark of the shot(HH:MM:SS)
      /// </summary>
      public string Time { get; set; }
      /// <summary>
      /// 1=Innerten, 0=no innerten
      /// </summary>
      public string Innerten { get; set; }
      /// <summary>
      /// X Coordinate in millimeters (also negative)
      /// </summary>
      public string X { get; set; }
      /// <summary>
      /// Y Coordinate in millimeters (also negative)
      /// </summary>
      public string Y { get; set; }
      /// <summary>
      /// 	1=within valid time frame, 0=out
      /// </summary>
      public string Intime { get; set; }
      /// <summary>
      /// 	Time since start of the red / green phase, in 0.01s
      /// </summary>
      public string TimeSinceChange { get; set; }
      /// <summary>
      /// 0=off/left, 1=right, direction for Running target
      /// </summary>
      public string SweepDirection { get; set; }
      /// <summary>
      /// Demonstration mode (0=off, 1=on)
      /// </summary>
      public string Demonstration { get; set; }
      /// <summary>
      /// 	zero based index of the shoot
      /// </summary>
      public string Shoot { get; set; }
      /// <summary>
      /// zero based index of the practice
      /// </summary>
      public string Practice { get; set; }
      /// <summary>
      /// Dataset inserted manually=1; Ignore data set=2
      /// </summary>
      public string InsDel { get; set; }
      /// <summary>
      /// Group total=1, Sub total=2, Grand total=4
      /// </summary>
      public string Totalkind { get; set; }
      /// <summary>
      /// 0 or 1 based enumeration of the shot group.
      /// </summary>
      public string Group { get; set; }
      /// <summary>
      /// 	Sighter shots=0, Single shots=1, Series shots=2
      /// </summary>
      public string Firekind { get; set; }
      /// <summary>
      /// 	Incremental LogEvent number (without Header/Footer)
      /// </summary>
      public string Logevent { get; set; }
      /// <summary>
      /// Shot type (3: OwnShot, 10: CrossShot, 12: IllegalShot
      /// </summary>
      public string Logtype { get; set; }
      /// <summary>
      /// Time since beginning of the current year in 0.01s units.
      /// </summary>
      public string TimeSinceBeginningOfTheCurrentYear { get; set; }
      /// <summary>
      /// Current Relay..
      /// </summary>
      public string Relay { get; set; }
      /// <summary>
      /// 0:Weapontype : 1-21:different weapontypes
      /// </summary>
      public string Weapon { get; set; }
      /// <summary>
      /// 0:Position : 1:prone, 2:standing, 3:knieling, 4 prone supported
      /// </summary>
      public string Position { get; set; }
      /// <summary>
      /// FFFF: undefined, all other numbers according to the Target Ident in the target.ini file."
      /// </summary>
      public string TargetID { get; set; }
      /// <summary>
      /// 	External number, with which the user shoot can be identified.
      /// </summary>
      public string ExternalNumber { get; set; }

   }
}