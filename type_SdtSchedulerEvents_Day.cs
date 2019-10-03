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
   public class SdtSchedulerEvents_Day : GxUserType
   {
      public SdtSchedulerEvents_Day( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSchedulerEvents_Day( IGxContext context )
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
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp2( oReader.LocalName, "Date") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtSchedulerEvents_Day_Date = DateTime.MinValue ;
                  }
                  else
                  {
                     gxTv_SdtSchedulerEvents_Day_Date = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Color") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_Day_Color = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
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
            sName = "SchedulerEvents.Day" ;
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
         if ( (DateTime.MinValue==gxTv_SdtSchedulerEvents_Day_Date) )
         {
            oWriter.WriteStartElement("Date");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("Date", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         oWriter.WriteElement("Color", StringUtil.RTrim( gxTv_SdtSchedulerEvents_Day_Color));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("Date", (Object)(sDateCnv));
         AddObjectProperty("Color", (Object)(gxTv_SdtSchedulerEvents_Day_Color));
         return  ;
      }

      public DateTime gxTpr_Date
      {
         get {
            return gxTv_SdtSchedulerEvents_Day_Date ;
         }

         set {
            gxTv_SdtSchedulerEvents_Day_Date = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_Day_Date_SetNull( )
      {
         gxTv_SdtSchedulerEvents_Day_Date = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_Day_Date_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Color
      {
         get {
            return gxTv_SdtSchedulerEvents_Day_Color ;
         }

         set {
            gxTv_SdtSchedulerEvents_Day_Color = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_Day_Color_SetNull( )
      {
         gxTv_SdtSchedulerEvents_Day_Color = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_Day_Color_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSchedulerEvents_Day_Date = DateTime.MinValue ;
         gxTv_SdtSchedulerEvents_Day_Color = "" ;
         sTagName = "" ;
         sDateCnv = "" ;
         sNumToPad = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSchedulerEvents_Day_Color ;
      protected String sTagName ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtSchedulerEvents_Day_Date ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
