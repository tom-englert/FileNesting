namespace MadsKristensen.FileNesting
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidFileNestingPkgString = "6c799bc4-0d4c-4172-98bc-5d464b612dca";
        public const string guidFileNestingCmdSetString = "a5bb8f41-d79a-4de2-bd13-857f39dd0f3f";
        public const string guidImagesString = "c24fa2f3-0d5d-498f-8bee-2947e84addbd";
        public static Guid guidFileNestingPkg = new Guid(guidFileNestingPkgString);
        public static Guid guidFileNestingCmdSet = new Guid(guidFileNestingCmdSetString);
        public static Guid guidImages = new Guid(guidImagesString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int NestingMenu = 0x1000;
        public const int MyMenuGroup = 0x1020;
        public const int cmdUnNest = 0x1030;
        public const int cmdNest = 0x1040;
        public const int AutoNestGroup = 0x1050;
        public const int cmdAutoNesting = 0x1060;
        public const int cmdRunNesting = 0x1070;
        public const int bmpPic1 = 0x0001;
        public const int bmpPic2 = 0x0002;
        public const int bmpPicSearch = 0x0003;
        public const int bmpPicX = 0x0004;
        public const int bmpPicArrows = 0x0005;
        public const int bmpPicStrikethrough = 0x0006;
    }
}
