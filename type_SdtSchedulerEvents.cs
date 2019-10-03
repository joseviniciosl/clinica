using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtSchedulerEvents : GxUserType
   {
      public SdtSchedulerEvents( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSchedulerEvents( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name ;
         if ( oReader.IsSimple == 0 )
         {
            if ( gxTv_SdtSchedulerEvents_Items != null )
            {
               gxTv_SdtSchedulerEvents_Items.ClearCollection();
            }
            if ( gxTv_SdtSchedulerEvents_Specialdays != null )
            {
               gxTv_SdtSchedulerEvents_Specialdays.ClearCollection();
            }
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp(oReader.LocalName, "event") == 0 )
               {
                  if ( gxTv_SdtSchedulerEvents_Items == null )
                  {
                     gxTv_SdtSchedulerEvents_Items = new GxObjectCollection( context, "SchedulerEvents.event", "", "SdtSchedulerEvents_event", "GeneXus.Programs");
                  }
                  GXSoapError = gxTv_SdtSchedulerEvents_Items.readxmlcollection(oReader, "", "event") ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Day") == 0 )
               {
                  if ( gxTv_SdtSchedulerEvents_Specialdays == null )
                  {
                     gxTv_SdtSchedulerEvents_Specialdays = new GxObjectCollection( context, "SchedulerEvents.Day", "", "SdtSchedulerEvents_Day", "GeneXus.Programs");
                  }
                  GXSoapError = gxTv_SdtSchedulerEvents_Specialdays.readxmlcollection(oReader, "", "Day") ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
               }
               nOutParmCount = (short)(nOutParmCount+1) ;
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
                  GXSoapError = (short)(nOutParmCount*-1) ;
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "data" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "" ;
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10)) ;
         }
         if ( gxTv_SdtSchedulerEvents_Items != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "" ;
            }
            else
            {
               sNameSpace1 = "" ;
            }
            gxTv_SdtSchedulerEvents_Items.writexmlcollection(oWriter, "", sNameSpace1, "event", sNameSpace1);
         }
         if ( gxTv_SdtSchedulerEvents_Specialdays != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "" ;
            }
            else
            {
               sNameSpace1 = "" ;
            }
            gxTv_SdtSchedulerEvents_Specialdays.writexmlcollection(oWriter, "", sNameSpace1, "Day", sNameSpace1);
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         if ( gxTv_SdtSchedulerEvents_Items != null )
         {
            AddObjectProperty("Items", (Object)(gxTv_SdtSchedulerEvents_Items));
         }
         if ( gxTv_SdtSchedulerEvents_Specialdays != null )
         {
            AddObjectProperty("SpecialDays", (Object)(gxTv_SdtSchedulerEvents_Specialdays));
         }
         return  ;
      }

      public IGxCollection gxTpr_Items
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Items == null )
            {
               gxTv_SdtSchedulerEvents_Items = new GxObjectCollection( context, "SchedulerEvents.event", "", "SdtSchedulerEvents_event", "GeneXus.Programs");
            }
            return gxTv_SdtSchedulerEvents_Items ;
         }

         set {
            gxTv_SdtSchedulerEvents_Items = value ;
         }

      }

      public void gxTv_SdtSchedulerEvents_Items_SetNull( )
      {
         gxTv_SdtSchedulerEvents_Items = null ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_Items_IsNull( )
      {
         if ( gxTv_SdtSchedulerEvents_Items == null )
         {
            return true ;
         }
         return false ;
      }

      public IGxCollection gxTpr_Specialdays
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Specialdays == null )
            {
               gxTv_SdtSchedulerEvents_Specialdays = new GxObjectCollection( context, "SchedulerEvents.Day", "", "SdtSchedulerEvents_Day", "GeneXus.Programs");
            }
            return gxTv_SdtSchedulerEvents_Specialdays ;
         }

         set {
            gxTv_SdtSchedulerEvents_Specialdays = value ;
         }

      }

      public void gxTv_SdtSchedulerEvents_Specialdays_SetNull( )
      {
         gxTv_SdtSchedulerEvents_Specialdays = null ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_Specialdays_IsNull( )
      {
         if ( gxTv_SdtSchedulerEvents_Specialdays == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
      [ObjectCollection(ItemType=typeof( SdtSchedulerEvents_event ))]
      protected IGxCollection gxTv_SdtSchedulerEvents_Items=null ;
      [ObjectCollection(ItemType=typeof( SdtSchedulerEvents_Day ))]
      protected IGxCollection gxTv_SdtSchedulerEvents_Specialdays=null ;
   }

}
