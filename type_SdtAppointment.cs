using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtAppointment : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtAppointment( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
         context.SetTheme("Fantastic");
      }

      public SdtAppointment( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public void Load( String AV240AppointmentCode )
      {
         IGxSilentTrn obj ;
         obj = getTransaction() ;
         obj.LoadKey(new Object[] {(String)AV240AppointmentCode});
         return  ;
      }

      public IGxCollection GetMessages( )
      {
         short item = 1 ;
         IGxCollection msgs = new GxObjectCollection( context, "Messages.Message", "Genexus", "SdtMessages_Message", "GeneXus.Programs") ;
         SdtMessages_Message m1 ;
         IGxSilentTrn trn = getTransaction() ;
         msglist msgList = trn.GetMessages() ;
         while ( item <= msgList.ItemCount )
         {
            m1 = new SdtMessages_Message(context) ;
            m1.gxTpr_Id = msgList.getItemValue(item) ;
            m1.gxTpr_Description = msgList.getItemText(item) ;
            m1.gxTpr_Type = msgList.getItemType(item) ;
            msgs.Add(m1, 0);
            item = (short)(item+1) ;
         }
         return msgs ;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentCode") )
               {
                  gxTv_SdtAppointment_Appointmentcode = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "PacienteId") )
               {
                  gxTv_SdtAppointment_Pacienteid = (int)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentStartDate") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAppointment_Appointmentstartdate = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAppointment_Appointmentstartdate = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentEndDate") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAppointment_Appointmentenddate = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAppointment_Appointmentenddate = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentObs") )
               {
                  gxTv_SdtAppointment_Appointmentobs = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_SdtAppointment_Mode = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_SdtAppointment_Initialized = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentCode_Z") )
               {
                  gxTv_SdtAppointment_Appointmentcode_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "PacienteId_Z") )
               {
                  gxTv_SdtAppointment_Pacienteid_Z = (int)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentStartDate_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAppointment_Appointmentstartdate_Z = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAppointment_Appointmentstartdate_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentEndDate_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAppointment_Appointmentenddate_Z = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAppointment_Appointmentenddate_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AppointmentObs_Z") )
               {
                  gxTv_SdtAppointment_Appointmentobs_Z = oReader.Value ;
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
            sName = "Appointment" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "Clinica" ;
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
         oWriter.WriteElement("AppointmentCode", StringUtil.RTrim( gxTv_SdtAppointment_Appointmentcode));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("PacienteId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtAppointment_Pacienteid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( (DateTime.MinValue==gxTv_SdtAppointment_Appointmentstartdate) )
         {
            oWriter.WriteStartElement("AppointmentStartDate");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AppointmentStartDate", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtAppointment_Appointmentenddate) )
         {
            oWriter.WriteStartElement("AppointmentEndDate");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AppointmentEndDate", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         oWriter.WriteElement("AppointmentObs", StringUtil.RTrim( gxTv_SdtAppointment_Appointmentobs));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_SdtAppointment_Mode));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtAppointment_Initialized), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("AppointmentCode_Z", StringUtil.RTrim( gxTv_SdtAppointment_Appointmentcode_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("PacienteId_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtAppointment_Pacienteid_Z), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( (DateTime.MinValue==gxTv_SdtAppointment_Appointmentstartdate_Z) )
         {
            oWriter.WriteStartElement("AppointmentStartDate_Z");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AppointmentStartDate_Z", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtAppointment_Appointmentenddate_Z) )
         {
            oWriter.WriteStartElement("AppointmentEndDate_Z");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AppointmentEndDate_Z", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         oWriter.WriteElement("AppointmentObs_Z", StringUtil.RTrim( gxTv_SdtAppointment_Appointmentobs_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("AppointmentCode", (Object)(gxTv_SdtAppointment_Appointmentcode));
         AddObjectProperty("PacienteId", (Object)(gxTv_SdtAppointment_Pacienteid));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentstartdate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AppointmentStartDate", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentenddate)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AppointmentEndDate", (Object)(sDateCnv));
         AddObjectProperty("AppointmentObs", (Object)(gxTv_SdtAppointment_Appointmentobs));
         AddObjectProperty("Mode", (Object)(gxTv_SdtAppointment_Mode));
         AddObjectProperty("Initialized", (Object)(gxTv_SdtAppointment_Initialized));
         AddObjectProperty("AppointmentCode_Z", (Object)(gxTv_SdtAppointment_Appointmentcode_Z));
         AddObjectProperty("PacienteId_Z", (Object)(gxTv_SdtAppointment_Pacienteid_Z));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentstartdate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AppointmentStartDate_Z", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAppointment_Appointmentenddate_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AppointmentEndDate_Z", (Object)(sDateCnv));
         AddObjectProperty("AppointmentObs_Z", (Object)(gxTv_SdtAppointment_Appointmentobs_Z));
         return  ;
      }

      public String gxTpr_Appointmentcode
      {
         get {
            return gxTv_SdtAppointment_Appointmentcode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtAppointment_Appointmentcode, value) != 0 )
            {
               gxTv_SdtAppointment_Mode = "INS" ;
               this.gxTv_SdtAppointment_Appointmentcode_Z_SetNull( );
               this.gxTv_SdtAppointment_Pacienteid_Z_SetNull( );
               this.gxTv_SdtAppointment_Appointmentstartdate_Z_SetNull( );
               this.gxTv_SdtAppointment_Appointmentenddate_Z_SetNull( );
               this.gxTv_SdtAppointment_Appointmentobs_Z_SetNull( );
            }
            gxTv_SdtAppointment_Appointmentcode = (String)(value) ;
         }

      }

      public int gxTpr_Pacienteid
      {
         get {
            return gxTv_SdtAppointment_Pacienteid ;
         }

         set {
            gxTv_SdtAppointment_Pacienteid = (int)(value) ;
         }

      }

      public DateTime gxTpr_Appointmentstartdate
      {
         get {
            return gxTv_SdtAppointment_Appointmentstartdate ;
         }

         set {
            gxTv_SdtAppointment_Appointmentstartdate = (DateTime)(value) ;
         }

      }

      public DateTime gxTpr_Appointmentenddate
      {
         get {
            return gxTv_SdtAppointment_Appointmentenddate ;
         }

         set {
            gxTv_SdtAppointment_Appointmentenddate = (DateTime)(value) ;
         }

      }

      public String gxTpr_Appointmentobs
      {
         get {
            return gxTv_SdtAppointment_Appointmentobs ;
         }

         set {
            gxTv_SdtAppointment_Appointmentobs = (String)(value) ;
         }

      }

      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtAppointment_Mode ;
         }

         set {
            gxTv_SdtAppointment_Mode = (String)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Mode_SetNull( )
      {
         gxTv_SdtAppointment_Mode = "" ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Mode_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtAppointment_Initialized ;
         }

         set {
            gxTv_SdtAppointment_Initialized = (short)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Initialized_SetNull( )
      {
         gxTv_SdtAppointment_Initialized = 0 ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Initialized_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Appointmentcode_Z
      {
         get {
            return gxTv_SdtAppointment_Appointmentcode_Z ;
         }

         set {
            gxTv_SdtAppointment_Appointmentcode_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Appointmentcode_Z_SetNull( )
      {
         gxTv_SdtAppointment_Appointmentcode_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Appointmentcode_Z_IsNull( )
      {
         return false ;
      }

      public int gxTpr_Pacienteid_Z
      {
         get {
            return gxTv_SdtAppointment_Pacienteid_Z ;
         }

         set {
            gxTv_SdtAppointment_Pacienteid_Z = (int)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Pacienteid_Z_SetNull( )
      {
         gxTv_SdtAppointment_Pacienteid_Z = 0 ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Pacienteid_Z_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Appointmentstartdate_Z
      {
         get {
            return gxTv_SdtAppointment_Appointmentstartdate_Z ;
         }

         set {
            gxTv_SdtAppointment_Appointmentstartdate_Z = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Appointmentstartdate_Z_SetNull( )
      {
         gxTv_SdtAppointment_Appointmentstartdate_Z = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Appointmentstartdate_Z_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Appointmentenddate_Z
      {
         get {
            return gxTv_SdtAppointment_Appointmentenddate_Z ;
         }

         set {
            gxTv_SdtAppointment_Appointmentenddate_Z = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Appointmentenddate_Z_SetNull( )
      {
         gxTv_SdtAppointment_Appointmentenddate_Z = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Appointmentenddate_Z_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Appointmentobs_Z
      {
         get {
            return gxTv_SdtAppointment_Appointmentobs_Z ;
         }

         set {
            gxTv_SdtAppointment_Appointmentobs_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtAppointment_Appointmentobs_Z_SetNull( )
      {
         gxTv_SdtAppointment_Appointmentobs_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtAppointment_Appointmentobs_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtAppointment_Appointmentcode = "" ;
         gxTv_SdtAppointment_Appointmentstartdate = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAppointment_Appointmentenddate = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAppointment_Appointmentobs = "" ;
         gxTv_SdtAppointment_Mode = "" ;
         gxTv_SdtAppointment_Appointmentcode_Z = "" ;
         gxTv_SdtAppointment_Appointmentstartdate_Z = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAppointment_Appointmentenddate_Z = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAppointment_Appointmentobs_Z = "" ;
         sTagName = "" ;
         sDateCnv = "" ;
         sNumToPad = "" ;
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "appointment", "GeneXus.Programs.appointment_bc", new Object[] {context}, constructorCallingAssembly) ;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtAppointment_Initialized ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_SdtAppointment_Pacienteid ;
      private int gxTv_SdtAppointment_Pacienteid_Z ;
      private String gxTv_SdtAppointment_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtAppointment_Appointmentstartdate ;
      private DateTime gxTv_SdtAppointment_Appointmentenddate ;
      private DateTime gxTv_SdtAppointment_Appointmentstartdate_Z ;
      private DateTime gxTv_SdtAppointment_Appointmentenddate_Z ;
      private String gxTv_SdtAppointment_Appointmentcode ;
      private String gxTv_SdtAppointment_Appointmentobs ;
      private String gxTv_SdtAppointment_Appointmentcode_Z ;
      private String gxTv_SdtAppointment_Appointmentobs_Z ;
      [NonSerialized()] private IGxDataStore dsDefault ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
   }

}
