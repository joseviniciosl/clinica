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
   public class SdtSchedulerEvents_event : GxUserType
   {
      public SdtSchedulerEvents_event( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSchedulerEvents_event( IGxContext context )
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Id") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Id = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Name") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Name = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Notes") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Notes = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Link") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Link = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "StartTime") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtSchedulerEvents_event_Starttime = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "EndTime") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtSchedulerEvents_event_Endtime = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AdditionalInformation") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Additionalinformation = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Color") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Color = oReader.Value ;
                  gxTv_SdtSchedulerEvents_event_Color_N = 0 ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "BackgroundColor") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Backgroundcolor = oReader.Value ;
                  gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 0 ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NameWeekView") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Nameweekview = oReader.Value ;
                  gxTv_SdtSchedulerEvents_event_Nameweekview_N = 0 ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NameMonthView") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Namemonthview = oReader.Value ;
                  gxTv_SdtSchedulerEvents_event_Namemonthview_N = 0 ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NameDayView") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Namedayview = oReader.Value ;
                  gxTv_SdtSchedulerEvents_event_Namedayview_N = 0 ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ToolTip") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_event_Tooltip = oReader.Value ;
                  gxTv_SdtSchedulerEvents_event_Tooltip_N = 0 ;
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
            sName = "SchedulerEvents.event" ;
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
         oWriter.WriteElement("Id", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Id));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteElement("Name", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Name));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteElement("Notes", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Notes));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         oWriter.WriteElement("Link", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Link));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         if ( (DateTime.MinValue==gxTv_SdtSchedulerEvents_event_Starttime) )
         {
            oWriter.WriteStartElement("StartTime");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("StartTime", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtSchedulerEvents_event_Endtime) )
         {
            oWriter.WriteStartElement("EndTime");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("EndTime", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         oWriter.WriteElement("AdditionalInformation", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Additionalinformation));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Color)) || ( gxTv_SdtSchedulerEvents_event_Color_N != 1 ) )
         {
            oWriter.WriteElement("Color", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Color));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Backgroundcolor)) || ( gxTv_SdtSchedulerEvents_event_Backgroundcolor_N != 1 ) )
         {
            oWriter.WriteElement("BackgroundColor", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Backgroundcolor));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Nameweekview)) || ( gxTv_SdtSchedulerEvents_event_Nameweekview_N != 1 ) )
         {
            oWriter.WriteElement("NameWeekView", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Nameweekview));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namemonthview)) || ( gxTv_SdtSchedulerEvents_event_Namemonthview_N != 1 ) )
         {
            oWriter.WriteElement("NameMonthView", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namemonthview));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namedayview)) || ( gxTv_SdtSchedulerEvents_event_Namedayview_N != 1 ) )
         {
            oWriter.WriteElement("NameDayView", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Namedayview));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Tooltip)) || ( gxTv_SdtSchedulerEvents_event_Tooltip_N != 1 ) )
         {
            oWriter.WriteElement("ToolTip", StringUtil.RTrim( gxTv_SdtSchedulerEvents_event_Tooltip));
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("Id", (Object)(gxTv_SdtSchedulerEvents_event_Id));
         AddObjectProperty("Name", (Object)(gxTv_SdtSchedulerEvents_event_Name));
         AddObjectProperty("Notes", (Object)(gxTv_SdtSchedulerEvents_event_Notes));
         AddObjectProperty("Link", (Object)(gxTv_SdtSchedulerEvents_event_Link));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtSchedulerEvents_event_Starttime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("StartTime", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtSchedulerEvents_event_Endtime)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("EndTime", (Object)(sDateCnv));
         AddObjectProperty("AdditionalInformation", (Object)(gxTv_SdtSchedulerEvents_event_Additionalinformation));
         AddObjectProperty("Color", (Object)(gxTv_SdtSchedulerEvents_event_Color));
         AddObjectProperty("BackgroundColor", (Object)(gxTv_SdtSchedulerEvents_event_Backgroundcolor));
         AddObjectProperty("NameWeekView", (Object)(gxTv_SdtSchedulerEvents_event_Nameweekview));
         AddObjectProperty("NameMonthView", (Object)(gxTv_SdtSchedulerEvents_event_Namemonthview));
         AddObjectProperty("NameDayView", (Object)(gxTv_SdtSchedulerEvents_event_Namedayview));
         AddObjectProperty("ToolTip", (Object)(gxTv_SdtSchedulerEvents_event_Tooltip));
         return  ;
      }

      public String gxTpr_Id
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Id ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Id = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Id_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Id = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Id_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Name
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Name ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Name = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Name_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Name = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Name_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Notes
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Notes ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Notes = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Notes_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Notes = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Notes_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Link
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Link ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Link = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Link_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Link = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Link_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Starttime
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Starttime ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Starttime_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Starttime_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Endtime
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Endtime ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Endtime_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Endtime_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Additionalinformation
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Additionalinformation ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Additionalinformation = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Additionalinformation_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Additionalinformation = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Additionalinformation_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Color
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Color ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Color_N = 0 ;
            gxTv_SdtSchedulerEvents_event_Color = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Color_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Color_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Color = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Color_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Backgroundcolor
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Backgroundcolor ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 0 ;
            gxTv_SdtSchedulerEvents_event_Backgroundcolor = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Backgroundcolor_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Backgroundcolor = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Backgroundcolor_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Nameweekview
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Nameweekview ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Nameweekview_N = 0 ;
            gxTv_SdtSchedulerEvents_event_Nameweekview = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Nameweekview_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Nameweekview_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Nameweekview = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Nameweekview_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Namemonthview
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Namemonthview ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Namemonthview_N = 0 ;
            gxTv_SdtSchedulerEvents_event_Namemonthview = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Namemonthview_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Namemonthview_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Namemonthview = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Namemonthview_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Namedayview
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Namedayview ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Namedayview_N = 0 ;
            gxTv_SdtSchedulerEvents_event_Namedayview = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Namedayview_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Namedayview_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Namedayview = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Namedayview_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Tooltip
      {
         get {
            return gxTv_SdtSchedulerEvents_event_Tooltip ;
         }

         set {
            gxTv_SdtSchedulerEvents_event_Tooltip_N = 0 ;
            gxTv_SdtSchedulerEvents_event_Tooltip = (String)(value) ;
         }

      }

      public void gxTv_SdtSchedulerEvents_event_Tooltip_SetNull( )
      {
         gxTv_SdtSchedulerEvents_event_Tooltip_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Tooltip = "" ;
         return  ;
      }

      public bool gxTv_SdtSchedulerEvents_event_Tooltip_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSchedulerEvents_event_Id = "" ;
         gxTv_SdtSchedulerEvents_event_Name = "" ;
         gxTv_SdtSchedulerEvents_event_Notes = "" ;
         gxTv_SdtSchedulerEvents_event_Link = "" ;
         gxTv_SdtSchedulerEvents_event_Starttime = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtSchedulerEvents_event_Endtime = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtSchedulerEvents_event_Additionalinformation = "" ;
         gxTv_SdtSchedulerEvents_event_Color = "" ;
         gxTv_SdtSchedulerEvents_event_Color_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Backgroundcolor = "" ;
         gxTv_SdtSchedulerEvents_event_Backgroundcolor_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Nameweekview = "" ;
         gxTv_SdtSchedulerEvents_event_Nameweekview_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Namemonthview = "" ;
         gxTv_SdtSchedulerEvents_event_Namemonthview_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Namedayview = "" ;
         gxTv_SdtSchedulerEvents_event_Namedayview_N = 1 ;
         gxTv_SdtSchedulerEvents_event_Tooltip = "" ;
         gxTv_SdtSchedulerEvents_event_Tooltip_N = 1 ;
         sTagName = "" ;
         sDateCnv = "" ;
         sNumToPad = "" ;
         return  ;
      }

      protected short gxTv_SdtSchedulerEvents_event_Color_N ;
      protected short gxTv_SdtSchedulerEvents_event_Backgroundcolor_N ;
      protected short gxTv_SdtSchedulerEvents_event_Nameweekview_N ;
      protected short gxTv_SdtSchedulerEvents_event_Namemonthview_N ;
      protected short gxTv_SdtSchedulerEvents_event_Namedayview_N ;
      protected short gxTv_SdtSchedulerEvents_event_Tooltip_N ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSchedulerEvents_event_Id ;
      protected String gxTv_SdtSchedulerEvents_event_Name ;
      protected String gxTv_SdtSchedulerEvents_event_Notes ;
      protected String gxTv_SdtSchedulerEvents_event_Link ;
      protected String gxTv_SdtSchedulerEvents_event_Additionalinformation ;
      protected String gxTv_SdtSchedulerEvents_event_Color ;
      protected String gxTv_SdtSchedulerEvents_event_Backgroundcolor ;
      protected String gxTv_SdtSchedulerEvents_event_Nameweekview ;
      protected String gxTv_SdtSchedulerEvents_event_Namemonthview ;
      protected String gxTv_SdtSchedulerEvents_event_Namedayview ;
      protected String gxTv_SdtSchedulerEvents_event_Tooltip ;
      protected String sTagName ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtSchedulerEvents_event_Starttime ;
      protected DateTime gxTv_SdtSchedulerEvents_event_Endtime ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
