using System;
using GeneXus.Builder;
using System.IO;
public class bldingreso : GxBaseBuilder
{
   string cs_path = "." ;
   public bldingreso( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0 ;
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldingreso x = new bldingreso() ;
      x.SetMainSourceFile( "ingreso.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\GeneXus.Programs.Common.rsp");
      return sc ;
   }

   public override ItemCollection GetRuntimeBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\ingreso.dll", cs_path + @"\ingreso.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtMessages_Message.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtLinkList_LinkItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtParametros.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSlideDownMenuData_SlideDownMenuDataItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSlideDownMenuSelectedItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents_event.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents_Day.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtContext.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtProgramNames_ProgramName.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabOptions_TabOptionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtAgenda.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTrnMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINHttpMethod.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

