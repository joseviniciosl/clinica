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
   public class SdtCalendario : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCalendario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
         context.SetTheme("Fantastic");
      }

      public SdtCalendario( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public void Load( String AV41ClinicaCodigo ,
                        String AV233CalendarioCodigo )
      {
         IGxSilentTrn obj ;
         obj = getTransaction() ;
         obj.LoadKey(new Object[] {(String)AV41ClinicaCodigo,(String)AV233CalendarioCodigo});
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "ClinicaCodigo") )
               {
                  gxTv_SdtCalendario_Clinicacodigo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioCodigo") )
               {
                  gxTv_SdtCalendario_Calendariocodigo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioObs") )
               {
                  gxTv_SdtCalendario_Calendarioobs = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "PacienteId") )
               {
                  gxTv_SdtCalendario_Pacienteid = (int)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioInicio") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtCalendario_Calendarioinicio = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtCalendario_Calendarioinicio = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioFinal") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtCalendario_Calendariofinal = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtCalendario_Calendariofinal = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_SdtCalendario_Mode = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_SdtCalendario_Initialized = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ClinicaCodigo_Z") )
               {
                  gxTv_SdtCalendario_Clinicacodigo_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioCodigo_Z") )
               {
                  gxTv_SdtCalendario_Calendariocodigo_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioObs_Z") )
               {
                  gxTv_SdtCalendario_Calendarioobs_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "PacienteId_Z") )
               {
                  gxTv_SdtCalendario_Pacienteid_Z = (int)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioInicio_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtCalendario_Calendarioinicio_Z = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtCalendario_Calendarioinicio_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CalendarioFinal_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtCalendario_Calendariofinal_Z = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtCalendario_Calendariofinal_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
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
            sName = "Calendario" ;
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
         oWriter.WriteElement("ClinicaCodigo", StringUtil.RTrim( gxTv_SdtCalendario_Clinicacodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("CalendarioCodigo", StringUtil.RTrim( gxTv_SdtCalendario_Calendariocodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("CalendarioObs", StringUtil.RTrim( gxTv_SdtCalendario_Calendarioobs));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("PacienteId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtCalendario_Pacienteid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( (DateTime.MinValue==gxTv_SdtCalendario_Calendarioinicio) )
         {
            oWriter.WriteStartElement("CalendarioInicio");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("CalendarioInicio", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtCalendario_Calendariofinal) )
         {
            oWriter.WriteStartElement("CalendarioFinal");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("CalendarioFinal", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_SdtCalendario_Mode));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtCalendario_Initialized), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("ClinicaCodigo_Z", StringUtil.RTrim( gxTv_SdtCalendario_Clinicacodigo_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("CalendarioCodigo_Z", StringUtil.RTrim( gxTv_SdtCalendario_Calendariocodigo_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("CalendarioObs_Z", StringUtil.RTrim( gxTv_SdtCalendario_Calendarioobs_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("PacienteId_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtCalendario_Pacienteid_Z), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( (DateTime.MinValue==gxTv_SdtCalendario_Calendarioinicio_Z) )
         {
            oWriter.WriteStartElement("CalendarioInicio_Z");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("CalendarioInicio_Z", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtCalendario_Calendariofinal_Z) )
         {
            oWriter.WriteStartElement("CalendarioFinal_Z");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("CalendarioFinal_Z", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("ClinicaCodigo", (Object)(gxTv_SdtCalendario_Clinicacodigo));
         AddObjectProperty("CalendarioCodigo", (Object)(gxTv_SdtCalendario_Calendariocodigo));
         AddObjectProperty("CalendarioObs", (Object)(gxTv_SdtCalendario_Calendarioobs));
         AddObjectProperty("PacienteId", (Object)(gxTv_SdtCalendario_Pacienteid));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendarioinicio)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("CalendarioInicio", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendariofinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("CalendarioFinal", (Object)(sDateCnv));
         AddObjectProperty("Mode", (Object)(gxTv_SdtCalendario_Mode));
         AddObjectProperty("Initialized", (Object)(gxTv_SdtCalendario_Initialized));
         AddObjectProperty("ClinicaCodigo_Z", (Object)(gxTv_SdtCalendario_Clinicacodigo_Z));
         AddObjectProperty("CalendarioCodigo_Z", (Object)(gxTv_SdtCalendario_Calendariocodigo_Z));
         AddObjectProperty("CalendarioObs_Z", (Object)(gxTv_SdtCalendario_Calendarioobs_Z));
         AddObjectProperty("PacienteId_Z", (Object)(gxTv_SdtCalendario_Pacienteid_Z));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendarioinicio_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("CalendarioInicio_Z", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtCalendario_Calendariofinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("CalendarioFinal_Z", (Object)(sDateCnv));
         return  ;
      }

      public String gxTpr_Clinicacodigo
      {
         get {
            return gxTv_SdtCalendario_Clinicacodigo ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtCalendario_Clinicacodigo, value) != 0 )
            {
               gxTv_SdtCalendario_Mode = "INS" ;
               this.gxTv_SdtCalendario_Clinicacodigo_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendariocodigo_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendarioobs_Z_SetNull( );
               this.gxTv_SdtCalendario_Pacienteid_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendarioinicio_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendariofinal_Z_SetNull( );
            }
            gxTv_SdtCalendario_Clinicacodigo = (String)(value) ;
         }

      }

      public String gxTpr_Calendariocodigo
      {
         get {
            return gxTv_SdtCalendario_Calendariocodigo ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtCalendario_Calendariocodigo, value) != 0 )
            {
               gxTv_SdtCalendario_Mode = "INS" ;
               this.gxTv_SdtCalendario_Clinicacodigo_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendariocodigo_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendarioobs_Z_SetNull( );
               this.gxTv_SdtCalendario_Pacienteid_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendarioinicio_Z_SetNull( );
               this.gxTv_SdtCalendario_Calendariofinal_Z_SetNull( );
            }
            gxTv_SdtCalendario_Calendariocodigo = (String)(value) ;
         }

      }

      public String gxTpr_Calendarioobs
      {
         get {
            return gxTv_SdtCalendario_Calendarioobs ;
         }

         set {
            gxTv_SdtCalendario_Calendarioobs = (String)(value) ;
         }

      }

      public int gxTpr_Pacienteid
      {
         get {
            return gxTv_SdtCalendario_Pacienteid ;
         }

         set {
            gxTv_SdtCalendario_Pacienteid = (int)(value) ;
         }

      }

      public DateTime gxTpr_Calendarioinicio
      {
         get {
            return gxTv_SdtCalendario_Calendarioinicio ;
         }

         set {
            gxTv_SdtCalendario_Calendarioinicio = (DateTime)(value) ;
         }

      }

      public DateTime gxTpr_Calendariofinal
      {
         get {
            return gxTv_SdtCalendario_Calendariofinal ;
         }

         set {
            gxTv_SdtCalendario_Calendariofinal = (DateTime)(value) ;
         }

      }

      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtCalendario_Mode ;
         }

         set {
            gxTv_SdtCalendario_Mode = (String)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Mode_SetNull( )
      {
         gxTv_SdtCalendario_Mode = "" ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Mode_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtCalendario_Initialized ;
         }

         set {
            gxTv_SdtCalendario_Initialized = (short)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Initialized_SetNull( )
      {
         gxTv_SdtCalendario_Initialized = 0 ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Initialized_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Clinicacodigo_Z
      {
         get {
            return gxTv_SdtCalendario_Clinicacodigo_Z ;
         }

         set {
            gxTv_SdtCalendario_Clinicacodigo_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Clinicacodigo_Z_SetNull( )
      {
         gxTv_SdtCalendario_Clinicacodigo_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Clinicacodigo_Z_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Calendariocodigo_Z
      {
         get {
            return gxTv_SdtCalendario_Calendariocodigo_Z ;
         }

         set {
            gxTv_SdtCalendario_Calendariocodigo_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Calendariocodigo_Z_SetNull( )
      {
         gxTv_SdtCalendario_Calendariocodigo_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Calendariocodigo_Z_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Calendarioobs_Z
      {
         get {
            return gxTv_SdtCalendario_Calendarioobs_Z ;
         }

         set {
            gxTv_SdtCalendario_Calendarioobs_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Calendarioobs_Z_SetNull( )
      {
         gxTv_SdtCalendario_Calendarioobs_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Calendarioobs_Z_IsNull( )
      {
         return false ;
      }

      public int gxTpr_Pacienteid_Z
      {
         get {
            return gxTv_SdtCalendario_Pacienteid_Z ;
         }

         set {
            gxTv_SdtCalendario_Pacienteid_Z = (int)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Pacienteid_Z_SetNull( )
      {
         gxTv_SdtCalendario_Pacienteid_Z = 0 ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Pacienteid_Z_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Calendarioinicio_Z
      {
         get {
            return gxTv_SdtCalendario_Calendarioinicio_Z ;
         }

         set {
            gxTv_SdtCalendario_Calendarioinicio_Z = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Calendarioinicio_Z_SetNull( )
      {
         gxTv_SdtCalendario_Calendarioinicio_Z = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Calendarioinicio_Z_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Calendariofinal_Z
      {
         get {
            return gxTv_SdtCalendario_Calendariofinal_Z ;
         }

         set {
            gxTv_SdtCalendario_Calendariofinal_Z = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtCalendario_Calendariofinal_Z_SetNull( )
      {
         gxTv_SdtCalendario_Calendariofinal_Z = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtCalendario_Calendariofinal_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtCalendario_Clinicacodigo = "" ;
         gxTv_SdtCalendario_Calendariocodigo = "" ;
         gxTv_SdtCalendario_Calendarioobs = "" ;
         gxTv_SdtCalendario_Calendarioinicio = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtCalendario_Calendariofinal = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtCalendario_Mode = "" ;
         gxTv_SdtCalendario_Clinicacodigo_Z = "" ;
         gxTv_SdtCalendario_Calendariocodigo_Z = "" ;
         gxTv_SdtCalendario_Calendarioobs_Z = "" ;
         gxTv_SdtCalendario_Calendarioinicio_Z = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtCalendario_Calendariofinal_Z = (DateTime)(DateTime.MinValue) ;
         sTagName = "" ;
         sDateCnv = "" ;
         sNumToPad = "" ;
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "calendario", "GeneXus.Programs.calendario_bc", new Object[] {context}, constructorCallingAssembly) ;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtCalendario_Initialized ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_SdtCalendario_Pacienteid ;
      private int gxTv_SdtCalendario_Pacienteid_Z ;
      private String gxTv_SdtCalendario_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtCalendario_Calendarioinicio ;
      private DateTime gxTv_SdtCalendario_Calendariofinal ;
      private DateTime gxTv_SdtCalendario_Calendarioinicio_Z ;
      private DateTime gxTv_SdtCalendario_Calendariofinal_Z ;
      private String gxTv_SdtCalendario_Clinicacodigo ;
      private String gxTv_SdtCalendario_Calendariocodigo ;
      private String gxTv_SdtCalendario_Calendarioobs ;
      private String gxTv_SdtCalendario_Clinicacodigo_Z ;
      private String gxTv_SdtCalendario_Calendariocodigo_Z ;
      private String gxTv_SdtCalendario_Calendarioobs_Z ;
      [NonSerialized()] private IGxDataStore dsDefault ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
   }

}
